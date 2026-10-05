using System.Numerics;
using Raylib_cs;

namespace RPG.Core;

public static class InputManager
{
    public static Vector2 GetMovementVector()
    {
        var movement = Vector2.Zero;
        if (Raylib.IsKeyDown(KeyboardKey.W) || Raylib.IsKeyDown(KeyboardKey.Up)) movement.Y -= 1;
        if (Raylib.IsKeyDown(KeyboardKey.S) || Raylib.IsKeyDown(KeyboardKey.Down)) movement.Y += 1;
        if (Raylib.IsKeyDown(KeyboardKey.A) || Raylib.IsKeyDown(KeyboardKey.Left)) movement.X -= 1;
        if (Raylib.IsKeyDown(KeyboardKey.D) || Raylib.IsKeyDown(KeyboardKey.Right)) movement.X += 1;

        return movement == Vector2.Zero ? movement : Vector2.Normalize(movement);
    }

    public static bool IsConfirmPressed() => Raylib.IsKeyPressed(KeyboardKey.Enter) || Raylib.IsKeyPressed(KeyboardKey.Space);

    public static bool IsCancelPressed() => Raylib.IsKeyPressed(KeyboardKey.Escape);

    public static bool IsInventoryPressed() => Raylib.IsKeyPressed(KeyboardKey.I);
}
