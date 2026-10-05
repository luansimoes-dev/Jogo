using System.Numerics;
using Raylib_cs;

namespace RPG.Entities;

public sealed class NPC : Entity
{
    public NPC(Vector2 position, IEnumerable<string>? dialogueLines = null) : base(position)
    {
        DialogueLines = dialogueLines?.ToList() ?? new List<string>();
    }

    public List<string> DialogueLines { get; }

    public override void Update(float deltaTime)
    {
    }

    public override void Draw()
    {
        Raylib.DrawRectangleV(Position, new Vector2(32, 32), Color.Green);
    }
}
