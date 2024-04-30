using osu.Framework.Allocation;
using osu.Framework.Platform;
using NUnit.Framework;

namespace DreamofSomeone.Game.Tests.Visual
{
    [TestFixture]
    public partial class TestSceneDreamofSomeoneGame : DreamofSomeoneTestScene
    {
        // Add visual tests to ensure correct behaviour of your game: https://github.com/ppy/osu-framework/wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        private DreamofSomeoneGame game;

        [BackgroundDependencyLoader]
        private void load(GameHost host)
        {
            game = new DreamofSomeoneGame();
            game.SetHost(host);

            AddGame(game);
        }
    }
}
