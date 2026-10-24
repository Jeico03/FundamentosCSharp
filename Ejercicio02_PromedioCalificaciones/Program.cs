namespace Ejercicio02_PromedioCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de cálculo de promedio de calificaciones por consola.");
            Console.WriteLine("Ingrese la nota 1:");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2:");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3:");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 4:");
            double nota4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 5:");
            double nota5 = Convert.ToDouble(Console.ReadLine());
            double promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
            Console.WriteLine("El promedio de las calificaciones es: " + promedio);
        }
    }
}