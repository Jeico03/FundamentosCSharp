namespace Ejercicio14_MostrarParesEntreDosNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el primer número:");
            int primerNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo número:");
            int segundoNumero = int.Parse(Console.ReadLine());

            while (segundoNumero <= primerNumero)
            {
                Console.WriteLine($"El segundo número debe ser mayor que {primerNumero}. Intente de nuevo:");
                segundoNumero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Los números pares entre {primerNumero} y {segundoNumero} son:");
            for (int i = primerNumero; i <= segundoNumero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}