using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mokkivaraus
{
    public class Palvelu
    {
        public string palveluid;
        public string toimipisteid; // int
        public string nimi;
        public string tyyppi; //int
        public string kuvaus;
        public string hinta; // double
        public string alv; // double

        public void SetPalveluid(string value)
        {
            palveluid = value;
        }
        public string GetPalveluid()
        {
            return palveluid;
        }

        

        public void SetToimipisteid(string value)
        {
            toimipisteid = value;
        }
        public string GetToimipisteid()
        {
            return toimipisteid;
        }

        

        public void SetNimi(string value)
        {
            nimi = value;
        }
        public string GetNimi()
        {
            return nimi;
        }

        
        
        public void SetTyyppi(string value)
        {
            tyyppi = value;
        }
        public string GetTyyppi()
        {
            return tyyppi;
        }

        

        public void SetKuvaus(string value)
        {
            kuvaus = value;
        }
        public string GetKuvaus()
        {
            return kuvaus;
        }
        

        public void SetHinta(string value)
        {
            hinta = value;
        }

        public string GetHinta()
        {
            return hinta;
        }
        

        public void SetAlv(string value)
        {
            alv = value;
        }

        public string GetAlv()
        {
            return alv;
        }

    }
}
