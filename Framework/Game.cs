using LegacyEngine.GameObjects;
using LegacyEngine.Graphics;
using LegacyEngine.Logs;

namespace LegacyEngine;

public class Game
{
    public List<GameObject> Objects { get; set; }
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
        Objects = new List<GameObject>();
    }
    public void Start()
    {
        _logs.StartInit();
        _render.Start(Title, Width, Height);
        
        foreach (var obj in Objects)
        {
            obj.Render(_render);
        }

        _render.UpdateRender();
    }
}
