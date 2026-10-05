using Raylib_cs;

namespace RPG;

public static class Program
{
    public static void Main()
    {
        Raylib.InitWindow(1280, 720, "Meu RPG");
        Raylib.SetTargetFPS(60);
        Raylib.InitAudioDevice();

        var game = new Game();
        game.Run();

        Raylib.CloseAudioDevice();
        Raylib.CloseWindow();
    }
}
