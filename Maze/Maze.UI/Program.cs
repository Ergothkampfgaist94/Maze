using Maze.Logic;

try
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.Yellow;
    var maze = new MyMaze(10, 10);
    Console.Write(maze);
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}