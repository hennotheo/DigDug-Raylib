# DigDug Raylib c#

## 1 - Game Loop

### Créer la window 

Aller dans Program.cs, puis écrire cette ligne :

``` csharp
Raylib.InitWindow(840,480, "Dig Dug");
```

On créer ici une Window de 840 de large et 480 de haut ayant comme nom "Dig Dug".

Vous pouvez ajouter cette ligne afin de fixer les fps à 60
``` csharp
Raylib.SetTargetFPS(60);
```

N'oubliez pas à la fin de votre programe de liberer les ressources de la window.
``` csharp
Raylib.CloseWindow();
```

### Créer la game loop

Si vous tester maintenant, vous ne verrez pas la window. Il faut donc la maintenir ouverte jusqu'a ce que l'utilisateur veuille la fermer.
Pour le faire, on peut ajouter ce bout de code suivant : 
``` csharp
//INITIALISATION

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.EndDrawing();
}

//Fin de la window
```

### Dessiner un carré

Pour dessiner un carré dans Raylib, utilisez la fonction `Raylib.DrawRectangle` entre `BeginDrawing` et `EndDrawing` :

```csharp
while (!Raylib.WindowShouldClose())
{
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.Black);

  Raylib.DrawRectangle(0, 0, 50, 50, Color.White);

  Raylib.EndDrawing();
}
```
Ce code dessine un carré blanc de 50x50 pixels à la position (0, 0) sur un fond noir.

### Ajouter une class Game pour simplifier l'utilisation

Ajouter une classe `Game` permet de structurer et simplifier le code en regroupant toute la logique du jeu dans une seule entité. Cela rend le code plus lisible, modulaire et facile à maintenir. Voici une explication des différentes parties :

1. **Création de l'objet `Game`** :
   ```csharp
   Game game = new Game();
   ```
   Cela initialise une instance de la classe `Game`, qui contiendra toutes les données et méthodes nécessaires pour gérer le jeu.

2. **Démarrage du jeu** :
   ```csharp
   game.StartGame();
   ```
   Cette méthode est appelée pour initialiser les ressources ou paramètres nécessaires avant que la boucle principale ne commence.

3. **Boucle principale** :
   ```csharp
   while (!Raylib.WindowShouldClose())
   {
       game.UpdateGame();
       Raylib.BeginDrawing();
       Raylib.ClearBackground(Color.Black);
       game.RecordDrawing();
       Raylib.EndDrawing();
   }
   ```
   - La boucle vérifie si la fenêtre doit se fermer.
   - `game.UpdateGame()` met à jour la logique du jeu (par exemple, les déplacements, les collisions, etc.).
   - Les méthodes de Raylib (`BeginDrawing`, `ClearBackground`, etc.) gèrent l'affichage, tandis que `game.RecordDrawing()` dessine les éléments spécifiques au jeu.

4. **Fin du jeu** :
   ```csharp
   game.EndGame();
   Raylib.CloseWindow();
   ```
   Ces méthodes libèrent les ressources utilisées et ferment proprement la fenêtre.

En résumé, la classe `Game` encapsule la logique et les données du jeu, ce qui rend le code plus organisé et plus facile à étendre.