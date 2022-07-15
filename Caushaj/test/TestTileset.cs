using main;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public class TestTileset
    {
        private MapProperties _map;
        private TileSearcher _ts;

        [SetUp]
        public void Setup()
        {
            _map = new TMXMapParser("final-map.tmx").Parse();
            _ts = new TileSearcher(_map);
        }

        [Test]
        public void TestTilesetName()
        {
            List<string> tilesetNames = _map.Tilesets.Select(t => t.FileName).ToList();
            Assert.IsTrue(tilesetNames.Contains("/tilesets/Characters_MV.png"));
            Assert.IsTrue(tilesetNames.Contains("tilesets/grass.png"));
            Assert.IsTrue(tilesetNames.Contains("tilesets/Room_Builder_free_48x48.png"));
            Assert.IsFalse(tilesetNames.Contains("tilesets/grass.tsx"));
            Assert.IsFalse(tilesetNames.Contains("final-map.tmx"));
            Assert.IsFalse(tilesetNames.Contains(".png"));
        }

        [Test]
        public void TestSearchTileset()
        {
            Assert.AreEqual("tilesets/Room_Builder_free_48x48.png", _ts.SearchTileset(1).FileName);
            Assert.AreEqual("tilesets/Characters_MV.png", _ts.SearchTileset(2007).FileName);
            Assert.AreNotEqual("tilesets/Characters_MV.png", _ts.SearchTileset(2008).FileName);
        }
    }
}