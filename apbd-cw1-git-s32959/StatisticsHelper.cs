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
        if (statisctic>0)
            _statistics.Add(statisctic);
        else
            Console.Write("Statistic has to be greater than 0");
    }

    public double GetAverage()
    {
        return _statistics.Average();
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