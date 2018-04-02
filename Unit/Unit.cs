using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Unit
{
    class Unit
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int Rotation { get; set; }
        public double Power { get; set; }
        public void TurnRight()
        {
           Rotation -= 5;
        }
        public void TurnLeft()
        {
            Rotation += 5;
        }

        public void Move()
        {
            double r1 = Rotation * 180 / Math.PI;
            X = Math.Sin(r1) * Power + X;
            Y = Math.Cos(r1) * Power + Y;
        }

        public void Accelerator()
        {
            Power += 0.7;
        }


        public void Stop()
        {
            Power -= 0.9;
        }
        public void TurnToPoint(double x, double y)
        {
            double a = x - X;
            double b = y - Y;
            double c = Math.Sqrt(a * a + b * b);
            double sinac = Math.Atan(a / b) * 180 / Math.PI;

        }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y};";
        }

    }
}
