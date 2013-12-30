using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace MyGitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soem changed 
            //
            //Some test 
            //Some for featrue 1.1
            SoapMessage message = new SoapMessage();
            message.Headers = new Header[Convert.ToInt32("12")];
        }
    }
}
