using System.Collections.Generic;
using System.Collections;
using System.Numerics;
using Raylib_cs;

namespace Pacman;

public enum Tile
{
    Path,
    Wall
}

public class Maze
{
    private int _width;
    private int _height;
    private Tile[] _maze;

    public Maze(int width, int height)
    {
        _maze = new Tile[width * height];
        _width = width;
        _height = height;

        //Test
        for (int x = 0; x < width; x++)
        {
            if (x != 0 || x != width - 1)
                continue;
            
            for (int y = 0; y < height; y++)
            {
                if (y != 0 || y != width - 1)
                    continue;
                
                _maze[x + y * width] = Tile.Wall;
            }
        }
    }

    public void Draw()
    {
        for (int i = 0; i < _maze.Length; i++)
        {
            int x = i % _width;
            int y = i / _width;
            Color color = _maze[x + y * _width] == Tile.Wall ? Color.Red : Color.Green;
            Vector2 pos =  new Vector2(x, y) * Game.TileSize;
            Vector2 size =  new Vector2(1, 1) * Game.TileSize;
            Raylib.DrawRectangleV(pos, size, color);
        }
    }
}