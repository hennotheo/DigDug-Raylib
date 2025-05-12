using System.Numerics;
using Raylib_cs;

namespace DigDug;

public class Game
{
    private Player _player;

    public Game()
    {
        _player = new Player();
    }

    public void StartGame()
    {
        
    }

    public void UpdateGame()
    {
        _player.Update();
    }

    public void RecordDrawing()
    {
        _player.Draw();
    }

    public void EndGame()
    {
        
    }
}