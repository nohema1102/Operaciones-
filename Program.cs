using System;
using System.IO;

namespace Operaciones_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Intentar ejecutar el código dentro del try
            Console.WriteLine("Introduce el valor a:");
            //transformar a float lo que se introduzca en la consola
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el valor b:");
            float b = float.Parse(Console.ReadLine());

            //float a = 10f;
            //float b = 2f;

            float resultado = a / b;
            Console.WriteLine($"{a} / {b} = {resultado}");

            //Requiere agregar directiva using!
            using (StreamWriter sw = new StreamWriter("operacion.txt"))
            {
                sw.WriteLine($"{a} / {b} = {resultado}");
            }
        }
        //catch (System.Exception) // Atrapa cualquier Exception X
        catch(System.FormatException)//Atrapar solamente las exception que nos interesan

        {
            //si ocurre una Exception en el try, se ejecuta el codigo en el catch
            Console.WriteLine("Error, por favor introduce numeros validos");
            // throw;
        }
        finally
        {
            Console.WriteLine("Este mensaje siempre se muestra");
        }
            
         
        }   


    }
}
