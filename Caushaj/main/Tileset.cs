using System;

namespace main;

/// <summary>
/// A class which models a Tileset.
/// </summary>
public class Tileset
{
    private string _fileName;
    private int _tilesCount;
    private int _columns;
    private int _rows;
    private int _firstTileId;

    /// <summary>
    /// A constructor for Tileset.
    /// </summary>
    /// <param name="fileName">the name of the file containing the tileset</param>
    /// <param name="tilesCount">the number of tiles in the tileset</param>
    /// <param name="columns">the number of columns in the tileset</param>
    /// <param name="firstTileId">the ID of the first tile</param>
    public Tileset(string fileName, int tilesCount, int columns, int firstTileId)
    {
        _fileName = fileName;
        _tilesCount = tilesCount;
        _columns = columns;
        _rows = tilesCount / columns;
        _firstTileId = firstTileId;
    }

    /// <summary>
    /// Returns the name of the file containing the tileset.
    /// </summary>
    public string FileName { get; }

    /// <summary>
    /// Returns the number of tiles in the tileset.
    /// </summary>
    public string TilesCount { get; }
    
    /// <summary>
    /// Returns the number of columns in the tileset.
    /// </summary>
    public string Columns { get; }
    
    /// <summary>
    /// Returns the number of rows in the tileset.
    /// </summary>
    public string Rows { get; }
    
    /// <summary>
    /// Returns the ID of the first tileset.
    /// </summary>
    public string FirstTileId { get; }
    
    public override string ToString()
    {
        return "Tileset{"
               + "fileName='" + fileName + '\''
               + ", tilesCount=" + tilesCount
               + ", columns=" + columns
               + ", rows=" + rows
               + ", firstTileId=" + firstTileId
               + '}';
    }
}