using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPmodul5_1302220011
{
    internal class Class1
    {
        public class HaloGeneric
        {
            public void SapaUser<T>(T input)
            {
                Console.WriteLine($"Halo user {input}");
            }
        }

        public class DataGeneric<T>
        {
            public T Data { get; set; }

            public DataGeneric(T data)
            {
                Data = data;
            }

            public void PrintData()
            {
                Console.WriteLine($"Data yang tersimpan adalah: " + Data);
            }
        }
    }
}
