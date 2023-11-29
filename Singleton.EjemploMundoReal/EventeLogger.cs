using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.EjemploMundoReal
{
    public class EventeLogger
    {
        private static EventeLogger _instance;

        //creamos una lista de event loggers
        private List<string> _eventlogs;

        //constructor

        private EventeLogger()
        {
            //inicialisamos eventlogs la lista
            _eventlogs = new List<string>();

        }


        //unico acceso que tiene las clases es estatico y devuelve un event logger
        public static EventeLogger GetInstance()
        {
            if(_instance == null)
            {
                _instance = new EventeLogger();
            }
            return _instance;
        }


        public void LogEvent(string eventMessage)
        {
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
            _eventlogs.Add($"{timestamp}: {eventMessage}");
        }


        public void DisplayLogs()
        {
            foreach(string logs in _eventlogs)
            {
                Console.WriteLine(logs);
            }
        }


    }
}
