using osu.Framework.Platform;
using osu.Framework;
using DreamofSomeone.Game;

namespace DreamofSomeone.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost(@"DreamofSomeone"))
            using (osu.Framework.Game game = new DreamofSomeoneGame())
                host.Run(game);
        }
    }
}
