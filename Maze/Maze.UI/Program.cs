using Maze.Logic;

try
 {
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.Yellow;
    var maze = new MyMaze(10, 20);
    var path = maze.Wanderer();
    Console.Write(maze);
    Console.Write(path);
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}