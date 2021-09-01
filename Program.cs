using System;
using System.Collections.Generic;
using System.IO;

namespace Kangelane_K
{
    class Program
    {
        static List<Kangelane> kangelaned = new List<Kangelane>();
        static void LaeKangelased(string failinimi)
        {
            var kangelasedFailis = File.ReadAllLines(failinimi);
            foreach (var kangelaseKirje in kangelasedFailis)
            {
                var nimiAsukoht = kangelaseKirje.Split(" / ");
                if (nimiAsukoht[0].EndsWith("*")) 
                {
                    kangelaned.Add(new SuperKangelane(nimiAsukoht[0].Substring(0, nimiAsukoht[0].Length - 1), nimiAsukoht[1]));
                }
                else
                {
                    kangelaned.Add(new Kangelane(nimiAsukoht[0], nimiAsukoht[1]));
                }      
            }
        }
        static void Main(string[] args)
        {
            LaeKangelased("kangelaste.txt");
            foreach (var kangelane in kangelaned)
            {
                Console.WriteLine(kangelane);
            }
        }
    }
}
