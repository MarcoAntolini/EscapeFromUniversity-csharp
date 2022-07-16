using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_daniel_capannini.Enemy
{
    abstract class AbstractBoss : AbstractDynamicGameObject, Boss
    {
        private double _shootLastTime;
        private Point2D _previousPosition;
        private double _shootDelay;

        public AbstractBoss(double speed, Point2D position, Point2D hitBoxSize, Vector2D direction, GameObjteType type, int life, double shootDelay, int impactDamage, string exam, GameInit map) : base(type, position, hitBoxSize, speed, direction, map)
        {
            Life = life;
            _shootDelay = shootDelay;
            BossState = BossState.QUIZ;
            _previousPosition = position;
            ImpactDamage = impactDamage;
            BossExam = exam;

        }

        public string BossExam { get; }
        public int Life { get; private set; }
        public BossState BossState { get; set; }
        public int ImpactDamage { get; }

        public void Kill()
        {
            this.Map.State = State.PLAY;
            this.Map.DeleteGameObject(this);
        }

        public override void update(double deltaTime)
        {
            if (this.BossState == BossState.FIGHT)
                this.MaybeShoot(deltaTime);
        }

        public void MaybeShoot(double deltaTime)
        {
            if (this.CanShoot(deltaTime))
                this.Shoot();
        }

        public void TakeDamage(int damage)
        {
            this.Life = this.Life - damage;
            if (this.Life <= 0)
                this.Kill();
        }

        protected Vector2D NewDirection()
        {
            Point2D playerPos = this.Map.Player.Position;
            return new Vector2D(-(this.Position.X - playerPos.X), -(this.Position.Y - playerPos.Y));
        }

        private bool CanShoot(double deltaTime)
        {
            if (deltaTime + this._shootLastTime > _shootDelay)
            {
                this._shootLastTime = 0;
                return true;
            }
            this._shootLastTime = this._shootLastTime + deltaTime;
            return false;
        }

        public abstract void Shoot();

        public override void CollisionWith(GameObject gObj2)
        {
            if (this.CollisionWithCheck(gObj2))
            {
                switch (gObj2.CollisionType)
                {
                    case GameCollisionType.OBSTACLE:
                        this.Position = _previousPosition;
                        this.Direction = this.Direction.Multiplication(-1);
                        break;
                    case GameCollisionType.ENTITY:
                        if (gObj2.Type == GameObjteType.PLAYER)
                        {
                            if (this.BossState == BossState.QUIZ)
                            {
                                this.Map.GoQuiz(this);
                            }
                            else
                            {
                                Player player = (Player)gObj2;
                                player.TakeDamage(this.ImpactDamage);
                            }
                        }
                        this.Position = _previousPosition;
                        break;
                    default:
                        break;
                }
            }
        }

        void Boss.SetQuizResult(int result) => this.Map.Player.SetFinalMark(result);

        void Boss.SetQuizCredits(int credits) => this.Map.Player.IncreaseCredits(credits);
    }
}
