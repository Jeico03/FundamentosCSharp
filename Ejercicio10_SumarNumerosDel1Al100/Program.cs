namespace Ejercicio10_SumarNumerosDel1Al100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de los números del 1 al 100 es: {suma}");
        }
    }
}
