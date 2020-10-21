using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luce
{
    public class Lampadina
    {
        private int massimoClick;
        private String stato;
        private int numeroclick;
        public Lampadina(int m, String s, int n)
        {
            massimoClick = m;
            stato = s;
            numeroclick=n;
        }
        public string Descrizione()
        {
            return "Lo stato della lampadina è " + stato;
        }
        public string Click(int massimoClick)
        {
            numeroclick++;
                if(numeroclick>massimoClick)
                {
                    stato = "rotta";
                }
                else
                {
                    if (stato == "accesa")
                    {
                        stato = "spenta";
                    }
                    else if (stato == "spenta")
                    {
                        stato = "accesa";
                    }
                }
            return stato;
        }
    }
}
