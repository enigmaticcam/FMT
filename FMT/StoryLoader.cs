using System.Text.Json;

namespace FMT_Logic;

public class StoryLoader
{
    public StorySave Load(string file)
    {
        var fileContent = File.ReadAllText(file);
        var result = JsonSerializer.Deserialize<StorySave>(fileContent);
        return result;
    }

    public void Save(StorySave stories, string file)
    {
        var result = JsonSerializer.Serialize<StorySave>(stories);
        File.WriteAllText(file, result);
    }
}
