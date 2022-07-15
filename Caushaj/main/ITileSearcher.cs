using OOP21_EscapeFromUniversity_csharp;
using System;
namespace main
{

    /// <summary>
    /// An interface for searching a tile.
    /// </summary>
    public interface ITileSearcher
    {
        /// <summary>
        /// Search the tileset containing the tile with the specified id.
        /// </summary>
        /// <param name="id">the ID of the tile</param>
        /// <returns>the tileset containing the tile with the specified id</returns>
        public Tileset SearchTileset(int id);

        /// <summary>
        /// Calculate the position of a tile in the tileset.
        /// </summary>
        /// <param name="id">the ID of the tile</param>
        /// <param name="ts">the tileset</param>
        /// <returns>the position of the tile in the tileset</returns>
        public Point2D calcTPos(int id, Tileset ts);
    }
}