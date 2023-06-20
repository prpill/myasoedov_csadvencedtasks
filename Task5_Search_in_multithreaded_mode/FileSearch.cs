namespace MultiThread
{
    class SearchFile
    {
        private string fileName;
        private string directory;
        private List<Thread> listThread = new List<Thread>();
        public int ListThreadCount {get{return listThread.Count;}}
        private static int maxThread = Environment.ProcessorCount;
        private List<string> message = new List<string>(); 
        public List<string> Message { get { return message; } }
        public SearchFile(string fileName, string directory)
        {
            this.fileName = fileName;
            this.directory = directory;
            Search(directory);
        }

        private void Search(object obj)
        {
            string path = (string)obj;

            foreach (var file in Directory.GetFiles(path))
            {
                if (Path.GetFileName(file).StartsWith(fileName))
                {
                    message.Add(file);
                }
            }
            if (Directory.GetDirectories(path).Length == 0)
                return;

            foreach (var directory in Directory.GetDirectories(path))
            {
                CreateThread(directory);
            }
        }
        private void CreateThread(string path)
        {
            while (true)
            {
                lock (listThread)
                {
                    if (listThread.Count < maxThread)
                    {
                        Thread newThread = new Thread(Search);

                        listThread.Add(newThread);

                        newThread.Start(path);

                        break;
                    }
                    else
                        Thread.Sleep(100);
                }
            }
            listThread.Remove(Thread.CurrentThread);
        }    
    }
}