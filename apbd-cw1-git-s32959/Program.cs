using apbd_cw1_git_s32959;

StatisticsHelper test = new StatisticsHelper(new []{5, 1, 2, 10, 144, 3, 5, 2, 9});

test.ListStatisticsInOrder();
if (test.CalculateMax()!=144) Console.WriteLine("Max test failed");
if (test.CalculateMin()!=1) Console.WriteLine("Min test failed");
