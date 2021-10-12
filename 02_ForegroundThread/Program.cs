//FOREGROUND THREAD EXAMPLE
Thread progress = new(Test_ForegroundThread.SimpleProgress);
progress.Start();
Console.WriteLine("Main Thread ends!");

public class Test_ForegroundThread
{
    public static void SimpleProgress()
    {
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("SimpleProgress in progress...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("SimpleProgress ends!");
    }
}