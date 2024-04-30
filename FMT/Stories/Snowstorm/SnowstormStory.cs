using FMT_Logic.Stories.Snowstorm.Chapters;
namespace FMT_Logic.Stories.Snowstorm;

public class SnowstormStory : Story
{
    public override string Title => "The Snowstorm - Alexander Pushkin";

    public override int StoryId => 0;

    public override List<Chapter> Chapters => new List<Chapter>()
    {
        new Chapter1(this),
        new Chapter2(this),
        new Chapter3(this),
        new Chapter4(this)
    };
}
