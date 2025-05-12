using Pacman;
using Raylib_cs;

Raylib.InitWindow(840,480, "Pacman");
Raylib.SetTargetFPS(60);

Game game = new Game();
game.StartGame();

while (!Raylib.WindowShouldClose())
{
    game.UpdateGame();
    
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Black);
    
    game.RecordDrawing();
    
    Raylib.EndDrawing();
}

game.EndGame();
Raylib.CloseWindow();