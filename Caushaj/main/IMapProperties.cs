using System.Collections.Generic;

namespace main
{

    /// <summary>
    /// An interface which models a map. 
    /// </summary>
    public interface IMapProperties
    {
        /// <summary>
        /// Returns the width of the map.
        /// </summary>
        /// <returns>the width</returns>
        public int Width();

        /// <summary>
        /// Returns the height of the map.
        /// </summary>
        /// <returns>the height</returns>
        public int Height();

        /// <summary>
        /// Returns the width of a tile.
        /// </summary>
        /// <returns>the width of a tile</returns>
        public int TileWidth();

        /// <summary>
        /// Returns the height of a tile.
        /// </summary>
        /// <returns>the height of a tile</returns>
        public int TileHeight();

        /// <summary>
        /// Returns the list of tilesets used to create the map.
        /// </summary>
        /// <returns>the list of tilesets</returns>
        public List<Tileset> Tilesets();
    }
}