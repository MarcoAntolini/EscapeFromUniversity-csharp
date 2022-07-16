namespace DefaultNamespace;

public interface IPlayer : DynamicGameObject
{
    int MaxLife { get; } 

    int MaxDamage { get; }

    int MaxArmor { get; }

    int Life { get; set; }

    int Credits { get; }

    int Damage { get; set; }

    int Armor { get; set; }

    int FinalMark { get; set; }

    bool BonusQuiz { get; set; }

    Direction LastDirection { get; set; }

    IGameInit Map { set; }

    void IncreaseCredits(int credits);

    void DecreaseCredits(int credits);

    void ResetLife();

    void SetDamageBuff(int damage);

    void SetArmorBuff(int armor);

    void TakeDamage(int damage);

    bool CanShoot(double deltaTime);

    void SetShoot(bool shooting, Direction direction);

    void Shoot();

    void PassedExam();

    bool IsDead();

    bool IsGraduated();

}