using System;
using Raylib_cs;
using System.Numerics;


namespace TheKeyAndTheGate2
{
    public class Key
    {
        public float velocity = 5;

        public Rectangle rec = new Rectangle(575, 475, 50, 50);

        Door targetDoor;


        public Key(Door target)
        {
            targetDoor = target;
        }
        public void Update(Rectangle rect)
        {
            rec.x = rect.x + 50;
            rec.y = rect.y + 50;
            targetDoor.CheckKeyCollision(rec);
        }
        public void DrawRec()
        {
            if (!targetDoor.isOpen)
            {
                Raylib.DrawRectangleRec(rec, Color.GOLD);
                Raylib.DrawText("key", (int)rec.x + 10, (int)rec.y + 15, 18, Color.BROWN);
            }
        }
    }
}