namespace Ejercicio03_NumeroMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            int numero3 = Convert.ToInt32(Console.ReadLine());
            int menor = numero1;

            if (numero2 < menor)
            {
                menor = numero2;
            }
            if (numero3 < menor)
            {
                menor = numero3;
            }
            Console.WriteLine($"El número menor es: {menor}");
        }
    }
}