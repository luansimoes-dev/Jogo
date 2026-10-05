using Raylib_cs;

namespace RPG.Systems;

public sealed class DialogueSystem
{
    private readonly Queue<string> lines = new();

    public bool IsActive => lines.Count > 0;
    public string? CurrentLine => IsActive ? lines.Peek() : null;

    public void Start(IEnumerable<string> dialogueLines)
    {
        lines.Clear();
        foreach (var line in dialogueLines)
        {
            lines.Enqueue(line);
        }
    }

    public void Advance()
    {
        if (IsActive)
        {
            lines.Dequeue();
        }
    }

    public void Draw()
    {
        if (!IsActive || CurrentLine is null)
        {
            return;
        }

        Raylib.DrawRectangle(40, 560, 1200, 120, Raylib.Fade(Color.Black, 0.85f));
        Raylib.DrawText(CurrentLine, 70, 600, 24, Color.White);
    }
}
