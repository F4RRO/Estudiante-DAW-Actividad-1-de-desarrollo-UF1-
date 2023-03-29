using System;
using System.Collections.Generic;
using System.Text;

namespace UF1_DESARROLLO_FABIAN_ARROYO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Actividad 1: Escribe una frase en minúsculas y sin espacios:");
            string frase = Console.ReadLine();

            string fraseMinusculas = "";
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    fraseMinusculas += frase[i].ToString().ToLower();
                }
            }

            int numConsonantes = 0;
            string consonantes = "bcdfghjklmnñpqrstvwxyz";
            for (int i = 0; i < fraseMinusculas.Length; i++)
            {
                char letra = fraseMinusculas[i];
                if (consonantes.Contains(letra.ToString()))
                {
                    numConsonantes++;
                }
            }

            int sumaCifras = 0;
            string numeros = "0123456789";
            for (int i = 0; i < fraseMinusculas.Length; i++)
            {
                if (numeros.Contains(fraseMinusculas[i].ToString()))
                {
                    int cifra = int.Parse(fraseMinusculas[i].ToString());
                    sumaCifras += cifra;
                }
            }

            string consonantesMayusculas = "";
            for (int i = 0; i < fraseMinusculas.Length; i++)
            {
                char letra = fraseMinusculas[i];
                if (consonantes.Contains(letra.ToString()))
                {
                    consonantesMayusculas += letra.ToString().ToUpper();
                }
            }

            Console.WriteLine("La frase en minúsculas y sin espacios es: {0}", fraseMinusculas);
            Console.WriteLine("El número total de consonantes es: {0}", numConsonantes);
            Console.WriteLine("La suma de todas las cifras numéricas es: {0}", sumaCifras);
            Console.WriteLine("Las consonantes en mayúsculas y en orden son: {0}", consonantesMayusculas);

            Console.ReadLine();


        }
    }
}
