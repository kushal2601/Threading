using static System.Console;
using System.Threading;
using System.Diagnostics;

static void Download(object? fileName){
    if (fileName == null)return;

    string bookName = (string) fileName;
    Console.WriteLine($"Downloading {bookName} ");
    Thread.Sleep(1000);
    Console.WriteLine($"{bookName} Downloaded");
}

var thread1 = new Thread(Download);
var thread2 = new Thread(Download);

var watch =  Stopwatch.StartNew();

thread1.Start("git scm book.pdf");
thread2.Start("C++ by Walter Savitch.pdf");

thread1.Join();
thread2.Join();

watch.Stop();

Console.WriteLine($"It took {watch.Elapsed.Seconds} seconds to finish the process ");
