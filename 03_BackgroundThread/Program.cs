//BACKGROUND THREAD EXAMPLE
Thread progress = new(Test_BackgroundThread.SimpleProgress);

progress.Name = "TestThread";

progress.Start();

//allow thread to run in the background
progress.IsBackground = true;

Console.WriteLine("Main Thread ends!");

public class Test_BackgroundThread
{
    public static void SimpleProgress()
    {
        //current thread name
        Console.WriteLine("In Progress Thread is: {0}", Thread.CurrentThread.Name);

        Thread.Sleep(3000);

        //completed thread name
        Console.WriteLine("Completed Thread is: {0}", Thread.CurrentThread.Name);
    }
}