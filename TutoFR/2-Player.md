# Pacman Raylib c#

## 2 - Ajouter un Joueur

Dans cette section, nous allons ajouter un joueur en créant une classe `Player` et en l'intégrant dans la classe `Game`. Cela permettra de gérer les déplacements et l'affichage du joueur.

---

### Étape 1 : Créer la classe `Player`

1. **Définir les propriétés** : Ajoutez des variables pour la position, la taille et la vitesse du joueur.
   ```csharp
   private Vector2 _position = Vector2.Zero;
   private Vector2 _size = Vector2.One * 20;
   private float _speed = 20f;
   ```

2. **Gérer les déplacements** : Implémentez une méthode `Update` pour déplacer le joueur avec les flèches directionnelles. Le joueur peut se déplacer horizontalement ou verticalement, mais pas en diagonale.
   ```csharp
   public void Update()
   {
       int xMove = AxisValue(KeyboardKey.Left, KeyboardKey.Right);
       int yMove = AxisValue(KeyboardKey.Up, KeyboardKey.Down);

       Vector2 rawInput = new Vector2(xMove, yMove);
       Vector2 filter = xMove != 0 ? new Vector2(1, 0) : new Vector2(0, 1);
       Vector2 filteredInput = rawInput * filter;

       _position += Raylib.GetFrameTime() * _speed * filteredInput;
   }
   ```

3. **Dessiner le joueur** : Ajoutez une méthode `Draw` pour afficher un rectangle représentant le joueur.
   ```csharp
   public void Draw()
   {
       Raylib.DrawRectangleV(_position, _size, Color.White);
   }
   ```

4. **Gérer les touches** : Ajoutez une méthode privée pour détecter les touches pressées.
   ```csharp
   private int AxisValue(KeyboardKey negative, KeyboardKey positive)
   {
       int value = 0;
       if (Raylib.IsKeyDown(positive))
           value += 1;
       if (Raylib.IsKeyDown(negative))
           value -= 1;

       return value;
   }
   ```

---

### Étape 2 : Intégrer `Player` dans la classe `Game`

1. **Ajouter une instance de `Player`** :
   ```csharp
   private Player _player = new Player();
   ```

2. **Mettre à jour le joueur** : Appelez `_player.Update()` dans la méthode `UpdateGame`.
   ```csharp
   public void UpdateGame()
   {
       _player.Update();
   }
   ```

3. **Dessiner le joueur** : Appelez `_player.Draw()` dans la méthode `RecordDrawing`.
   ```csharp
   public void RecordDrawing()
   {
       _player.Draw();
   }
   ```
