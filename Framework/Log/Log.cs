using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Framework.Logs
{
    public class Log
    {
        private string Time => $"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}]";
        private bool _isLogging;

        public Log(bool isLogging)
        {
            _isLogging = isLogging;
        }

        public void StartInit()
        {
            if (_isLogging) Console.WriteLine($"{Time} Запуск метода Start...");
        }
        public void StartRender()
        {
            if (_isLogging) Console.WriteLine($"{Time} Запуск процесса рендеринга...");
        }
        public void EndRender()
        {
            if (_isLogging) Console.WriteLine($"{Time} Процес рендеринга завершен.");
        }
        public void CloseProgram()
        {
            if (_isLogging) Console.WriteLine($"{Time} Программа была завершена с кодом 0.");
        }
    }
}