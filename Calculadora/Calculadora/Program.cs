using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora Programación Funcional");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");

            Console.Write("Seleccione una opción (1-5): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 5)
            {
                break;
            }

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = Operacion(Suma, num1, num2);
                    break;
                case 2:
                    resultado = Operacion(Resta, num1, num2);
                    break;
                case 3:
                    resultado = Operacion(Multiplicacion, num1, num2);
                    break;
                case 4:
                    resultado = Operacion(Division, num1, num2);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    continue;
            }

            Console.WriteLine($"El resultado es: {resultado}");
        }
    }

    static double Suma(double a, double b) => a + b;
    static double Resta(double a, double b) => a - b;
    static double Multiplicacion(double a, double b) => a * b;
    static double Division(double a, double b) => b != 0 ? a / b : double.NaN;

    static double Operacion(Func<double, double, double> operacion, double a, double b)
    {
        return operacion(a, b);
    }
}

