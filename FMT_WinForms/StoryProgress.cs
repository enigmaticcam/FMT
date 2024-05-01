using FMT_Logic;

namespace FMT_WinForms;

public class StoryProgress : IStoryProgress
{
    public StoryProgress()
    {
        try
        {
            var text = (string)Properties.Settings.Default["StoryProgress"];
            var list = text.Split(',')
                .Select(x => Convert.ToInt32(x))
                .ToHashSet();
            _progress = list;
        } 
        catch
        {
            _progress = new HashSet<int>();
        }
        
    }

    private HashSet<int> _progress;
    public IEnumerable<int> Progress => _progress;

    public bool Contains(int id) => _progress.Contains(id);

    public void SetProgress(int id)
    {
        _progress.Add(id);
        Properties.Settings.Default["StoryProgress"] = string.Join(",", _progress);
        Properties.Settings.Default.Save();
    }

    public void Reset()
    {
        Properties.Settings.Default["StoryProgress"] = "";
        Properties.Settings.Default.Save();
        _progress.Clear();
    }
}
