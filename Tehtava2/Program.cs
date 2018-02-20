using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            // b.
            List<Piste> lista = new List<Piste>();

            // c.
            Piste p1 = new Piste("eka", 1.0, 2.2);
            Piste p2 = new Piste("toka", 2.2, 3.4);
            lista.Add(p1);
            lista.Add(p2);

            // d.
            Console.WriteLine("d. JSON-muotoinen lista");
            string s = JsonConvert.SerializeObject(lista);
            Console.WriteLine(s);

            // e.
            FileStream stream = 
                new FileStream(@"C:\Temp\bindataTentti.bin", FileMode.Open);
            BinaryReader reader = new BinaryReader(stream);

            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            string s1 = reader.ReadString();
            double d1 = reader.ReadDouble();
            double d2 = reader.ReadDouble();

            string s2 = reader.ReadString();
            double d3 = reader.ReadDouble();
            double d4 = reader.ReadDouble();

            Console.WriteLine("\ne. Binääritiedosto:");
            Console.WriteLine(s1);
            Console.WriteLine(d1);
            Console.WriteLine(d2 + "\n");
           
            Console.WriteLine(s2);
            Console.WriteLine(d3);
            Console.WriteLine(d4 + "\n");

            // f.
            Piste p3 = new Piste(s1, d1, d2);
            Piste p4 = new Piste(s2, d3, d4);
            lista.Add(p3);
            lista.Add(p4);

            Console.WriteLine("f. JSON-muotoinen lista");
            string str = JsonConvert.SerializeObject(lista);
            Console.WriteLine(str + "\n");

        }
    }
}
