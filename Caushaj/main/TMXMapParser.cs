using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace main
{
    public class TMXMapParser
    {
        private readonly string _mapName;

        public TMXMapParser(string mapName)
        {
            _mapName = mapName;
        }

        /// <summary>
        /// Parsing of the TMX file returning the map properties.
        /// </summary>
        /// <returns>the map properties</returns>
        public MapProperties Parse()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_mapName);

            var mapNode = doc.GetElementsByTagName("map").Item(0);
            var attributes = mapNode.Attributes;

            var w = int.Parse(attributes.GetNamedItem("width").InnerText);
            var h = int.Parse(attributes.GetNamedItem("height").InnerText);
            var tw = int.Parse(attributes.GetNamedItem("tilewidth").InnerText);
            var th = int.Parse(attributes.GetNamedItem("tileheight").InnerText);

            var tilesetsNode = doc.GetElementsByTagName("tileset");
            var tilesetsStream = NodelistToStreamParse(tilesetsNode);

            return new MapProperties(w, h, tw, th, tilesetsStream.Select(ParseTileset).ToList());
        }

        private XmlNode TilesetNodeFromName(string tilesetName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tilesetName);
            return doc.DocumentElement.GetElementsByTagName("tileset").Item(0);
        }

        private Tileset ParseTileset(XmlNode tNode)
        {
            var tileset = TilesetNodeFromName(tNode.Attributes["source"].Value);
            var firstTileId = int.Parse(tNode.Attributes["firstgid"].Value);
            var children = NodelistToStreamParse(tileset.ChildNodes).ToArray();
            var path = children.Where(p => "image".Equals(p.Name)).First().Attributes["source"].Value;
            var tilesCount = int.Parse(tileset.Attributes["tilecount"].Value);
            var cols = int.Parse(tileset.Attributes["columns"].Value);

            return new Tileset(path, tilesCount, cols, firstTileId);
        }

        private IEnumerable<XmlNode> NodelistToStreamParse(XmlNodeList list)
        {
            return Enumerable.Range(0, list.Count).Select(item => list.Item(item));
        }
    }
}