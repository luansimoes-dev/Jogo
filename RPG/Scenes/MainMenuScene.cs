using RPG.Core;
using Raylib_cs;

namespace RPG.Scenes;

public sealed class MainMenuScene : Scene
{
    public MainMenuScene(SceneManager sceneManager) : base(sceneManager)
    {
    }

    public override void Update(float deltaTime)
    {
        if (InputManager.IsConfirmPressed())
        {
            SceneManager.ChangeScene(new WorldScene(SceneManager));
        }
    }

    public override void Draw()
    {
        const string title = "MEU RPG";
        const string prompt = "Pressione ENTER";
        int titleX = (1280 - Raylib.MeasureText(title, 64)) / 2;
        int promptX = (1280 - Raylib.MeasureText(prompt, 28)) / 2;
        Raylib.DrawText(title, titleX, 250, 64, Color.DarkBlue);
        Raylib.DrawText(prompt, promptX, 340, 28, Color.DarkGray);
    }
}
