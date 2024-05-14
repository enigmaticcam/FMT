using FMT_Logic.Stories.GluttonsSea.Chapters;

namespace FMT_Logic.Stories.GluttonsSea;

public class GluttonsSeaStory : Story
{
    public override string Title => "The Glutton's Sea - Liu Cixin";

    public override int StoryId => 3;

    protected override List<Chapter> GetChapters()
    {
        return new List<Chapter>()
        {
            new Chapter1(this),
            new Chapter2(this),
            new Chapter3(this)
        };
    }
}
