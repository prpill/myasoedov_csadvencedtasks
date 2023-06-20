// Задание 5

// В рамках данного задания необходимо реализовать консольное приложение, 
// реализующее поиск файлов на диске в многопоточном режиме. 
// Приложение должно работать следующим образом:

//  1. приложение запускается из командной строки, в приложение необходимо передать 
//     название файла (может быть как полное название, например file.xls, так и часть 
//     имени файла или формат файла) и начальную директорию, из которой начинается 
//     рекурсивный обход;
//  2. поиск файлов происходит в файловой системе, рекурсивно обходятся все директории;
//  3. поиск должен происходить в многопоточном режиме: рекурсивный обход должен 
//     производиться в нескольких потоках, при этом необходимо лимитировать максимальное 
//     число потоков (в качестве лимита можно использовать количество ядер / потоков 
//     процессора);
//  4. при нахождении файла необходимо вывести в консоль сообщение с полным путем 
//     до файла;
//  5. после обхода всей файловой системы приложение должно завершиться.

namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the file you are looking for");
            
            string nameFile;

            while (true)
            {
                Console.Write("\nInput: ");

                nameFile = Console.ReadLine();
                if (!string.IsNullOrEmpty(nameFile))
                    break;
                else
                    Console.WriteLine("This field must not be empty");
            }

            string pathDirectory;

            while (true)
            {
                Console.Write("\nEnter the directory where you want to start searching: ");

                pathDirectory = Console.ReadLine();

                if(Directory.Exists(pathDirectory))
                    break;
                else
                    Console.WriteLine("This directory was not found");
            }
            
            SearchFile searchFile = new SearchFile(nameFile, pathDirectory);

            // while(true)
            // {
            //     if(searchFile.ListThreadCount == -1)
            //         break;
            //     else
            //         Thread.Sleep(100);
            // }

            if (searchFile.Message.Count == 0)
                Console.WriteLine("\nFiles not found");
            else
                foreach (var item in searchFile.Message)
                {
                    Console.WriteLine(item);
                }
        }
    }
}
