﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiccionarioT
{
    internal class Dicionario
    {
        public static void Main(string[]args)
        {
            List<Tuple<string, string>> diccionario = crearDiccionario();
            traducir(diccionario);
        }
         public static List<Tuple<string, string>> crearDiccionario()
        {
            List<Tuple<string, string>> diccionario = new List<Tuple<string, string>> ();
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"Introduzca la palabra {i+1} en ingles:");
                string palabra1 = Console.ReadLine();
                Console.WriteLine($"Introduzca la palabra {i + 1} en Espa;ol:");
                string palabra2 = Console.ReadLine();
                diccionario.Add(new Tuple<string, string>(palabra1, palabra2));
            }
            return diccionario; 
        }
        public static void traducir (List<Tuple<string, string>> diccionario)
        {
            Console.Write("Introduzca la palabra a traducir:");
            string palcomp = Console.ReadLine();
            bool encontrado = false;

            foreach (var duo in diccionario)
            {
                if (duo.Item1.Equals(palcomp, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write($"La traduccion de la palabra {palcomp} es:{duo.Item2}.");
                    encontrado = true;
                    break;
                }else if (duo.Item1.Equals(palcomp, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write($"La traduccion de la palabra {palcomp} es:{duo.Item1}.");
                    encontrado = true; 
                }
            }
            if(!encontrado)
            {
                Console.Write($"La palabra {palcomp}no fue encontrada.");
            }

        }
    }
}
   