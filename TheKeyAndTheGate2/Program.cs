using System;
using Raylib_cs;
using System.Numerics;

namespace TheKeyAndTheGate2
{
    class Program
    {
        static void Main(string[] args)
        {
            int screenWidth = 800;
            int screenHeight = 600;

            Door door = new Door(175, 175);
            Key key = new Key(door);
            Avatar player = new Avatar();

            Raylib.SetTargetFPS(60);
            Raylib.InitWindow(screenWidth, screenHeight, "The Key and The Gate");

            while (!Raylib.WindowShouldClose())
            {
                player.Update();
                player.CheckKeyCollision(key);
                player.CheckDoorCollision(door);

                DrawRaylib();
                door.DrawRec();
                key.DrawRec();
                player.DrawRec();
                Raylib.DrawText("Get the key and unlock the gate.", 10, 10, 32, Color.WHITE);

                DrawWinScreen(player);

            }
            static void DrawWinScreen(Avatar p)
            {
                if (p.youWin)
                {
                    Raylib.DrawText(@$"
YOU MANAGED TO 
ENTER THE DOOR, 
YOU WON!!!", 30, 140, 64, Color.WHITE);
                }
            }
            static void DrawRaylib()
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                Raylib.EndDrawing();
            }
        }
    }
}
