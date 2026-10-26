# Fundamentos de C# — Aplicaciones de consola

Repositorio de práctica dedicado al aprendizaje de los fundamentos de programación utilizando C# y aplicaciones de consola con .NET.

Este repositorio reúne ejercicios de programación estructurada para practicar variables, tipos de datos, estructuras de control, ciclos, arrays y métodos.

## Objetivos de aprendizaje

- Comprender las variables y los tipos de datos de C#.
- Leer y mostrar información mediante la consola.
- Utilizar operadores aritméticos, relacionales y lógicos.
- Implementar condiciones con `if`, `else if` y `else`.
- Utilizar estructuras selectivas `switch`.
- Practicar ciclos `for`, `foreach` y `while`.
- Trabajar con arrays y sus elementos.
- Comprender los argumentos por valor y por referencia.
- Organizar el código mediante métodos.
- Desarrollar la lógica necesaria para resolver problemas de programación.

## Organización del repositorio

El repositorio contiene una única solución de Visual Studio, `FundamentosCSharp.sln`, con un proyecto independiente de consola para cada ejercicio.

Cada proyecto tiene su propio archivo `.csproj` y su punto de entrada `Program.cs`. Esta organización permite ejecutar, probar y modificar cada ejercicio de manera independiente.

## Ejercicios

### Condiciones y estructuras selectivas

1. **Mayor de edad:** determinar la mayoría de edad a partir de la edad introducida por el usuario.
2. **Promedio de calificaciones:** calcular el promedio de cinco notas y determinar si el alumno aprobó.
3. **Menor de tres números:** identificar el menor de tres números introducidos por el usuario.
4. **Par o impar:** determinar si un número es par o impar.
5. **Clasificación de un número:** determinar si un número es positivo o negativo y contemplar el caso del cero.
6. **Clasificación de triángulos:** determinar si un triángulo es equilátero, isósceles o escaleno.

### Ciclos y repetición

7. **Números del 1 al 100:** mostrar los primeros cien números enteros.
8. **Números del 100 al 1:** mostrar los números en orden inverso.
9. **Números pares del 1 al 100:** mostrar únicamente los números pares del intervalo.
10. **Suma del 1 al 100:** calcular la suma de los números del intervalo.
11. **Suma de los impares:** calcular la suma de los números impares del 1 al 100.
12. **Suma de números hasta un negativo:** solicitar números hasta recibir uno negativo y mostrar la suma correspondiente.
13. **Calculadora con menú repetitivo:** realizar operaciones aritméticas mediante un menú y una estructura `switch`.
14. **Números pares entre dos valores:** mostrar los números pares comprendidos entre dos enteros, validando que el segundo sea mayor que el primero.

### Ejercicios adicionales opcionales

15. **Tarifas de estacionamiento:** calcular el importe de estacionamiento según el tipo de vehículo y las horas utilizadas.
16. **Resumen de gastos semanales:** registrar los gastos de siete días, calcular el total y el promedio e identificar el día con el gasto más alto.

Los ejercicios adicionales se incorporan como práctica complementaria y no forman parte de la lista original de la ruta de estudio.

## Tecnologías

- C#
- .NET
- Aplicaciones de consola
- Visual Studio
- Git y GitHub

## Requisitos

- Tener instalado el SDK de .NET compatible con los proyectos.
- Disponer de Visual Studio o de otro entorno compatible con el desarrollo en C#.

## Cómo ejecutar los ejercicios

1. Clonar o descargar el repositorio.
2. Abrir `FundamentosCSharp.sln` en Visual Studio.
3. Seleccionar el proyecto del ejercicio que se desea ejecutar como proyecto de inicio.
4. Ejecutar la aplicación y probar diferentes entradas.

También se puede ejecutar un proyecto específico desde la terminal, situándose en la raíz del repositorio:

```bash
dotnet run --project Ejercicio01_MayorDeEdad/Ejercicio01_MayorDeEdad.csproj
```

Para ejecutar otro ejercicio, sustituir el nombre de la carpeta y del archivo `.csproj` por los correspondientes.

## Proyecto integrador

El proyecto integrador de la primera etapa de la ruta se desarrollará en una solución y un repositorio independientes. Por ese motivo, no forma parte de este repositorio de ejercicios individuales.

## Propósito

Este repositorio tiene fines educativos y forma parte de mi proceso de aprendizaje de C#. Los ejercicios se desarrollan progresivamente para reforzar la lógica de programación, practicar la resolución de problemas y construir una base sólida para temas más avanzados.