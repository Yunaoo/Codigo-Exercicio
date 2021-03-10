using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEntities.Entities
{
    class Contrato
    {
        public DateTime Data { get; set; }
        public double ValorHora { get; set; }
        public double Horas { get; set; }

        public Contrato (DateTime data, double valorhora,double horas)
        {
            Data = data;
            ValorHora = valorhora;
            Horas = horas;
        }

        public double ValorTotal() {

           return   Horas * ValorHora;
            
        }
    }
}
