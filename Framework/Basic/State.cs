using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegacyEngine.Basic
{
    public class State
    {
        public Vector2D Position { get; set; }
        public Vector2D Rotation { get; set; }
        public Vector2D Scale { get; set; }
        public State(Vector2D position, Vector2D rotation, Vector2D scale)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }
        public State()
        {
            Position = new Vector2D();
            Rotation = new Vector2D();
            Scale = new Vector2D();
        }
    }
}