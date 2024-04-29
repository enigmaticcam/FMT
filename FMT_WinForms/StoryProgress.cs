namespace FMT_WinForms;
public class StoryProgress
{
    public StoryProgress()
    {
        Progress = (int)Properties.Settings.Default["StoryProgress"];
    }

    public int Progress { get; private set; }

    private void SetProgress()
    {
        int progress = 0;
        if (int.TryParse(Properties.Settings.Default["StoryProgress"], out progress))
        {

        }
    }

    public void SetProgressNext()
    {
        var next = Progress;
        next += 1;
        Properties.Settings.Default["StoryProgress"] = next;
        Properties.Settings.Default.Save();
        Progress = next;
    }

    public void Reset()
    {
        Properties.Settings.Default["StoryProgress"] = 1;
        Properties.Settings.Default.Save();
        Progress = 1;
    }
}
