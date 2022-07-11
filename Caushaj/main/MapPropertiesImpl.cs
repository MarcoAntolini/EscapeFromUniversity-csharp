using System;
using System.Collections.Generic;

namespace main;

/// <summary>
/// A class which implements MapProperties.
/// </summary>
public class MapPropertiesImpl : MapProperties
{
    /// <summary>
    /// A constructor for MapPropertiesImpl.
    /// </summary>
    /// <param name="width">the width of the map</param>
    /// <param name="height">the height of the map</param>
    /// <param name="tileWidth">the width of a tile</param>
    /// <param name="tileHeight">the height of a tile</param>
    /// <param name="tilesets">the list of tilesets</param>
    public MapPropertiesImpl(int width, int height, int tileWidth, int tileHeight, List<Tileset> tilesets) {
        Width = width;
        Height = height;
        TileWidth = tileWidth;
        TileHeight = tileHeight;
        Tilesets = tilesets;
    }
    
    public override int Width() { get; }

    public override int Height() { get; }

    public override int TileWidth() { get; }

    public override int TileHeight() { get; }
    
    public override List<Tileset> Tilesets() { get; }

    public override ToString()
    {
        return "MapProperties [width=" + width + ", height=" + height + ", tileWidth=" + tileWidth + ", tileHeight="
               + tileHeight + ", tilesets=" + tilesets + "]";
    }
}