using System.Diagnostics;
using System.IO.Enumeration;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Процесс пердставлен в c# в виде класса Process
             * из пространнства имен System.Diagnostics
             * Параметры запуска процесса представлены в виде класса
             * ProcessStartInfo
             * 
             */

            //var psi = new ProcessStartInfo
            //{
            //    FileName = "dotnet",
            //    UseShellExecute = false
            //};
            //psi.ArgumentList.Add("--version");

            //using Process proc = Process.Start(psi)
            //    ?? throw new InvalidCastException("Error" + "start procces");
            //proc.WaitForExit();
            //Console.WriteLine(proc.ExitCode);


            /* 
             * у любого процесса есть свои стандартные потоки ввода и вывода 
             * (не путать с системными потоками - threads, эти потоки streams)
             * 
             * stdin - стандартный поток ввода
             * proc.StandardInput
             * stdout стандартный поток ввода
             * proc.StandardOutpur
             * stderr - стандартный поток ошибок
             * proc.StandardError
             * 
             * ExitCode 
             * по уполночанию 
             * 0 = успех
             * 1 = общая ошибка
             * 2 = не верные аргументы
             * 
             * psi.WorkingDirectory 
             * PATH одна из переменных сред (но на всю систему)
             * 
             *psi.Enviroment
             *
             *
             */

            //var psi = new ProcessStartInfo
            //{
            //    FileName = "dotnet",
            //    UseShellExecute = false
            //};
            //psi.Environment["MY_VARIABLE"] = "true";

            /*
             * UseShellExecute = true - запуск процессса идет через 
             * механизм оболочки/ОС
             * В этом режиме нельзя перенаправлять стандратные потоки.
             * 
             * UseShellExecute = false 
             * Читать stdout,stderr, писать в stdin управлять процессом
             * 
             * Procces.Kill();
             * этот метод убивает процесс. Процесс завершается принудительно 
             * Этот метод считается грубым
             * после kill 
             * 1 Процесс не успевает коректно освободить рессурсы
             * 2 не вызываются блокировки finally
             * 3 не вызывается оброботчики завершения
             * 4 данные в буферах могут потерятся
             * 5 временные файлы могут остаться 
             * 6 состояние может быть не коретктно сохранени
             * 
             * proc.Kill(entireProcces: true ) - то убиваем не только сам процессы но и все его 
             * дочерние процессы(убивает все процессы которые породил этот процесс который мы убиваем)
             * 
             * мягкая остановка это когда процесс завершается сам
             * 
             * 
             * 
             */

        }
    }
}
