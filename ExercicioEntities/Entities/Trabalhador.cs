
using ExercicioEntities.Entities.Enums;
using ExercicioEntities.Entities;
using System.Collections.Generic;
namespace ExercicioEntities
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public WorkerLevel Level { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<Contrato> Contratos { get; set; }
        public Trabalhador() { 
          Contratos = new List<Contrato>();
        }
        public Trabalhador(string nome, WorkerLevel level, double salariobase, Departamento departamento)
        {
            Nome = nome;
            Level = level;
            SalarioBase = salariobase;
            Departamento = departamento;
            Contratos = new List<Contrato>();
        }
        public void AddContrato(Contrato contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemoveContrato(Contrato contrato)
        {
            Contratos.Remove(contrato);
        }
        public double Ganho(int Ano, int Mes)
        {
            double soma = SalarioBase;
            foreach (Contrato contrato in Contratos)
            {
                if (contrato.Data.Year == Ano && contrato.Data.Month == Mes)
                {
                    soma = SalarioBase + contrato.ValorTotal();
                }

            }
            return soma;
        }
    }
}
