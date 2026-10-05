namespace RPG.Core;

public abstract class Scene
{
    protected Scene(SceneManager sceneManager)
    {
        SceneManager = sceneManager;
    }

    protected SceneManager SceneManager { get; }

    public virtual void OnEnter()
    {
    }

    public virtual void OnExit()
    {
    }

    public abstract void Update(float deltaTime);

    public abstract void Draw();
}
