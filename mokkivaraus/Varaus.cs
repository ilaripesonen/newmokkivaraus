using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mokkivaraus
{
    class Varaus
    {
        private string _varausid;
        private string _asiakasid;
        private string _toimipisteid;
        private string _varattu_pvm;
        private string _vahvistus_pvm;
        private string _varattu_alkupvm;
        private string _varattu_loppupvm;
        private double ero;
        

        public string Toimipisteid { get => _toimipisteid; set => _toimipisteid = value; }
        public string Varattu_pvm { get => _varattu_pvm; set => _varattu_pvm = value; }
        public string Vahvistus_pvm { get => _vahvistus_pvm; set => _vahvistus_pvm = value; }
        public string Varattu_alkupvm { get => _varattu_alkupvm; set => _varattu_alkupvm = value; }
        public string Varattu_loppupvm { get => _varattu_loppupvm; set => _varattu_loppupvm = value; }
        public string Varausid { get => _varausid; set => _varausid = value; }
        public string Asiakasid { get => _asiakasid; set => _asiakasid = value; }
        public double Ero { get => ero; set => ero = value; }

        public Varaus()
        {

        }

    }
}
