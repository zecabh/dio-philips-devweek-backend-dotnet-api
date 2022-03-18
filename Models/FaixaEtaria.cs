using System;
using System.ComponentModel.DataAnnotations;

namespace DevWeekPhilips
{
    public class FaixaEtaria
    {
        [Key]
        public int id { get; set; }

        public int Faixa_i { get; set; }

        public int Faixa_n { get; set; }

        public string Descricao { get; set; }

        

        public FaixaEtaria(int id, int Faixa_i, int Faixa_n, string Descricao)
        {
            this.id = id;
            this.Faixa_i = Faixa_i;
            this.Faixa_n = Faixa_n;
            this.Descricao = Descricao;
        }


    }
}
