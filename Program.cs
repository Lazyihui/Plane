using Raylib_cs;
using System.Numerics;

struct Ctx
{
    public int a;

}

public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("hello world");
        Raylib.InitWindow(800, 400, "plane");
        while(!Raylib.WindowShouldClose()){
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            
            Raylib.DrawCircle(200,200,20,Color.RED);

            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }


}
