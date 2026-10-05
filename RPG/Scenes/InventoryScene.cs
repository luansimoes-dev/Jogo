using RPG.Core;
using RPG.Entities;
using Raylib_cs;

namespace RPG.Scenes;

public sealed class InventoryScene : Scene
{
    private readonly Player player;

    public InventoryScene(SceneManager sceneManager, Player player) : base(sceneManager)
    {
        this.player = player;
    }

    public override void Update(float deltaTime)
    {
        if (InputManager.IsCancelPressed())
        {
            SceneManager.ChangeScene(new WorldScene(SceneManager));
        }
    }

    public override void Draw()
    {
        Raylib.DrawRectangle(180, 100, 920, 520, Raylib.Fade(Color.DarkBlue, 0.9f));
        Raylib.DrawText("INVENTÁRIO", 230, 140, 40, Color.White);

        if (player.Inventory.Items.Count == 0)
        {
            Raylib.DrawText("Inventário vazio", 230, 220, 24, Color.LightGray);
        }
        else
        {
            for (int index = 0; index < player.Inventory.Items.Count; index++)
            {
                var item = player.Inventory.Items[index];
                Raylib.DrawText($"{index + 1}. {item.Name}", 230, 210 + index * 34, 22, Color.White);
            }
        }

        Raylib.DrawText("ESC: voltar", 230, 570, 20, Color.LightGray);
    }
}
