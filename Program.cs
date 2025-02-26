using System.Diagnostics;

// Parse N input

Console.Write("N = ");

string? input = Console.ReadLine();

if (input == null) {
    throw new ArgumentException();
}

int N = int.Parse(input);

// Craete timer

Stopwatch timer = new Stopwatch();
timer.Start();

// Create tasks

Task T1 = Task.Run(() => Tasks.T1.invoke(N));
Task T2 = Task.Run(() => Tasks.T2.invoke(N));
Task T3 = Task.Run(() => Tasks.T3.invoke(N));

// Wait until all tasks finished to prevent exit programm before tasks will coplete
Task.WhenAll(T1, T2, T3).Wait();

timer.Stop();
Console.WriteLine("Time in ms: " + timer.ElapsedMilliseconds);