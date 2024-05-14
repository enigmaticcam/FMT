using FMT_Logic.Stories.NewRoyalPainter.Chapters;

namespace FMT_Logic.Stories.NewRoyalPainter;

public class NewRoyalPainterStory : Story
{
    public override string Title => "The New Royal Painter - Liu Cixin";

    public override int StoryId => 2;

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
