namespace FMT_WinForms;
public class StoryProgress
{
    public StoryProgress()
    {
        Progress = (decimal)Properties.Settings.Default["StoryProgress"];
    }

    public decimal Progress { get; private set; }

    public void SetProgressNext()
    {
        var next = Progress;
        next += 0.1M;
        Properties.Settings.Default["StoryProgress"] = next;
        Properties.Settings.Default.Save();
        Progress = next;
    }

    public void Reset()
    {
        Properties.Settings.Default["StoryProgress"] = 1M;
        Properties.Settings.Default.Save();
        Progress = 1;
    }
}
