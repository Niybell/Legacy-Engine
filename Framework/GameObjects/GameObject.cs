using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LegacyEngine.Basic;
using LegacyEngine.Graphics;

namespace LegacyEngine.GameObjects
{
    public class GameObject
    {
        public GameObject()
        {
            state = new State();
        }
        public State state;
        
        public virtual void Render(Render render) {}
    }
}