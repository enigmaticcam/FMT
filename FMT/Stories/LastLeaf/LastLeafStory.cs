using FMT_Logic.Stories.LastLeaf.Chapters;

namespace FMT_Logic.Stories.LastLeaf;

public class LastLeafStory : Story
{
    public override string Title => "The Last Leaf - O' Henry";

    public override int StoryId => 1;

    public override List<Chapter> Chapters => new List<Chapter>()
    {
        new Chapter1(this),
        new Chapter2(this)
    };
}
