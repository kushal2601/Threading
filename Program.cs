using static System.Console;
using System.Threading;
using System.Diagnostics;

void Download(){
    Console.WriteLine("Download started");
    Thread.Sleep(1000);
    Console.WriteLine("Download finished");
}

var thread1 = new Thread(Download);
var thread2 = new Thread(Download);

var watch =  Stopwatch.StartNew();

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

watch.Stop();

Console.WriteLine($"It took {watch.Elapsed.Seconds} seconds to finish the process ");
