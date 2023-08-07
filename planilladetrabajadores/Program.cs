using System;

class Program
{
    static void Main()
    {
        const int Empleado = 2;
        string[] nombres = new string[Empleado];
        string[] documento = new string[Empleado];
        string[] documento2 = new string[Empleado];
        double[] Salario = new double[Empleado];
        double[] Horas = new double[Empleado];

        // Captura de datos de los empleados
        for (int i = 0; i < Empleado; i++)
        {
            Console.WriteLine($"Empleado {i + 1}:");
            Console.Write("Digite nombre:         ");
            nombres[i] = Console.ReadLine();

            Console.Write("Digite número de DUI:  ");
            documento[i] = Console.ReadLine();

            Console.Write("Digite número de NIT:  ");
            documento2[i] = Console.ReadLine();

            Console.Write("Digite salario por hora:     ");
            Salario[i] = double.Parse(Console.ReadLine());

            Console.Write("Digite horas trabajadas:     ");
            Horas[i] = double.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        Console.WriteLine("Nombre\t\tHoras Trabajadas\tSalario/Hora\tSalario\t\tRenta\t\tNeto");

        double TotalPlanilla = 0;

        // Cálculos y presentación de la información
        for (int i = 0; i < Empleado; i++)
        {
            double TotalPago = Salario[i] * Horas[i];

            double Renta = TotalPago * 0.10;
            double Pagoneto = TotalPago - Renta;
            TotalPlanilla += TotalPago - Renta;


            Console.WriteLine($"{nombres[i]}\t\t\t{Horas[i]}\t\t{Salario[i]}\t\t{TotalPago}\t\t{Renta}\t\t{Pagoneto}");
        }

        Console.WriteLine("\t");
        Console.WriteLine($"Total Planilla para {Empleado} empleados es de: $ {TotalPlanilla}");

        Console.ReadKey();
    }
}
