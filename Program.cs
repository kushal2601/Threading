using static System.Console;
using System.Threading;
using System.Diagnostics;

/*
There are 2 types of Threads :-
    1. Background threads
    2. Foreground threads

Foreground threads keep the application running while the Background threads doesn't 
which means if there is a background thread which is running even after all the foreground threads finish
that background thread automatically terminates. 

NOTE :- main thread is a foreground thread
*/
static void Download()
{
    for (int i = 0; i < 10 ; i++){
        Console.WriteLine("Background thread is running....");
        Thread.Sleep(100);
    }
}
var backgroundThread = new Thread(Download);

// to make the thread a background thread
backgroundThread.IsBackground = true;

backgroundThread.Start();

for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Main thread is running...");
    Thread.Sleep(100);
}

