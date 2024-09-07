using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LegacyEngine.GameObjects;
using LegacyEngine.Graphics;
using SFML.Graphics;
using SFML.System;

namespace LegacyEngine.UI
{
    public class TextObject : GameObject
    {
        public TextObject(string pathToFont, string text)
        {
            Font = new Font(pathToFont);
            Text = text;
        }
        public TextObject(string pathToFont, string text, Color color, int characterSize)
        {
            Font = new Font(pathToFont);
            Text = text;
            Color = color;
            CharacterSize = characterSize;
        }
        public Font Font { get; set; }
        public string Text { get; set; }
        public Color Color { get; set; } = Color.White;
        public int CharacterSize { get; set; } = 10;
        override public void Render(Render render)
        {
            render.RenderText(Font, Text, Color, CharacterSize, new Vector2f(state.Position.X, state.Position.Y));
        }
    }
}