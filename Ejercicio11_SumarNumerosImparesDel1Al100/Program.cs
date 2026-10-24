namespace Ejercicio11_SumarNumerosImparesDel1Al100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine($"La suma de los números impares del 1 al 100 es: {suma}");
        }
    }
}
