using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LegacyEngine.Logs;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace LegacyEngine.Graphics
{
    public class Render
    {
        private RenderWindow window;
        private Log _logs;
        private List<Drawable> _drawable;
        public Render(bool isLogging)
        {
            _drawable = new List<Drawable>();
            _logs = new Log(isLogging);
        }
        public void Start(string title, int width, int height)
        {
            _logs.StartRender();
            window = new RenderWindow(new VideoMode((uint)width, (uint)height), title);
            _logs.EndRender();

            window.Closed += (obj,e) => {
                window.Close();
                _logs.CloseProgram();
            };
            window.Resized += (obj,e) => window.SetView(new View(new FloatRect(0,0,e.Width,e.Height)));
        }
        public Font GetFont(string pathToFont) => new Font(pathToFont);
        public void RenderText(Font font, string text, Color color, int characterSize, Vector2f position)
        {
            Text renderText = new Text(text, font);

            renderText.FillColor = color;
            renderText.CharacterSize = (uint)characterSize;
            renderText.Position = position;

            _drawable.Add(renderText);
        }
        public void UpdateRender()
        {
            while(window.IsOpen)
            {
                foreach(var item in _drawable)
                {
                    window.Draw(item);
                }
                window.DispatchEvents();
                window.Display();
            }
        }
    }
}