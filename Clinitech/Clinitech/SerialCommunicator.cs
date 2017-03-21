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
            sp = new SerialPort();
            sp.BaudRate = 9600;
            string[] portNames = SerialPort.GetPortNames(); 
        }
    }
}
