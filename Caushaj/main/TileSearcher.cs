using System;
namespace main;

/// <summary>
/// A class which implements TileSearcher.
/// </summary>
public class TileSearcher : ITileSearcher
{
    private readonly MapProperties _mapProperties;
    
    /// <summary>
    /// A constructor for TileSearcherImpl.
    /// </summary>
    /// <param name="map">the map</param>
    public TileSearcherImpl(MapProperties map)
    {
        _map = map;
    }

    public override Tileset SearchTileset(int id)
    {
        return null;
    }
}