using RPG.Core;
using RPG.Scenes;
using Raylib_cs;

namespace RPG;

public sealed class Game
{
    private readonly SceneManager sceneManager;

    public Game()
    {
        sceneManager = new SceneManager();
        sceneManager.ChangeScene(new MainMenuScene(sceneManager));
    }

    public void Run()
    {
        while (!Raylib.WindowShouldClose())
        {
            float deltaTime = Raylib.GetFrameTime();
            sceneManager.Update(deltaTime);

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RayWhite);
            sceneManager.Draw();
            Raylib.EndDrawing();
        }
    }
}
