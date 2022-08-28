using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_.ca

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "mark academy";
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("m"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("academy"));
            Console.WriteLine(phrase.Substring(8, 3));





            Console.ReadLine();
