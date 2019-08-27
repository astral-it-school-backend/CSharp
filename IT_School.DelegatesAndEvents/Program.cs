using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using IT_School.DelegatesAndEvents.DelegatesExamples;
using IT_School.DelegatesAndEvents.EventsExample;

namespace IT_School.DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunExamlpe.Run();

            var watcher = new FolderWatcher();
            watcher.StartWatch();

            Console.ReadKey();
        }
    }


}
