using System;

class Program
{
    static void Main()
    {
        //  Analisis Termico y Electrico
        Console.WriteLine("==========================================");
        Console.WriteLine("             PRACTICA FINAL             ");
        Console.WriteLine("Analisis Termico y Electrico del Motor");
        Console.WriteLine("==========================================\n");

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

        // --------------------------------
        // PARTE III: TRANSFERENCIA DE CALOR
        // --------------------------------

        // Conductividad termica del aluminio (W/m·°C)
        double k = 205;

        // Area en metros cuadrados
        double area = 0.35;

        // Espesor en milimetros (8 mm) → convertir a metros
        double espesor_mm = 8;
        double espesor_m = espesor_mm / 1000;  // 0.008 m

        // Temperaturas
        double T_interior = temperaturaC;  // Viene de la Parte I
        double T_exterior = 35;

        // Diferencia de temperatura
        double deltaT = T_interior - T_exterior;

        // Calculo de la transferencia de calor
        double Q = k * area * (deltaT / espesor_m);

        // Mostrar resultado principal (lo que pide la practica)
        Console.WriteLine("\n----- PARTE III: TRANSFERENCIA DE CALOR -----");
        Console.WriteLine($"Tasa de transferencia de calor (Q): {Q:F2} W");

        // Condicion de alerta
        if (Q > 800)
        {
            Console.WriteLine("⚠ ALERTA: Se requiere sistema de enfriamiento");
        }

        // --------------------------------
        // PARTE IV: REPORTE FINAL
        // --------------------------------

        // Datos del estudiante
        string nombre = "Cristopher Manuel Luna Santos";
        string matricula = "0667";
        string fecha = DateTime.Now.ToString("dd/MM/yyyy");

        // Determinar estado del motor
        string estadoMotor;

        // CRITERIO:
        // Si la transferencia de calor es muy alta, el motor puede sobrecalentarse
        // Se define:
        // Q > 1500 → CRITICO
        // Q > 800 → ADVERTENCIA
        // Q <= 800 → NORMAL

        if (Q > 1500)
        {
            estadoMotor = "CRITICO";
        }
        else if (Q > 800)
        {
            estadoMotor = "ADVERTENCIA";
        }
        else
        {
            estadoMotor = "NORMAL";
        }

        // Mostrar reporte final
        Console.WriteLine("\n==========================================");
        Console.WriteLine("         REPORTE FINAL DEL MOTOR          ");
        Console.WriteLine("==========================================");

        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Matricula: {matricula}");
        Console.WriteLine($"Fecha: {fecha}");

        Console.WriteLine("\nEstado del motor: " + estadoMotor);
        Console.WriteLine("==========================================");
    }
}