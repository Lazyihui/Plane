using Raylib_cs;
using System.Numerics;

public class Mathematic
{

    public static int Add(int a, int b)
    {
        return a+b;
    }
}

// heap 堆
public class MyClass {
    public int a;
}

// 看情况
public struct MyStruct {
    public int b;
}

public class Program
{

    public static void ChangeStruct(ref MyStruct ptr) {
        ptr.b = 5;
    }

    public static void ChangeClass(MyClass ptr) {
        ptr.a = 5;
    }

    public static void Main()
    {   //0
        Ctx ctx = new Ctx();
        // static
        Ctx.CtxInit(ref ctx);
        //!static
        ctx.A();

        MyStruct myStruct = new MyStruct();
        myStruct.b = 1;
        ChangeStruct(ref myStruct);

        MyClass myClass = new MyClass();
        myClass.a = 1;
        ChangeClass(myClass);

        System.Console.WriteLine("hello world");
        Raylib.InitWindow(ctx.WindowWidth, ctx.WindowHeight, "plane");
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            Raylib.DrawCircle(200, 200, 20, Color.RED);

            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }


}
