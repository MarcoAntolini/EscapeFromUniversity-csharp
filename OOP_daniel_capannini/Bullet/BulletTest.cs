using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Bullet
{
    [TestClass]
    public class BulletTest
    {
        private BulletFactory _bulletCreate = new BulletFactoryImpl();

        [TestMethod]
        public void TestBulletBoss1()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Bullet bull = _bulletCreate.CreateBoss1Bullet(pos, vet, null);
            Assert.IsNotNull(bull);
            Assert.AreEqual(bull.Position, pos);
            Assert.AreEqual(bull.Direction, vet);
            Assert.AreEqual(bull.Type, GameObjteType.BULLET_BOSS_1);
        }

        [TestMethod]
        public void TestBulletBoss2()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Bullet bull = _bulletCreate.CreateBoss2Bullet(pos, vet, null);
            Assert.IsNotNull(bull);
            Assert.AreEqual(bull.Position, pos);
            Assert.AreEqual(bull.Direction, vet);
            Assert.AreEqual(bull.Type, GameObjteType.BULLET_BOSS_2);
        }

        [TestMethod]
        public void TestBulletBoss3()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Bullet bull = _bulletCreate.CreateBoss3Bullet(pos, vet, null);
            Assert.IsNotNull(bull);
            Assert.AreEqual(bull.Position, pos);
            Assert.AreEqual(bull.Direction, vet);
            Assert.AreEqual(bull.Type, GameObjteType.BULLET_BOSS_3);
        }

        [TestMethod]
        public void TestBulletBoss4()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Bullet bull = _bulletCreate.CreateBoss4Bullet(pos, vet, null);
            Assert.IsNotNull(bull);
            Assert.AreEqual(bull.Position, pos);
            Assert.AreEqual(bull.Direction, vet);
            Assert.AreEqual(bull.Type, GameObjteType.BULLET_BOSS_4);
        }

        [TestMethod]
        public void TestBulletBoss5()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Bullet bull = _bulletCreate.CreateBoss5Bullet(pos, vet, null);
            Assert.IsNotNull(bull);
            Assert.AreEqual(bull.Position, pos);
            Assert.AreEqual(bull.Direction, vet);
            Assert.AreEqual(bull.Type, GameObjteType.BULLET_BOSS_5);
        }

        [TestMethod]
        public void TestBulletBoss6()
        {
            Point2D pos = new Point2D(10, 5);
            Vector2D vet = new Vector2D(1, 0);
            Bullet bull = _bulletCreate.CreateBoss6Bullet(pos, vet, null);
            Assert.IsNotNull(bull);
            Assert.AreEqual(bull.Position, pos);
            Assert.AreEqual(bull.Direction, vet);
            Assert.AreEqual(bull.Type, GameObjteType.BULLET_BOSS_6);
        }

    }
}
