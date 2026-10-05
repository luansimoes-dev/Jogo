namespace RPG.Core;

public sealed class SceneManager
{
    private Scene? currentScene;
    private Scene? nextScene;

    public void ChangeScene(Scene scene)
    {
        nextScene = scene;
    }

    public void Update(float deltaTime)
    {
        if (nextScene is not null)
        {
            currentScene?.OnExit();
            currentScene = nextScene;
            nextScene = null;
            currentScene.OnEnter();
        }

        currentScene?.Update(deltaTime);
    }

    public void Draw()
    {
        currentScene?.Draw();
    }
}
