using static System.Console;
using static Singleton.Logger;

Title = "Singleton";

var instance1 = Instance;
var instance2 = Instance;

if (instance1 == instance2 && instance2 == Instance) WriteLine("Instances are the same.");

instance1.Log($"Message from {nameof(instance1)}");
instance1.Log($"Message from {nameof(instance2)}");

Instance.Log($"Message from {nameof(Instance)}");
ReadLine();