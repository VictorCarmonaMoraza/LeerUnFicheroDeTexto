using System;
using System.IO;

namespace Leer_Un_Fichero_de_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Prueba.txt");

            string linea;

            //Para leer linea a linea
            //Cuando la linea sea nula se dejara de leer
            while((linea = sr.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }
            //Tenemos que cerrar al leer 
            sr.Close();

            Console.ReadLine();   
        }
    }
}
