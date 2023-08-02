using static System.Console;
using System.Threading;
using System.Diagnostics;

/*
--------------------------------Task -------------------------------------------------------------
Task is nothing but an feature provided by the .NET framework which allows the ThradPool to manage all the 
tasks without us doing it explicitly 

Efficient way of creating threads where ThreadPool manages the threads efficiently
*/

static void Download(string fileName)
{
    WriteLine("Downloading " + fileName);
    Thread.Sleep(1000);
    WriteLine("Downloaded " + fileName);
}
// creating a task and starting the task with a new method called Start()
var task1 =  new Task(
    () => Download("C++ by Walter Savitch  ")
);
task1.Start();

// creating a task and running using task.Run()
var task2 = Task.Run(
    () => Download("git scm book")
);

task1.Wait();
WriteLine("Main thread is running here");