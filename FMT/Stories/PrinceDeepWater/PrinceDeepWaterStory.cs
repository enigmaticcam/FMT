using FMT_Logic.Stories.PrinceDeepWater.Chapters;

namespace FMT_Logic.Stories.PrinceDeepWater;

public class PrinceDeepWaterStory : Story
{
    public override string Title => "Prince Deep Water - Liu Cixin";

    public override int StoryId => 4;

    protected override List<Chapter> GetChapters()
    {
        return new List<Chapter>()
        {
            new Chapter1(this),
            new Chapter2(this),
            new Chapter3(this),
            new Chapter4(this)
        };
    }
}
