using apbd_cw1_git_s32959;

class Program
{
    static void Main()
    {
        StatisticsHelper statisticsHelper = new StatisticsHelper();

        for (int i = 0; i < 10; i++)
        {
            statisticsHelper.addStatistic(i);
        }
    
        statisticsHelper.listStatistics();
    }    
}
