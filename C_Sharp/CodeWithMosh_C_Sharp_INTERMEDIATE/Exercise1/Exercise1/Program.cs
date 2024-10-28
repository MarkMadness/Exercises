using System;
using System.Diagnostics.Contracts;
using System.Threading;

/* Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide two methods: Start and Stop. We call the 
 * start method first, and the stop method next. Then we ask the stopwatch about the duration between start and stop. Duration should be a value 
 * in TimeSpan. Display the duration on the console. We should also be able to use a stopwatch multiple times. So we may start and stop it and 
 * then start and stop it again. Make sure the duration value each time is calculated properly. We should not be able to start a stopwatch twice 
 * in a row (because that may overwrite the initial start time). So the class should throw an InvalidOperationException if its started twice. 
 * 
 * Educational tip: The aim of this exercise is to make you understand that a class should be always in a valid state. We use encapsulation and 
 * information hiding to achieve that. The class should not reveal its implementation detail. It only reveals a little bit, like a blackbox. 
 * From the outside, you should not be able to misuse a class because you shouldn’t be able to see the implementation detail.
 */

/* 
 * Self-review from ChatGPT: 
 * should have Stop method "StopTime - StartTime" instead
 * StartTime and StopTime should be private
 * duration calculation logic: You only need to store the duration once per start-stop cycle. each time the stopwatch is stopped, you should compute the 
 *      elapsed time and addit to the total duration.
 */

namespace Exercises1
{
    internal class Program
    {
        /*
        // My attempt
        public class Stopwatch
        {
            private DateTime StartTime { get; set; }
            private DateTime StopTime { get; set; } 
            private TimeSpan _duration { get; set; } = new TimeSpan();

            public void Start(DateTime start)
            {
                StartTime = start;
            }
            public TimeSpan Stop(DateTime stop)
            {
                StopTime = stop;
                var timeSpent = StopTime - StartTime;
                _duration = _duration + timeSpent;
                return _duration;
            }
            public string FinalDuration()
            {
                return _duration.ToString();
            }
        }
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            var hasStarted = false;
            var hasEnded = false;

            Console.WriteLine("Type 'start' to start the stopwatch. Type 'stop' to stop it. Type 'end' to end the program.");


            while (hasEnded == false)
            {
                Console.WriteLine("start? stop? end?");
                var input = Console.ReadLine().ToLower();

                if (input == "start" && hasStarted == false)
                {
                    var start = DateTime.Now;
                    stopWatch.Start(start);
                    hasStarted = true;
                    Console.WriteLine();
                }
                else if (input == "stop" && hasStarted == true)
                {
                    var stop = DateTime.Now;
                    Console.WriteLine(stopWatch.Stop(stop));
                    Console.WriteLine();
                    hasStarted = false;
                }
                else if (input == "end")
                {
                    hasEnded = true;
                }
                else
                {
                    Console.WriteLine("You already started. Type 'stop' to stop.");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("You ended the program. Here is the final duration : " + stopWatch.FinalDuration());
        }
        */
        // Review improvement
        public class Stopwatch
        {
            private DateTime _startTime;
            private DateTime _stopTime;
            private TimeSpan _duration;
            private TimeSpan _finalDuration;
            private bool _hasStarted = false;

            public void Start()
            {
                if (_hasStarted)
                {
                    throw new InvalidOperationException("You already started the Stopwatch.");
                }

                _startTime = DateTime.Now;
                _hasStarted = true;
            }
            public TimeSpan Stop()
            {
                if (!_hasStarted)
                {
                    throw new InvalidOperationException("You didn't start the Stopwatch.");
                }

                _stopTime = DateTime.Now;
                _duration = _stopTime - _startTime;
                _finalDuration = _finalDuration + _duration;
                _hasStarted = false;
                return _duration;
            }
            public string FinalDuration()
            {
                return _finalDuration.ToString();
            }
        }
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            var hasEnded = false;

            Console.WriteLine("Type 'start' to start the stopwatch. Type 'stop' to stop it. Type 'end' to end the program.");


            while (hasEnded == false)
            {
                Console.WriteLine("start? stop? end?");
                var input = Console.ReadLine().ToLower();

                if (input == "start")
                {
                    stopWatch.Start();
                    Console.WriteLine();
                }
                else if (input == "stop")
                {
                    Console.WriteLine(stopWatch.Stop());
                    Console.WriteLine();
                }
                else if (input == "end")
                {
                    hasEnded = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            Console.WriteLine("You ended the program. Here is the final duration : " + stopWatch.FinalDuration());
        }
    }
}

//ChatGPT generated code:
//namespace Exercises1
//{
//    internal class Program
//    {
//        public class Stopwatch
//        {
//            private DateTime _startTime;
//            private TimeSpan _totalDuration;
//            private bool _isRunning;

//            public void Start()
//            {
//                if (_isRunning)
//                {
//                    throw new InvalidOperationException("Stopwatch is already running. Stop it before starting again.");
//                }

//                _startTime = DateTime.Now;
//                _isRunning = true;
//            }

//            public TimeSpan Stop()
//            {
//                if (!_isRunning)
//                {
//                    throw new InvalidOperationException("Stopwatch is not running. Start it before stopping.");
//                }

//                DateTime stopTime = DateTime.Now;
//                TimeSpan elapsed = stopTime - _startTime;
//                _totalDuration += elapsed;
//                _isRunning = false;

//                return elapsed;
//            }

//            public TimeSpan GetTotalDuration()
//            {
//                return _totalDuration;
//            }
//        }

//        static void Main(string[] args)
//        {
//            var stopWatch = new Stopwatch();
//            var hasEnded = false;

//            Console.WriteLine("Type 'start' to start the stopwatch. Type 'stop' to stop it. Type 'end' to end the program.");

//            while (!hasEnded)
//            {
//                Console.WriteLine("start? stop? end?");
//                var input = Console.ReadLine().ToLower();

//                if (input == "start")
//                {
//                    try
//                    {
//                        stopWatch.Start();
//                        Console.WriteLine("Stopwatch started.");
//                    }
//                    catch (InvalidOperationException ex)
//                    {
//                        Console.WriteLine(ex.Message);
//                    }
//                }
//                else if (input == "stop")
//                {
//                    try
//                    {
//                        TimeSpan elapsed = stopWatch.Stop();
//                        Console.WriteLine($"Elapsed time: {elapsed}");
//                    }
//                    catch (InvalidOperationException ex)
//                    {
//                        Console.WriteLine(ex.Message);
//                    }
//                }
//                else if (input == "end")
//                {
//                    hasEnded = true;
//                }
//                else
//                {
//                    Console.WriteLine("Invalid command. Please type 'start', 'stop', or 'end'.");
//                }
//            }

//            Console.WriteLine("You ended the program. Here is the total duration: " + stopWatch.GetTotalDuration());
//        }
//    }
//}