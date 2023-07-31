using static System.Console;
using System.Threading;
using System.Diagnostics;

static void Download(string fileName){
    string bookName = (string) fileName;
    Console.WriteLine($"Downloading {bookName} ");
    Thread.Sleep(1000);
    Console.WriteLine($"{bookName} Downloaded");
}

var thread1 = new Thread(()=>{
    Download("git scm book.pdf");
});
var thread2 = new Thread(()=>{
    Download("C++ by Walter Savitch.pdf");
});

var watch =  Stopwatch.StartNew();

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

watch.Stop();

Console.WriteLine($"It took {watch.Elapsed.Seconds} seconds to finish the process ");
