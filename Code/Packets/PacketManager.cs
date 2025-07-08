using System.Reflection;

namespace ProtankiNetworking.Packets;

/// <summary>
///     Manages packet types and their creation
/// </summary>
public static class PacketManager
{
    private static readonly Dictionary<int, Type> _packetTypes = new Dictionary<int, Type>();
    private static readonly Dictionary<string, Type> _packetNames = new Dictionary<string, Type>();

    static PacketManager()
    {
        // Find all packet types in the ProtankiNetworking assembly
        var assembly = typeof(AbstractPacket).Assembly;
        var packetTypes = assembly.GetTypes()
            .Where(t => t.IsSubclassOf(typeof(AbstractPacket)) && !t.IsAbstract);

        foreach (var type in packetTypes)
            try
            {
                // Get the static Id property
                var idProperty = type.GetProperty("Id", BindingFlags.Public | BindingFlags.Static);
                if (idProperty != null)
                {
                    var id = (int)idProperty.GetValue(null);
                    _packetTypes[id] = type;
                    _packetNames[type.Name] = type;
                }
            }
            catch (Exception ex)
            {
                // Log error but continue loading other packet types
                System.Diagnostics.Debug.WriteLine($"Failed to load packet type {type.Name}: {ex.Message}");
            }
    }

    /// <summary>
    ///     Gets a packet type by its ID
    /// </summary>
    /// <param name="id">The packet ID</param>
    /// <returns>The packet type, or null if not found</returns>
    public static Type GetPacketById(int id)
    {
        return _packetTypes.TryGetValue(id, out var type) ? type : null;
    }

    /// <summary>
    ///     Gets a packet type by its name
    /// </summary>
    /// <param name="name">The packet name</param>
    /// <returns>The packet type, or null if not found</returns>
    public static Type GetPacketByName(string name)
    {
        return _packetNames.TryGetValue(name, out var type) ? type : null;
    }

    /// <summary>
    ///     Creates a new packet instance by ID
    /// </summary>
    /// <param name="id">The packet ID</param>
    /// <returns>A new packet instance, or null if not found</returns>
    public static AbstractPacket CreatePacketById(int id)
    {
        var type = GetPacketById(id);
        return type != null ? (AbstractPacket)Activator.CreateInstance(type) : null;
    }

    /// <summary>
    ///     Creates a new packet instance by name
    /// </summary>
    /// <param name="name">The packet name</param>
    /// <returns>A new packet instance, or null if not found</returns>
    public static AbstractPacket CreatePacketByName(string name)
    {
        var type = GetPacketByName(name);
        return type != null ? (AbstractPacket)Activator.CreateInstance(type) : null;
    }
}