using System.Numerics;
public class Ctx
{
    public int WindowWidth;
    public int WindowHeight;
    Vector2 pos;
    public static void CtxInit(ref Ctx ctx)
    {
        ctx.WindowHeight = 400;
        ctx.WindowWidth = 800;
    }

    public void A()
    {
        this.WindowWidth = 800;
        this.WindowHeight = 400;
    }
}


