namespace FMT_WinForms;
public class StoryProgress
{
    public StoryProgress()
    {
        try
        {
            Progress = (int)Properties.Settings.Default["StoryProgress"];
        } 
        catch
        {
            Progress = 0;
        }
        
    }

    public int Progress { get; private set; }

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
        Properties.Settings.Default["StoryProgress"] = 0;
        Properties.Settings.Default.Save();
        Progress = 0;
    }
}
