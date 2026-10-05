using RPG.Core;
using RPG.Entities;
using Raylib_cs;
using System.Numerics;

namespace RPG.Scenes;

public sealed class WorldScene : Scene
{
    private readonly Player player;

    public WorldScene(SceneManager sceneManager) : base(sceneManager)
    {
        player = new Player(sceneManager, new Vector2(100, 100));
    }

    public override void Update(float deltaTime)
    {
        player.Update(deltaTime);
    }

    public override void Draw()
    {
        player.Draw();
        Raylib.DrawText($"HP: {player.Stats.HP}/{player.Stats.MaxHP}", 20, 20, 24, Color.Black);
        Raylib.DrawText("WASD/Setas: mover | I: inventário", 20, 52, 18, Color.DarkGray);
    }
}
