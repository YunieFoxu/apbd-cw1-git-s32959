namespace apbd_cw1_git_s32959;

public class StatisticsHelper
{
    private List<int> statistics;

    public StatisticsHelper()
    {
        statistics = new List<int>();
    }

    public void addStatistic(int statisctic)
    {
        statistics.Add(statisctic);
    }

    public void listStatistics()
    {
        foreach (int x in statistics)
        {
            Console.Write(x);
        }
    }
}