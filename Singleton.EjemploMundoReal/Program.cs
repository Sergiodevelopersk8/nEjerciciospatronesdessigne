using Singleton.EjemploMundoReal;

EventeLogger logger =  EventeLogger.GetInstance();

logger.LogEvent("Starting app.");
logger.LogEvent("Executing Task 1.");
logger.LogEvent("Finishi execution of task 1.");
logger.LogEvent("Ending app.");
logger.DisplayLogs();
Console.WriteLine("se ejecuto bien el singleton");

