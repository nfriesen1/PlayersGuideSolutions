# The C# Player's Guide: My Solutions

My solutions to challenges from [*The C# Player's Guide*](https://csharpplayersguide.com/) (5th edition) by RB Whitaker. I worked through the book to build a solid foundation in C# and object-oriented design. Each folder is a standalone .NET console app.

## Challenges

| Project | What it is | Concepts practiced |
|---|---|---|
| [Hunting the Manticore](HuntingTheManticore%20-%20Level%2014) | A two-player artillery game: one player hides the Manticore and the other aims a cannon whose damage changes from round to round | Loops, methods, game state |
| [Enumeration Basics](Chapter%2016%20-%20Enumeration%20Basics) | A chest you can lock, unlock, open and close, which refuses moves that don't make sense | Enums, state machines |
| [Tuples](Level%2017%20-%20Tuples) | Simula's Soup Shop: build a soup from a type, an ingredient and a seasoning | Named tuples |
| [Classes](Level%2018%20-%20Classes) | Vin Fletcher's Arrows: build a custom or standard arrow and get its price | Classes, enums, encapsulation |
| [The Locked Door](Chapter%2024%20-%20The%20Locked%20Door) | A door that has a password and can be opened, closed, locked, unlocked and have its password reset | Properties, state transitions |
| [The Point, Color, Card and Door](Ch.24%20Boss%20Battle%201%20-%20The%20Point) | A set of small model classes with constructors and static presets | Constructors, static members, `ToString` |
| [Password Validator](Password%20Validator) | Checks a password against several rules (length, character mix, banned characters) | Single-responsibility classes, string handling |
| [Rock Paper Scissors](RockPaperScissors) | A two-player game that keeps score across rounds | Object-oriented design, separate `Game` and `Player` classes |
| [15-Puzzle](15-Puzzle) | The classic sliding-tile puzzle with a board size you choose | Object-oriented design, 2D arrays, game loop |

## Running a solution

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (the projects target .NET 6 and .NET 8).

```bash
cd "15-Puzzle"
dotnet run
```

For folders that contain a `.sln`, run the project inside, for example:

```bash
dotnet run --project "RockPaperScissors/RockPaperScissors"
```
