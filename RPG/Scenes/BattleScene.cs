using RPG.Core;
using RPG.Entities;
using Raylib_cs;

namespace RPG.Scenes;

public sealed class BattleScene : Scene
{
    private readonly Player player;
    private readonly Enemy enemy;

    public BattleScene(SceneManager sceneManager, Player player, Enemy enemy) : base(sceneManager)
    {
        this.player = player;
        this.enemy = enemy;
    }

    public override void Update(float deltaTime)
    {
        if (InputManager.IsCancelPressed())
        {
            SceneManager.ChangeScene(new WorldScene(SceneManager));
        }

        // TODO: implementar turnos e ações de combate.
    }

    public override void Draw()
    {
        Raylib.DrawRectangle(0, 0, 1280, 720, Color.DarkGray);
        Raylib.DrawText("BATALHA", 500, 100, 48, Color.White);
        Raylib.DrawText($"{player.Stats.HP}/{player.Stats.MaxHP} HP", 200, 300, 24, Color.White);
        Raylib.DrawText($"{enemy.Name}: {enemy.Stats.HP}/{enemy.Stats.MaxHP} HP", 800, 300, 24, Color.White);
        Raylib.DrawText("ESC: voltar", 20, 680, 20, Color.LightGray);
    }
}
