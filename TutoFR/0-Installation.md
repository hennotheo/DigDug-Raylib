# Pacman Raylib c#

## 0 - Installation

### Prérequis

- [Dotnet](https://dotnet.microsoft.com/fr-fr/download)
- Un IDE 
  - [Rider](https://www.jetbrains.com/fr-fr/rider/)
  - [VS Code](https://code.visualstudio.com/)
  - [Visual Studio](https://visualstudio.microsoft.com/fr/)

### Créer un projet

#### Via le CLI

Créer un Dossier, puis ouvrir un terminal de commande dedans.

**Créer la solution :**
``` Bash
dotnet new sln --name Pacman
```

**Créer le projet :**

Créer un projet console
``` Bash
dotnet new console --output Pacman
```

Ajouter le projet à la solution
``` Bash
dotnet sln add Pacman
```

Ajouter Raylib au projet
``` Bash
dotnet add Pacman package Raylib-cs
```

#### Via Rider ou Visual Studio

Créer une solution avec un projet console.

Installer le package Raylib-cs via Nuget.