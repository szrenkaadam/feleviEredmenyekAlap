using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace FeleviEredmenyek
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Tanulo> tanulok = new List<Tanulo>();

            List<string> tantargyak;
            using (var sr = new StreamReader(@"..\..\..\src\tanulok.txt", Encoding.UTF8))
            {
                tantargyak = sr.ReadLine().Split("\t").Skip(2).ToList();
                while (!sr.EndOfStream)
                {
                    sr.ReadLine();
                    tanulok.Add(new Tanulo(sr.ReadLine(), tantargyak));

                }

            }
            for (int i = 0; i < tanulok.Count; i++)
            {
                Console.WriteLine($"{tanulok[i].Jegyek.Average}");
            }




        }
    }
}
