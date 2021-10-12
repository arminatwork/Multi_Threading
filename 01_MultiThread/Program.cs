
//RUN IN SINGLE THREAD
Test_Thread.FirstProgress();
Test_Thread.SecondProgress();

//RUN IN MULTIPLE THREAD
Thread firstProgress = new(Test_Thread.FirstProgress);
Thread secondProgress = new(Test_Thread.SecondProgress);

firstProgress.Start();
secondProgress.Start();

public class Test_Thread
{
    public static void FirstProgress()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Method 1 is {0}", i);

            if (i is 5)
                Thread.Sleep(2000);
        }
    }

    public static void SecondProgress()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Method 2 is {0}", i);

            if (i is 5)
                Thread.Sleep(2000);
        }
    }
}