namespace apbd_cw1_git_s32959;

public class StatisticsHelper
{
    private List<int> _statistics;

    public StatisticsHelper()
    {
        _statistics = new List<int>();
    }

    public void AddStatistic(int statistic)
    {
        _statistics.Add(statistic);
    }

    public void ListStatistics()
    {
        foreach (int x in _statistics)
        {
            Console.Write(x + " ");
        }
    }
}