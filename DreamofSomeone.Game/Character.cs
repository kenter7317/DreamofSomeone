using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;

namespace DreamofSomeone.Game;

public partial class Character : CompositeDrawable
{
    private Container box;

    private ExsitedMap map;

    public Character()
    {
        AutoSizeAxes = Axes.Both;
        Origin = Anchor.Centre;
    }

    [BackgroundDependencyLoader]
    private void load(TextureStore textures)
    {
        InternalChild = new Container
        {
            AutoSizeAxes = Axes.Both,
            Origin = Anchor.Centre,
            Children = new Drawable[]
            {
                new Sprite
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Texture = textures.Get("character")
                },
            }
        };
    }

    protected override void LoadComplete()
    {
        base.LoadComplete();
    }
}

internal class ExsitedMap
{

}



