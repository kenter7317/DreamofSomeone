using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Cursor;
using osu.Framework.Graphics.UserInterface;

using osu.Framework.Screens;

namespace DreamofSomeone.Game
{
    public partial class StartScreen : Screen
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            AddInternal(new BasicContextMenuContainer()
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.TopCentre,
                    Children = new Drawable[]
                    {
                        new BasicMenu.BasicDrawableMenuItem(
                            new MenuItem("게임 시작", Start_Game))
                    }
                }
            );

        }

        private void Start_Game()
        {
            throw new System.NotImplementedException();
        }
    }
}
