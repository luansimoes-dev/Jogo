using System.Numerics;
using RPG.Core;
using RPG.Data;
using RPG.Scenes;
using Raylib_cs;

namespace RPG.Entities;

public sealed class Player : Entity
{
    private readonly SceneManager sceneManager;
    private const float MovementSpeed = 200f;

    public Player(SceneManager sceneManager, Vector2 position) : base(position)
    {
        this.sceneManager = sceneManager;
        Inventory = new Inventory();
    }

    public Inventory Inventory { get; }

    public override void Update(float deltaTime)
    {
        var direction = InputManager.GetMovementVector();
        Velocity = direction * MovementSpeed;
        Position += Velocity * deltaTime;

        if (InputManager.IsInventoryPressed())
        {
            sceneManager.ChangeScene(new InventoryScene(sceneManager, this));
        }
    }

    public override void Draw()
    {
        Raylib.DrawRectangleV(Position, new Vector2(32, 32), Color.Blue);
    }
}
