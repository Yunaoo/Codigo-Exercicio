using System;
using ExercicioEntities.Entities.Enums;
using ExercicioEntities.Entities;
using System.Globalization;
using System.Collections.Generic;
namespace ExercicioEntities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o nome do departamento: ");

            string dptname = Console.ReadLine();        
            Console.WriteLine("Entre com os dados do trabalhador");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Level: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salario: ");
            double salariobase = double.Parse(Console.ReadLine());
            Departamento departamento = new Departamento(dptname);
            Trabalhador trabalhador = new Trabalhador(nome, level, salariobase,departamento);
            Console.Write("Quantos contratos o trabalhador fez? ");
            int x = int.Parse(Console.ReadLine()); 
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Entre com os dados do contrato # {i}");
                Console.Write("Data");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora");
                double valorhora = double.Parse(Console.ReadLine());
                Console.Write("Total de horas");
                double horas = double.Parse(Console.ReadLine());
               Contrato contrato = new Contrato(data, valorhora, horas);
                trabalhador.AddContrato(contrato);
            }
            Console.WriteLine("Entre com o mês e ano que para calcular o valor ganho  ");
            string MMYY = Console.ReadLine();
            int mes = int.Parse(MMYY.Substring(0, 2));// Recorta o string da posicao 0 ate a posicao 2
            int ano = int.Parse(MMYY.Substring(3)); // Recorta da posicao 3 até o final;
            Console.WriteLine($"Name : {trabalhador.Nome}");
            Console.WriteLine($"Department: {dptname}");
            Console.WriteLine($"Income for: {MMYY} {trabalhador.Ganho(ano,mes).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
