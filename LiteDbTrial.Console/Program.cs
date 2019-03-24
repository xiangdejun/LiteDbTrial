using System;

namespace LiteDbTrial.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataaccess = new DataAccess.DataAccess();
            dataaccess.GetConnection();
        }
    }
}
