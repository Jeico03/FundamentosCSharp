namespace Ejercicio12_SumarNumerosHastaIngresarNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int suma = 0;
           int numero;
            do
            {
                Console.Write("Ingrese un número (negativo para salir): ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero >= 0)
                {
                    suma += numero;
                }
            } while (numero >= 0);
            Console.WriteLine($"La suma de los números ingresados es: {suma}");
        }
    }
}
