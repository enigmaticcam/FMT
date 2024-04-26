using FMT_Logic.Stories.Snowstorm.Chapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMT_Logic.Stories.Snowstorm;

public class SnowstormStory : Story
{
    public override string Title => "The Snowstorm - Alexander Pushkin";

    public override int StoryId => 1;

    public override List<Chapter> Chapters => new List<Chapter>()
    {
        new Chapter1()
    };
}
