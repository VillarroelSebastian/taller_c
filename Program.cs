using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escribir un programa con las siguientes características:
 a.El usuario debe ingresar la cantidad de números que desea leer o generar.Los números a leer o generar deben estar en el rango de -1000 a 1000.Se debe validar al momento de leer los números.
 b.Si la cantidad de números es mayor a 10, los números deben generarse de manera aleatoria, caso contrario los números deben ser ingresados por el usuario.
 c.Si la cantidad de números es menor o igual a cero debe solicitar al usuario que ingrese una cantidad positiva y volver a ingresar la cantidad.
 d.Imprimir los siguientes resultados:
 d1.Cantidad de números pares.
 d2.Cantidad de números negativos múltiplos de 3.
 d3.Porcentaje de pares positivos que terminan en 24.
 d4.Promedio de números que están entre - 250 y 452(se incluye los límites)
 d5.Promedio de impares negativos que sean múltiplos de 3 pero no múltiplos de 5.
 d6.Si el cuarto número leído o generado es mayor que el último número leído o generado, mostrar el producto del segundo número leído con el séptimo número leído, caso contrario mostrar la suma del tercer número leído con el penúltimo número leído.
 d7.Promedio de los números mayores a 500;
 d8.Porcentaje de los números que terminan en 8 y son menores a 158.
 d9.Promedio de números pares generados después del décimo número.
 d10.Cantidad de números primos. (escribir una función para determinar si el número es primo.La función debe retornar 0 si es primo y 1 si no es primo)
  Debes escribir una función para leer la cantidad de números. La función devuelve la cantidad ingresada por el usuario
· Debes escribir una función para calcular el promedio en todos los casos que se requiere. La función devuelve el promedio.
· Debes escribir una función para calcular el porcentaje en todos los casos que se requiere. La función devuelve el porcentaje.
· Debes tener un solo método para mostrar los resultados. Al método se le envía el mensaje y el valor a mostrar.
· Considerar los posibles mensajes para el usuario en caso de que no existan datos que cumplan los puntos a desarrollar.*/
            int n,nr;
            n = leer_datos("Ingrese la cantidad de números que desea generar");
           
              new Random();
            Random rd = new Random();
            if (n >= 10) 
                for (int i = 0; i<n;i++)
                {
                    nr = rd.Next();  
                    Console.WriteLine(nr);


                }    
            else 
                if (n <= 10)
                for (int i = 0; i<n; i++)
                {
                    Console.WriteLine("Ingrese su número");
                    nr = int.Parse(Console.ReadLine());
                    Console.WriteLine(nr);

                }    

        }
        public static int leer_datos(string dato)
        {
            Console.WriteLine(dato);
            int n = int.Parse(Console.ReadLine());
            return n;



        }
    }
}