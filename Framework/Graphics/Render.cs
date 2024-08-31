using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using Framework.Logs;
namespace Framework.Graphics
{
    public class Render
    {
        private RenderWindow window;
        private Log _logs;
        public Render(bool isLogging)
        {
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
            
            while(window.IsOpen)
            {
                window.DispatchEvents();
                window.Display();
            }
        }
    }
}