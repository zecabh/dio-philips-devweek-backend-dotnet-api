using System;
using System.Collections.Generic;

namespace DevWeekPhilips
{
    public class Regiao
    {
        public int id { get; set; }

        public string regiao { get; set; }

        public int total_exames { get; set; }

        //public virtual ICollection<IncidenciaExame> IncidenciaExame { get; set; }

        public Regiao(int id, string regiao, int total_exames)
        {
            this.id = id;
            this.regiao = regiao;
            this.total_exames = total_exames;
        }


    }
}
