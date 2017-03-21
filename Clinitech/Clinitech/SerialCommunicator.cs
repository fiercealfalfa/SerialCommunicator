using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Clinitech
{
    class SerialCommunicator
    {
        SerialPort sp;
        public SerialCommunicator()
        {

        }
        public void EstablishConnection()
        {
            string[] portNames = SerialPort.GetPortNames();
            sp = new SerialPort("COM4");
            sp.BaudRate = 9600;
            Console.WriteLine("\0007");
            sp.Write("\0007");
            byte[] buffer = new byte [256];
            Console.WriteLine(sp.Read(buffer,0,0));
            
        }
    }
}
