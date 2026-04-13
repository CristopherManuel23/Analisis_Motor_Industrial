using System;

// Link del video: https://drive.google.com/file/d/1mSkTOcJFQQxNt9iLFRubLaoZU5GIP74S/view?usp=sharing
class Program
{
    static void Main()
    {
        // ======================================================
        // CONTEXTO DEL PROBLEMA
        // ======================================================
        // Una empresa textil de la Zona Franca de San Pedro de Macorís
        // opera un motor trifásico industrial. El ingeniero de planta
        // necesita una herramienta de cálculo que analice simultáneamente
        // el comportamiento térmico y eléctrico del equipo bajo distintas
        // condiciones de operación.

        //  Analisis Termico y Electrico
        Console.WriteLine("==========================================");
        Console.WriteLine("             PRACTICA FINAL             ");  
        Console.WriteLine("Analisis Termico y Electrico del Motor");
        Console.WriteLine("==========================================\n");

        // ======================================================
        // PARTE I: TEMPERATURA
        // ======================================================

        // LO QUE PIDE LA PRACTICA:
        // 1. Solicitar temperatura en °F basada en la matricula
        // 2. Convertir a °C y Kelvin
        // 3. Mostrar resultados con 2 decimales
        // 4. Calcular el error relativo porcentual (±1.5 °F)

        // La temperatura en °F se construye con los ultimos 2 digitos de la matricula
        // Matricula: 0667 → temperatura en °F = 200.0 + 67 = 267 °F
        double temperaturaF = 267;

        // Formula: °C = (°F - 32) × 5/9
        double temperaturaC = (temperaturaF - 32) * 5 / 9;

        // Formula: K = °C + 273.15
        double temperaturaK = temperaturaC + 273.15;

        // Error del sensor (±1.5 °F)
        double errorAbsoluto = 1.5;

        // Formula: Error relativo (%) = (Error absoluto / Valor real) × 100
        double errorRelativo = (errorAbsoluto / temperaturaF) * 100;

        Console.WriteLine("==========================================");
        Console.WriteLine("      PARTE I: TEMPERATURA       ");
        Console.WriteLine("==========================================");
        Console.WriteLine($"Temperatura en Fahrenheit: {temperaturaF:F2} °F");
        Console.WriteLine($"Temperatura en Celsius: {temperaturaC:F2} °C");
        Console.WriteLine($"Temperatura en Kelvin: {temperaturaK:F2} K");
        Console.WriteLine($"Error relativo del sensor: {errorRelativo:F2} %\n");

        // ======================================================
        // PARTE II: CIRCUITO ELECTRICO MIXTO
        // ======================================================

        // LO QUE PIDE LA PRACTICA:
        // 1. Calcular resistencia de cada rama
        // 2. Calcular resistencia total del circuito
        // 3. Calcular corriente total (Ley de Ohm)
        // 4. Calcular potencia total
        // 5. Calcular corriente en cada rama

        // Resistencias segun la matricula 0667
        double R1 = 10; // 10 + primer dígito de matrícula
        double R2 = 25;
        double R3 = 40;
        double R4 = 22; // 15 + último dígito de matrícula

        // Formula: R_total (serie Rama A) = R1 + R2
        double RA = R1 + R2;

        // Formula: R_total (serie Rama B) = R3 + R4
        double RB = R3 + R4;

        // Formula: Req = 1 / (1/RA + 1/RB)
        double Req = 1.0 / (1.0 / RA + 1.0 / RB);

        double voltaje = 220;

        // Formula: I = V / R
        double corrienteTotal = voltaje / Req;

        // Formula: P = V × I
        double potenciaTotal = voltaje * corrienteTotal;

        // Formula: I = V / R (por rama)
        double corrienteA = voltaje / RA;
        double corrienteB = voltaje / RB;

        Console.WriteLine("==========================================");
        Console.WriteLine("    PARTE II: CIRCUITO ELECTRICO MIXTO     ");
        Console.WriteLine("==========================================");
        Console.WriteLine($"Resistencia Rama A (RA): {RA:F2} Ω");
        Console.WriteLine($"Resistencia Rama B (RB): {RB:F2} Ω");
        Console.WriteLine($"Resistencia equivalente total (Req): {Req:F2} Ω");
        Console.WriteLine($"Corriente total: {corrienteTotal:F2} A");
        Console.WriteLine($"Potencia total: {potenciaTotal:F2} W");
        Console.WriteLine($"Corriente en Rama A: {corrienteA:F2} A");
        Console.WriteLine($"Corriente en Rama B: {corrienteB:F2} A\n");

        // ======================================================
        // PARTE III: TRANSFERENCIA DE CALOR
        // ======================================================

        // LO QUE PIDE LA PRACTICA:
        // 1. Calcular la tasa de transferencia de calor Q
        // 2. Mostrar alerta si Q > 800 W

        double k = 205;
        double area = 0.35;

        double espesor_mm = 8;
        double espesor_m = espesor_mm / 1000;

        double T_interior = temperaturaC;
        double T_exterior = 35;

        // Formula: ΔT = T_interior - T_exterior
        double deltaT = T_interior - T_exterior;

        // Formula: Q = k × A × (ΔT / L)
        double Q = k * area * (deltaT / espesor_m);

        Console.WriteLine("==========================================");
        Console.WriteLine("      PARTE III: TRANSFERENCIA DE CALOR       ");
        Console.WriteLine("==========================================");
        Console.WriteLine($"Tasa de transferencia de calor (Q): {Q:F2} W");

        if (Q > 800)
        {
            Console.WriteLine("⚠ ALERTA: Se requiere sistema de enfriamiento\n");
        }

        // ======================================================
        // PARTE IV: REPORTE FINAL
        // ======================================================

        // LO QUE PIDE LA PRACTICA:
        // 1. Mostrar encabezado con nombre, matricula y fecha
        // 2. Mostrar resultados organizados
        // 3. Generar conclusion automatica del estado del motor

        string nombre = "Cristopher Manuel Luna Santos";
        string matricula = "0667";
        string fecha = DateTime.Now.ToString("dd/MM/yyyy");

        string estadoMotor;

        // CRITERIO:
        // Q > 1500 → CRITICO
        // Q > 800 → ADVERTENCIA
        // Q <= 700 → NORMAL

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

        Console.WriteLine("==========================================");
        Console.WriteLine("         REPORTE FINAL DEL MOTOR          ");
        Console.WriteLine("==========================================");

        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Matricula: {matricula}");
        Console.WriteLine($"Fecha: {fecha}");

        Console.WriteLine("\nEstado del motor: " + estadoMotor);
        Console.WriteLine("==========================================");
    }
}