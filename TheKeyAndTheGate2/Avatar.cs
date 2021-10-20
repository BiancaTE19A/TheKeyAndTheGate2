using System;
using Raylib_cs;



namespace TheKeyAndTheGate2
{
    public class Avatar
    {
        public bool youWin = false;
        public float velocity = 5;

        public Rectangle rec = new Rectangle(375, 275, 50, 50);
        public Key CarriedKey { get; set; }


        public void Update()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A) || Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && rec.x > 0)
            {
                rec.x -= velocity;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D) || Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && rec.x < 750)
            {
                rec.x += velocity;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_W) || Raylib.IsKeyDown(KeyboardKey.KEY_UP) && rec.y > 0)
            {
                rec.y -= velocity;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S) || Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && rec.y < 550)
            {
                rec.y += velocity;
            }

            if (CarriedKey != null)
            {
                CarriedKey.Update(rec);
            }
        }
        public void CheckKeyCollision(Key key)
        {
            if (Raylib.CheckCollisionRecs(rec, key.rec))
            {
                CarriedKey = key;
            }
        }
        public void CheckDoorCollision(Door door)
        {
            if (door.isOpen && Raylib.CheckCollisionRecs(rec, door.rec))
            {
                youWin = true;
            }
        }
        public void DrawRec()
        {
            if (!youWin)
            {
                Raylib.DrawRectangleRec(rec, Color.PINK);
                Raylib.DrawText("player", (int)rec.x + 2, (int)rec.y + 15, 16, Color.VIOLET);
            }
        }
    }
}