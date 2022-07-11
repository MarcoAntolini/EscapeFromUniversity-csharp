using System;
using System.Collections.Generic;

namespace main;

/// <summary>
/// A class which models a map.
/// </summary>
public class MapPropertiesImpl
{
    private int _width;
    private int _height;
    private int _tileWidth;
    private int _tileHeight;
    private List<Tileset> _tilesets;
    
    public MapProperties(int width, int height, int tileWidth, int tileHeight,
        List<Layer> layers, List<Tileset> tilesets) {
        _width = width;
        _height = height;
        _tileWidth = tileWidth;
        _tileHeight = tileHeight;
        _layers = layers;
        _tilesets = tilesets;
    }
}