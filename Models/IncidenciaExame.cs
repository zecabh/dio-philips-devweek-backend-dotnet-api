using System;
using System.ComponentModel.DataAnnotations;

namespace DevWeekPhilips
{
    public class IncidenciaExame
    {
        [Key]
        public int id { get; set; }

        public int Regiao_id { get; set; }

        public int Mes { get; set; }

        public int Faixa_id { get; set; }

        public int Qnt_exames { get; set; }


        public IncidenciaExame(int id, int Regiao_id, int Mes, int Faixa_id, int Qnt_exames)
        {
            this.id = id;
            this.Regiao_id = Regiao_id;
            this.Mes = Mes;
            this.Faixa_id = Faixa_id;
            this.Qnt_exames = Qnt_exames;
        }


    }
}
