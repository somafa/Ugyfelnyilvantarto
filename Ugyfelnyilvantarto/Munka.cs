using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugyfelnyilvantarto
{
    class Munka
    {
        int m_ID;
        DateTime datum;
        int u_ID;
        string u_nev;
        string leiras;
        int forrasny_ID;
        string forrasny_megnev;
        int celny_ID;
        string celny_megnev;
        int k_ID;
        string k_nev;
        int kollega_dija;
        int pld;
        int futar;
        int hitelesites;
        int ar;
        int fizetve;
        DateTime mikor;
        string statusz;

        public int M_ID { get => m_ID; set => m_ID = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int U_ID { get => u_ID; set => u_ID = value; }
        public string U_nev { get => u_nev; set => u_nev = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Forrasny_ID { get => forrasny_ID; set => forrasny_ID = value; }
        public string Forrasny_megnev { get => forrasny_megnev; set => forrasny_megnev = value; }
        public int Celny_ID { get => celny_ID; set => celny_ID = value; }
        public string Celny_megnev { get => celny_megnev; set => celny_megnev = value; }
        public int K_ID { get => k_ID; set => k_ID = value; }
        public string K_nev { get => k_nev; set => k_nev = value; }
        public int Kollega_dija { get => kollega_dija; set => kollega_dija = value; }
        public int Pld { get => pld; set => pld = value; }
        public int Futar { get => futar; set => futar = value; }
        public int Hitelesites { get => hitelesites; set => hitelesites = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Fizetve { get => fizetve; set => fizetve = value; }
        public DateTime Mikor { get => mikor; set => mikor = value; }
        public string Statusz { get => statusz; set => statusz = value; }

        public Munka(int m_ID, DateTime datum, int u_ID, string u_nev, string leiras, int forrasny_ID, string forrasny_megnev, int celny_ID, string celny_megnev, int k_ID, string k_nev, int kollega_dija, int pld, int futar, int hitelesites, int ar, int fizetve, DateTime mikor, string statusz)
        {
            M_ID = m_ID;
            Datum = datum;
            U_ID = u_ID;
            U_nev = u_nev;
            Leiras = leiras;
            Forrasny_ID = forrasny_ID;
            Forrasny_megnev = forrasny_megnev;
            Celny_ID = celny_ID;
            Celny_megnev = celny_megnev;
            K_ID = k_ID;
            K_nev = k_nev;
            Kollega_dija = kollega_dija;
            Pld = pld;
            Futar = futar;
            Hitelesites = hitelesites;
            Ar = ar;
            Fizetve = fizetve;
            Mikor = mikor;
            Statusz = statusz;
        }
        public Munka()
        {

        }
    }
}
