using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIAsyncResult
{
    class Program
    {
        static Stream stream;
        static byte[] data;

        static void ReadCompleted(IAsyncResult ar)
        {
            stream.EndRead(ar);
            //Now you can access the data in your buffer
            //Do something with data...
        }

        static void Main(string[] args)
        {  
            stream = File.OpenRead(@"C:\temp\Claims-Based Identity for Windows.pdf");
            data = new byte[4096];
            stream.BeginRead(data, 0, data.Length, ReadCompleted, stream);
        }
    }
}
