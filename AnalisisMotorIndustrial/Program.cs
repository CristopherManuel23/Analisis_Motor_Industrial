using System;

class Program
{
    static void Main()
    {
        //  Analisis Termico y Electrico
        Console.WriteLine("=========   PRACTICA FINAL =========  ");
        Console.WriteLine("Analisis Termico y Electrico del Motor\n");

        // PARTE I: TEMPERATURA

        // La temperatura en °F se construye con los ultimos 2 digitos de la matricula
        // Matricula: 0667 → temperatura = 267 °F
        double temperaturaF = 267;

        // Conversion de Fahrenheit a Celsius
        double temperaturaC = (temperaturaF - 32) * 5 / 9;

        // Conversion de Celsius a Kelvin
        double temperaturaK = temperaturaC + 273.15;

        // Error del sensor (±1.5 °F)
        double errorAbsoluto = 1.5;

        // Calculo del error relativo porcentual
        double errorRelativo = (errorAbsoluto / temperaturaF) * 100;

        // Mostrar resultados con 2 decimales
        Console.WriteLine("----- PARTE I: TEMPERATURA -----");
        Console.WriteLine($"Temperatura en Fahrenheit: {temperaturaF:F2} °F");
        Console.WriteLine($"Temperatura en Celsius: {temperaturaC:F2} °C");
        Console.WriteLine($"Temperatura en Kelvin: {temperaturaK:F2} K");
        // Mostrar el error
        Console.WriteLine($"Error relativo del sensor: {errorRelativo:F2} %");

    }
}