using System;
using Raylib_cs;

namespace TheKeyAndTheGate2
{
    public class Door
    {
        public bool isOpen = false;
        public float velocity = 5;

        public Rectangle rec = new Rectangle(0, 0, 50, 50);


        public Door(int xPos, int yPos)
        {
            rec.x = xPos;
            rec.y = yPos;

        }
        public bool CheckKeyCollision(Rectangle key)
        {
            if (Raylib.CheckCollisionRecs(rec, key))
            {
                isOpen = true;
                return true;
            }
            return false;
        }
        public void Update(Rectangle key)
        {
            CheckKeyCollision(key);
        }
        public void DrawRec()
        {
            if (!isOpen)
            {
                Raylib.DrawRectangleRec(rec, Color.RED);
                Raylib.DrawText("door;\nlocked", (int)rec.x, (int)rec.y, 16, Color.DARKPURPLE);
            }
            else
            {
                Raylib.DrawRectangleRec(rec, Color.GREEN);
                Raylib.DrawText("door;\nopen", (int)rec.x, (int)rec.y, 16, Color.DARKGREEN);
            }
        }
    }
}