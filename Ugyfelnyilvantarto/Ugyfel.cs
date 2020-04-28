using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugyfelnyilvantarto
{
    class Ugyfel
    {
        int u_ID;
        string u_nev;
        string u_tel;
        string u_mail;
        string u_mas;
        string u_szekhely;
        string u_adoszam;
        string u_cegj;
        string u_bank;
        string u_iban;
        string u_megj;

        public int U_ID { get => u_ID; set => u_ID = value; }
        public string U_nev { get => u_nev; set => u_nev = value; }
        public string U_tel { get => u_tel; set => u_tel = value; }
        public string U_mail { get => u_mail; set => u_mail = value; }
        public string U_mas { get => u_mas; set => u_mas = value; }
        public string U_szekhely { get => u_szekhely; set => u_szekhely = value; }
        public string U_adoszam { get => u_adoszam; set => u_adoszam = value; }
        public string U_cegj { get => u_cegj; set => u_cegj = value; }
        public string U_bank { get => u_bank; set => u_bank = value; }
        public string U_iban { get => u_iban; set => u_iban = value; }
        public string U_megj { get => u_megj; set => u_megj = value; }

        public Ugyfel(int u_ID, string u_nev, string u_tel, string u_mail, string u_mas, string u_szekhely, string u_adoszam, string u_cegj, string u_bank, string u_iban, string u_megj)
        {
            U_ID = u_ID;
            U_nev = u_nev;
            U_tel = u_tel;
            U_mail = u_mail;
            U_mas = u_mas;
            U_szekhely = u_szekhely;
            U_adoszam = u_adoszam;
            U_cegj = u_cegj;
            U_bank = u_bank;
            U_iban = u_iban;
            U_megj = u_megj;
        }
        public Ugyfel()
        {

        }
    }
}
