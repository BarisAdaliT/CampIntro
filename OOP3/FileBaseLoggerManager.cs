using System;

namespace OOP3
{
    class FileBaseLoggerManager : ILogerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
