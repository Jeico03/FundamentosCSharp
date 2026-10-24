namespace Ejercicio13_CalculadoraConMenuRepetitivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSeleccione una operación:\n");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");

                string opcion = Console.ReadLine();

                if (opcion == "5")
                {
                    break;
                }
                Console.WriteLine("Ingrese el primer número:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double resultado = 0;
                switch (opcion)
                {
                    case "1":
                        resultado = num1 + num2;
                        break;
                    case "2":
                        resultado = num1 - num2;
                        break;
                    case "3":
                        resultado = num1 * num2;
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: División por cero.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        continue;
                }
                Console.WriteLine($"El resultado es: {resultado}\n");
                }
            }
    }
}
