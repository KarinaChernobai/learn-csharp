using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;
// An event in C# is a mechanism that allows a class (publisher) to notify other classes (subscribers) when something important happens.
// Events are based on delegates and follow the Observer design pattern.
public class EventsDemo
{
    public static void Demonstrate()
    {
        Alarm alarm = new Alarm();

        // Step 4: Subscribe your even handler to the event
        alarm.OnAlarm += AlarmTriggered;

        alarm.TriggerAlarm();  // Step 5: Raise the event
    }

    static void AlarmTriggered(string message)
    {
        Console.WriteLine($"Event received: {message}");
    }
}

public class Alarm
{
    // Step 1: Define a delegate
    public delegate void AlarmEventHandler(string message);
    // Step 2: Define an event
    // event event-delegate event-name;
    // Delegates and events are related because an event is built upon a delegate. 
    public event AlarmEventHandler OnAlarm;

    public void TriggerAlarm()
    {
        if (OnAlarm != null)  // Step 3: Check if event has subscribers
        {
            OnAlarm("Warning! The alarm is triggered.");
        }
    }
}