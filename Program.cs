using static System.Console;
using System.Threading;
using System.Diagnostics;

/*
--------------------------------THREAD POOL-------------------------------------------------------------
Even though we are allowed to create as many threads as we want , we should be aware of the after-affects
of it .
The threads that are created by us are called user-threads ,which has to manages by the developer at the
application level itself or else it will increse the load on the core which in turn reduces the performance

Hence , management of threads is really important which is done efficiently by the ThreadPool class
provided the .NET framwork.

NOTE : All the tasks that are queued to the Thread Pool will be assigned to some threads called 
worker threads and all worker threads are backgournd threads.
*/
static void Download(string bookName)
{
    Console.WriteLine($"Downloading: {bookName}");
    Thread.Sleep(1000);
    Console.WriteLine($"Downloaded : {bookName}");
}
List<string> bookList = new List<string>()
{
    "C++ by Walter Savitch",
    "git scm book",
    "Fundamentals of OOPs",
};

// all of these will be assigned to a background thread
bookList.ForEach(book => ThreadPool.QueueUserWorkItem((state ) => Download(book)));

Console.WriteLine("Main thread is running....");
