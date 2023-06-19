namespace Multithread
{
    class FileSearch
    {
        private string nameFile;
        private string directory;
        
        public FileSearch(string nameFile, string directory)
        {
            this.nameFile = nameFile;
            this.directory = directory;
            SearchFile(directory);
        }
        static int maxThread = Environment.ProcessorCount;
        private List<Thread> listThread = new List<Thread>();
        private List<string> foundFiles {get; set;}
        
        public void Print() 
        {
            foreach (var str in foundFiles)
            {
                Console.WriteLine(str);
            }
        }

        private void SearchFile(object obj)
        {
            string dir = (string)obj;
            foreach (var file in Directory.GetFiles(dir))
            {
                if (file == dir + "/" + nameFile) 
                {
                    foundFiles.Add(file);
                    return;
                }
            }
            string[] dirArr = Directory.GetDirectories(dir);
            if ( dirArr == null)
            {
                if (Thread.CurrentThread.Name == "searchThread")
                    return;
            }
            
            foreach (var searchDir in dirArr)
            {
                if (listThread.Count < maxThread)
                    CreateThread(searchDir);
                else
                    SearchFile(searchDir);
            }
        }
        private void CreateThread(string dir)
        {
            var searchThread = new Thread(SearchFile); // new ParameterizedThreadStart(SearchFile)
            
            listThread.Add(searchThread);

            searchThread.Start(dir);    

            listThread.Remove(Thread.CurrentThread);
        }
    }
}