using System;

namespace DefaultNamespace;

public class Player : IPlayer, AbstractDynamicGameObject
{

    private static Point2D _hitBox = new Point2D(1, 1.4);
    private readonly int StartCredits { get; }
    private readonly int StartDamage { get; }
    private readonly int StartArmor { get; }
    private int _passed;
    private readonly double _shootDelay;
    private double _lastShot;
    private bool _shooting;
    private readonly Direction StartDirection { get; } = Direction.DOWN;
    private Point2D _prevPosition;
    private readonly IBulletFactory _bulletFactory;

    public Player(GameObjectType type, Point2D position, double speed, Vector2D direction, double shootDelay, GameInit map) : base(type, position, _hitBox, speed, direction, map)
    {
    Life = MaxLife.get;
    Credits = StartCredits.get;
    Damage = StartDamage.get;
    Armor = StartArmor.get;
    LastDirection = StartDirection.get;
    _passed = 0;
    _shootDelay = shootDelay;
    _shooting = false;
    BonusQuiz = false;
    _lastShot = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    _bulletFactory = new BulletFactory();
    _prevPosition = position;
    }
    
    public override int MaxLife { get; } 
    
    public override int MaxDamage { get; }
        
    public override int MaxArmor { get; }

    public override int Life { get; set; }
    
    public override int Credits { get; }
    
    public override int Damage { get; set; }
        
    public override int Armor { get; set; }

    public override int FinalMark
    {
        get;
        set {
            FinalMark = FinalMark.get * _passed + value;
            this.PassedExam();
            FinalMark = FinalMark.get / _passed;
            FinalMark = FinalMark.get * 110 / 30;
        }
    }

    public override bool BonusQuiz { get; set; }
    
    public override Direction LastDirection { get; set; }
        
    public override IGameInit Map { set; }

    public override void CollisionWith(IGameObject gObj2)
    {
        if (CollisionWithCheck(gObj2))
        {
            if (gObj2.GetType().GetCollisionType() == GameCollisionType.OBSTACLE)
            {
                if (gObj2.GetType() == GameObjectType.SHOP) Map.GetMapManager().SetupShop();
                Position = _prevPosition;
            }
        }
    }

    public override void Update(double deltaTime)
    {
        if (_shooting) this.Shoot();
        _prevPosition = GetObjectPosition();
        move(deltaTime);
    }

    public override void IncreaseCredits(int credits) => Credits += credits;

    public override void DecreaseCredits(int credits) => Credits -= credits;
    
    public override void ResetLife() => MaxLife.get;

    public override void SetDamageBuff(int damage) => Damage = Damage.get + damage;

    public override void SetArmorBuff(int armor) => Armor = Armor.get + armor;

    public override void TakeDamage(int damage)
    {
        Life = Life.get + Armor.get - damage;
        if (Life.get <= 0) GetMap().GetMapManager().Lost();
    }

    public override bool CanShoot(double deltaTime)
    {
        if (deltaTime + _lastShot >= _shootDelay)
        {
            _lastShot = 0;
            return true;
        }
        _lastShot = _lastShot + deltaTime;
        return false;
    }

    public override void SetShoot(bool shooting, Direction direction)
    {
        if (this.CanShoot(0.2))
        {
            _shooting = shooting;
            _shotDirection = direction.GetDirection();
        }
    }

    public override void Shoot()
    {
        IBullet bullet = _bulletFactory.CreatePlayerBullet(GetObjectPosition(), GetDirection(), Damage.get, Map.get);
        GetMap().AddDynamicGameObject(bullet);
        _shooting = false;
    }

    public override void PassedExam() => _passed++;
    
    public override bool IsDead() {
        return Life.get <= 0;
    } 
    
    public override bool IsGraduated() {
        return _passed >= 6;
    }
}