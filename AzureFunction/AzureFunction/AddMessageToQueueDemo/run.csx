using System;

public static void Run(TimerInfo myTimer, out string outputQueueItem, TraceWriter log)
 {
     // Add a new scheduled message to the queue.
     outputQueueItem = $"Pingade min kö: {DateTime.Now}.";

     // Also write the message to the logs.
     log.Info(outputQueueItem);
 }