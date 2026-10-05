using RPG.Entities;

namespace RPG.Systems;

public static class CombatSystem
{
    public static void Attack(Entity attacker, Entity target)
    {
        int damage = Math.Max(1, attacker.Stats.Attack - target.Stats.Defense / 2);
        target.Stats.TakeDamage(damage);
    }
}
