namespace Ejercicio05_PositivoNegativo
{  
    internal class Program
    { 
    static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else

                Console.WriteLine("El número es cero.");
        }
    }
}