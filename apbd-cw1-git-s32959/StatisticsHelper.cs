namespace apbd_cw1_git_s32959;

public class StatisticsHelper
{
    private List<int> _statistics;

    public StatisticsHelper()
    {
        _statistics = new List<int>();
    }

    public StatisticsHelper(int[] arr)
    {
        _statistics = new List<int>(arr);
    }

    public void AddStatistic(int statistic)
    {
        _statistics.Add(statistic);
    }

    public double CalculateAverage()
    {
        return _statistics.Average();
    }

    public int CalculateMax()
    {
        return _statistics.Max();
    }

    public int CalculateMin()
    {
        return _statistics.Min();
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
        List<int> tmp = new List<int>(_statistics);
        tmp.Sort();
        foreach (int x in tmp)
        {
            Console.Write(x + " ");
        }
    }
}