using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IT_School.DelegatesAndEvents.EventsExample
{
    public class FolderWatcher
    {
        private FileSystemWatcher _fileSystemWatcher;

        public FolderWatcher()
        {
            var watchPath = @"E:\";
            var filter = "*.pdf";
            _fileSystemWatcher = new FileSystemWatcher(watchPath, filter);
            _fileSystemWatcher.EnableRaisingEvents = true;
            _fileSystemWatcher.NotifyFilter = NotifyFilters.Size | NotifyFilters.Security;
        }

        public void StartWatch()
        {
            _fileSystemWatcher.Created += OnPdfFileCreated;
        }

        public void StopWatch()
        {
            _fileSystemWatcher.Created -= OnPdfFileCreated;
        }

        private void OnPdfFileCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Появился файл: {e.Name}");
        }
    }
}
