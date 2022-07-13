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
        public void testBoss1()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.createBoss1(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS1);
        }

        public void testBoss2()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.createBoss2(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS2);
        }

        public void testBoss3()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.createBoss3(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS3);
        }

        public void testBoss4()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.createBoss4(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS4);
        }

        public void testBoss5()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.createBoss5(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS5);
        }

        public void testBoss6()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Boss boss = _bossCreate.createBoss6(pos, vet, null);
            Assert.IsNotNull(boss);
            Assert.AreEqual(boss.Position, pos);
            Assert.AreEqual(boss.Direction, vet);
            Assert.AreEqual(boss.Type, GameObjteType.BOSS6);
        }
    }
}
