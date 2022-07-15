using System.Collections.Generic;

namespace main {

    /// <summary>
    /// A class which implements IMapProperties.
    /// </summary>
    public class MapProperties : IMapProperties
    {

        /// <summary>
        /// A constructor for MapProperties.
        /// </summary>
        /// <param name="width">the width of the map</param>
        /// <param name="height">the height of the map</param>
        /// <param name="tileWidth">the width of a tile</param>
        /// <param name="tileHeight">the height of a tile</param>
        /// <param name="tilesets">the list of tilesets</param>
        public MapProperties(int width, int height, int tileWidth, int tileHeight, List<Tileset> tilesets)
        {
            Width = width;
            Height = height;
            TileWidth = tileWidth;
            TileHeight = tileHeight;
            Tilesets = tilesets;
        }

        public int Width { get; }
        public int Height { get; }
        public int TileWidth { get; }
        public int TileHeight { get; }
        public List<Tileset> Tilesets { get; }
    }
}