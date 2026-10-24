namespace Ejercicio06_ClasificarTrianguloPorLados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor del primer lado del triangulo");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del segundo lado del triangulo");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del tercer lado del triangulo");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            if (valor1 == valor2 && valor2 == valor3)
            {
                Console.WriteLine("El triangulo es equilátero.");
            }
            else if (valor1 == valor2 || valor2 == valor3 || valor1 == valor3)
            {
                Console.WriteLine("El triangulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triangulo es escaleno.");
            }
        }
    }
}
