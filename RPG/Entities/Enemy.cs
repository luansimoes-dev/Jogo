using System.Numerics;
using Raylib_cs;

namespace RPG.Entities;

public sealed class Enemy : Entity
{
    public Enemy(string name, Vector2 position, int xpReward = 10) : base(position)
    {
        Name = name;
        XPReward = xpReward;
    }

    public string Name { get; }
    public int XPReward { get; }

    public override void Update(float deltaTime)
    {
        // TODO: adicionar comportamento e movimento do inimigo.
    }

    public override void Draw()
    {
        Raylib.DrawRectangleV(Position, new Vector2(32, 32), Color.Red);
    }
}
