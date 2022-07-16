using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Enemy
{
    [TestClass]
    public class BossTest
    {
        BossFactory _bossCreate = new BossFactoryImpl();

        [TestMethod]
        public void TestBoss1()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.CreateBoss1(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS1);
        }

        [TestMethod]
        public void TestBoss2()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.CreateBoss2(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS2);
        }

        [TestMethod]
        public void TestBoss3()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.CreateBoss3(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS3);
        }

        [TestMethod]
        public void TestBoss4()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.CreateBoss4(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS4);
        }

        [TestMethod]
        public void TestBoss5()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.CreateBoss5(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS5);
        }

        [TestMethod]
        public void TestBoss6()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.CreateBoss6(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS6);
        }
    }
}
