using System;

namespace Lab3_z2
{
    class Program
    {
        static List<string> ToSortedArray(List<string> lista)
        {
            var sortiranaLista = lista.OrderBy(s => s.Length).ToList();
            return sortiranaLista;
        }

        static void Main(string[] args)
        {
            List<string> lista = new List<string>() {
                "frizura",
                "oko",
                "ja",
                "otorinolaringologija",
                "globus",
                "ti"
            };
            var sortiranaLista = ToSortedArray(lista);

            Console.WriteLine("Stringovi sortirani prema dužini:");
            foreach (var s in sortiranaLista)
                Console.Write("{0}  ", s);
        }
    }
}