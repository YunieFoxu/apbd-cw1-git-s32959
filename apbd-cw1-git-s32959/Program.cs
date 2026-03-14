using apbd_cw1_git_s32959;

class Program
{
    static void Main()
    {
        StatisticsHelper statisticsHelper = new StatisticsHelper();
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            statisticsHelper.AddStatistic(random.Next()%101);
        }
    
        statisticsHelper.ListStatistics();
        Console.WriteLine();
        statisticsHelper.ListStatisticsInOrder();
    }    
}
