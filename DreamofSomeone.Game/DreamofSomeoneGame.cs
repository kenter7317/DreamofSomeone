using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.IO.Stores;
using osu.Framework.Screens;

namespace DreamofSomeone.Game
{
    public partial class DreamofSomeoneGame : DreamofSomeoneGameBase
    {
        private ScreenStack screenStack;

        [BackgroundDependencyLoader]
        private void load()
        {
            // Add your top-level game components here.
            // A screen stack and sample screen has been provided for convenience, but you can replace it if you don't want to use screens.
            Child = screenStack = new ScreenStack { RelativeSizeAxes = Axes.Both };
            Resources.AddStore(new DllResourceStore(@"DreamofSomeone.dll"));
            AddFont(Resources, @"Fonts/_210omnigulim010/210omnigulim010");
        }

        protected override void LoadComplete()
        {
            base.LoadComplete();
            screenStack.Push(new StartScreen());
        }
    }
}
