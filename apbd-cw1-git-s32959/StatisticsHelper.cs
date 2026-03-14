namespace apbd_cw1_git_s32959;

public class StatisticsHelper
{
    private List<int> _statistics;

    public StatisticsHelper()
    {
        _statistics = new List<int>();
    }

    public void AddStatistic(int statisctic)
    {
        _statistics.Add(statisctic);
    }

    public void ListStatistics()
    {
        foreach (int x in _statistics)
        {
            Console.Write(x + " ");
        }
    }

    public void ListStatisticsInOrder()
    {
        List<int> tmpList = new List<int>(_statistics);
        tmpList.Sort();
        foreach (int x in tmpList)
        {
            Console.Write(x + " ");
        }
    }
}