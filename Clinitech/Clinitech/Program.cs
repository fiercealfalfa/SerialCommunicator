using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinitech
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialCommunicator sc = new SerialCommunicator();
            sc.EstablishConnection();
            Console.ReadLine();
        }
    }
}
