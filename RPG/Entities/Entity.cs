using System.Numerics;
using RPG.Data;

namespace RPG.Entities;

public abstract class Entity
{
    protected Entity(Vector2 position)
    {
        Position = position;
        Velocity = Vector2.Zero;
        Stats = new Stats();
    }

    public Vector2 Position { get; protected set; }
    public Vector2 Velocity { get; protected set; }
    public Stats Stats { get; }
    public bool IsAlive => !Stats.IsDead;

    public abstract void Update(float deltaTime);

    public abstract void Draw();
}
