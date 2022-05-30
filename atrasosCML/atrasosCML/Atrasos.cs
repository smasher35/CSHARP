using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atrasosCML
{
    [Serializable]
    public class Atrasos
    {
        private DateTime dataAtraso;
        private int minutosAtraso;
        private int totMinutos;

        public Atrasos(DateTime data, int minutosAtraso)
        {
            this.dataAtraso = data;
            this.minutosAtraso = minutosAtraso;
            this.totMinutos = 0;
        }

        public DateTime DataAtraso
        {
            get { return this.dataAtraso; }

            set { this.dataAtraso = value; }
        }

        public int MinutosAtraso
        {
            get { return this.minutosAtraso; }

            set { this.minutosAtraso = value; }
        }


        public int TotMinutes
        {
            get { return this.totMinutos; }

            set { this.totMinutos = value; }
        }
       public void ActualizarTotMinutos(int value)
        {
            this.totMinutos = value;
        }
        

    }
}
