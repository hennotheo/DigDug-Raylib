using System.Numerics;
using Raylib_cs;

namespace Pacman;

public class Game
{
    public const int TileSize = 20;
    
    private Player _player;
    private Maze _maze;

    public Game()
    {
        _maze =  new Maze(50,20);
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
        _maze.Draw();
        _player.Draw();
    }

    public void EndGame()
    {
        
    }
}