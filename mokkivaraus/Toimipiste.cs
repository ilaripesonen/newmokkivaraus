using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mokkivaraus
{
    public class Toimipiste
    {
        public int toimipiste_id;
        public string nimi;
        public string osoite;
        public string postitoimipaikka;
        public string postinumero;
        public string puhelinnro;
        public string sahkoposti;

        public int GetToimipiste_id()
        {
            return toimipiste_id;
        }
        public void SetToimipiste_id(int value)
        {
            toimipiste_id = value;
        }
              

        public string GetNimi()
        {
            return nimi;
        }

        public void SetNimi(string value)
        {
            nimi = value;
        }
        
        public string GetOsoite()
        {
            return osoite;
        }

        public void SetOsoite(string value)
        {
            osoite = value;
        }

        
        public string GetPostitoimipaikka()
        {
            return postitoimipaikka;
        }

        public void SetPostitoimipaikka(string value)
        {
            postitoimipaikka = value;
        }
             

        public string GetPostinumero()
        {
            return postinumero;
        }

        public void SetPostinumero(string value)
        {
            postinumero = value;
        }

        
        public string GetPuhelinnro()
        {
            return puhelinnro;
        }

        public void SetPuhelinnro(string value)
        {
            puhelinnro = value;
        }
                
        public string GetSahkoposti()
        {
            return sahkoposti;
        }

        public void SetSahkoposti(string value)
        {
            sahkoposti = value;
        }
    }
}
