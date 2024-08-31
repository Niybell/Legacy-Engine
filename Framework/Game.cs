using Framework.Graphics;
using Framework.Logs;

namespace LegacyEngine;

public class Game
{
    public string Title { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    private Render _render;
    private Log _logs;

    public Game(string title, int width, int height, bool isLogging = false)
    {
        Title = title;    
        _logs = new Log(isLogging);
        _render = new Render(isLogging);
        Width = width;
        Height = height;
    }
    public void Start()
    {
        _logs.StartInit();
        _render.Start(Title, Width, Height);
    }
}
