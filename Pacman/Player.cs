using System.Numerics;
using Raylib_cs;

namespace Pacman;

public class Player
{
    private Vector2 _position = Vector2.Zero;
    private Vector2 _size = Vector2.One * 20;
    private float _speed = 20f;

    public void Update()
    {
        int xMove = AxisValue(KeyboardKey.Left, KeyboardKey.Right);
        int yMove = AxisValue(KeyboardKey.Up, KeyboardKey.Down);

        Vector2 rawInput = new Vector2(xMove, yMove);

        Vector2 filter = xMove != 0 ? new Vector2(1, 0) : new Vector2(0, 1);
        Vector2 filteredInput = rawInput * filter;

        _position += Raylib.GetFrameTime() * _speed * filteredInput;
    }

    public void Draw()
    {
        Raylib.DrawRectangleV(_position, _size, Color.White);
    }

    private int AxisValue(KeyboardKey negative, KeyboardKey positive)
    {
        int value = 0;
        if (Raylib.IsKeyDown(positive))
            value += 1;
        if (Raylib.IsKeyDown(negative))
            value -= 1;

        return value;
    }
}