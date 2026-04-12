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

        // --------------------------------
        // PARTE II: CIRCUITO ELECTRICO
        // --------------------------------

        // Resistencias segun la matricula 0667
        double R1 = 10;  // 10 + primer digito (0)
        double R2 = 25;
        double R3 = 40;
        double R4 = 22;  // 15 + ultimo digito (7)

        // Calculo de resistencias en serie
        double RA = R1 + R2;
        double RB = R3 + R4;

        // Calculo de resistencia equivalente total (paralelo)
        double Req = 1.0 / (1.0 / RA + 1.0 / RB);

        // Voltaje de la fuente
        double voltaje = 220;

        // Calculo de la corriente total (Ley de Ohm)
        double corrienteTotal = voltaje / Req;

        // Calculo de la potencia total
        double potenciaTotal = voltaje * corrienteTotal;

        // Corriente en cada rama (circuito en paralelo)
        double corrienteA = voltaje / RA;
        double corrienteB = voltaje / RB;

        // Mostrar resultados
        Console.WriteLine("\n----- PARTE II: CIRCUITO ELECTRICO -----");
        Console.WriteLine($"Resistencia Rama A (RA): {RA:F2} Ω");
        Console.WriteLine($"Resistencia Rama B (RB): {RB:F2} Ω");
        Console.WriteLine($"Resistencia equivalente total (Req): {Req:F2} Ω");
        Console.WriteLine($"Corriente total: {corrienteTotal:F2} A");
        Console.WriteLine($"Potencia total: {potenciaTotal:F2} W");
        Console.WriteLine($"Corriente en Rama A: {corrienteA:F2} A");
        Console.WriteLine($"Corriente en Rama B: {corrienteB:F2} A");
    }
}