﻿// Задание 5

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


namespace Multithread
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}