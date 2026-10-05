namespace RPG.Data;

public sealed class Stats
{
    public int HP { get; private set; } = 100;
    public int MaxHP { get; } = 100;
    public int MP { get; private set; } = 50;
    public int MaxMP { get; } = 50;
    public int Attack { get; set; } = 10;
    public int Defense { get; set; } = 5;
    public int Level { get; set; } = 1;
    public int XP { get; set; }
    public bool IsDead => HP <= 0;

    public void TakeDamage(int damage)
    {
        HP = Math.Max(0, HP - Math.Max(0, damage));
    }
}
