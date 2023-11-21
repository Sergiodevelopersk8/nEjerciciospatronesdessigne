
using Ejerciciodesingleton;

MySingleton2 instance1 = MySingleton2.GetInstance();
Console.WriteLine($"Instance 1 ID: {instance1.Id}");
MySingleton2 instance2 = MySingleton2.GetInstance();
Console.WriteLine($"Instance 2 ID: {instance2.Id}");
MySingleton2 instance3 = MySingleton2.GetInstance();
Console.WriteLine($"Instance 3 ID: {instance3.Id}");