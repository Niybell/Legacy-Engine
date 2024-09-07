using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegacyEngine.Basic
{
    public class Vector2D
    {
        public float X { get; set; } = 0;
        public float Y { get; set; } = 0;
        public Vector2D(float x, float y)
        {
            X = x;
            Y = y;
        }
        public Vector2D()
        {
            
        }
    }
}