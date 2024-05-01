namespace FMT_Logic;

public interface IStoryProgress
{
    IEnumerable<int> Progress { get; }
    bool Contains(int id);
    void SetProgress(int id);
    void Reset();
}
