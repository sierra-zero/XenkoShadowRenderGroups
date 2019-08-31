using Xenko.Engine;

namespace ShadowRenderGroups.Windows
{
    class ShadowRenderGroupsApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
