using System;
using System.Linq;

namespace main
{

    /// <summary>
    /// A class which implements ITileSearcher.
    /// </summary>
    public class TileSearcher : ITileSearcher
    {
        private readonly MapProperties _map;

        /// <summary>
        /// A constructor for TileSearcher.
        /// </summary>
        /// <param name="map">the map</param>
        public TileSearcher(MapProperties map)
        {
            _map = map;
        }

        public Point2D calcTPos(int id, Tileset ts)
        {
            var cols = ts.Columns;
            var idOffset = id - ts.FirstTileId;
            var x = idOffset % cols;
            var y = idOffset / cols;
            return new Point2D(x, y);
        }

        public Tileset SearchTileset(int id)
        {
            return _map.Tilesets.TakeWhile(t => t.FirstTileId <= id).Max();
        }
    }
}