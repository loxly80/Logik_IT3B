using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Logik_IT3B
{
    public class Combination
    {
        public Pin[] Pins { get; set; }

        public Combination()
        {
            Pins = new Pin[] {
                new Pin(),
                new Pin(),
                new Pin(),
                new Pin()
            };
        }

        public void Draw(Graphics graphics, PointF location, int size)
        {
            for (int i = 0; i < Pins.Length; i++)
            {
                Pins[i].Draw(graphics, Pens.Black, new PointF(location.X + i * size * 1.25F, location.Y), size);
            }
        }
    }
}
