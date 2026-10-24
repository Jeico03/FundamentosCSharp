namespace Ejercicio01_MayorDeEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
        }
    }
}