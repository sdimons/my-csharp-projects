using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentDetails
{
    class Program
    {
        static int Main(string[] args)
        {
            ShowEnvironmentDetails();
            Console.ReadLine();
            return -1;
        }

        private static void ShowEnvironmentDetails()
        {
            // Логические устройства
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            // Версия операционой системы
            Console.WriteLine("OS: {0}"
                , Environment.OSVersion);

            // Количество процессоров
            Console.WriteLine("Number of porcessors: {0}"
                , Environment.ProcessorCount);

            // Версия CLR (common language runtime)
            Console.WriteLine("CLR Version: {0}"
                , Environment.Version);

            // Имя текущего компьютера
            Console.WriteLine("Machine name: {0}"
                , Environment.MachineName);

            // Имя пользователя, запустившего данное приложенние
            Console.WriteLine("User name: {0}"
                , Environment.UserName);

            // Символ новой строки для текущей среды
            Console.WriteLine("Hello!{0}Goodbey!"
                , Environment.NewLine);
        }
    }
}
