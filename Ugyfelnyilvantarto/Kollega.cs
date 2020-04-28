using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugyfelnyilvantarto
{
    class Kollega
    {
        int k_ID;
        string k_nev;
        string k_tel;
        string k_mail;
        string k_mas;
        int k_nyelv1;
        string k_ny1;
        int k_nyelv2;
        string k_ny2;
        int k_nyelv3;
        string k_ny3;
        int k_nyelv4;
        string k_ny4;
        string k_megj;

        public int K_ID { get => k_ID; set => k_ID = value; }
        public string K_nev { get => k_nev; set => k_nev = value; }
        public string K_tel { get => k_tel; set => k_tel = value; }
        public string K_mail { get => k_mail; set => k_mail = value; }
        public string K_mas { get => k_mas; set => k_mas = value; }
        public int K_nyelv1 { get => k_nyelv1; set => k_nyelv1 = value; }
        public string K_ny1 { get => k_ny1; set => k_ny1 = value; }
        public int K_nyelv2 { get => k_nyelv2; set => k_nyelv2 = value; }
        public string K_ny2 { get => k_ny2; set => k_ny2 = value; }
        public int K_nyelv3 { get => k_nyelv3; set => k_nyelv3 = value; }
        public string K_ny3 { get => k_ny3; set => k_ny3 = value; }
        public int K_nyelv4 { get => k_nyelv4; set => k_nyelv4 = value; }
        public string K_ny4 { get => k_ny4; set => k_ny4 = value; }
        public string K_megj { get => k_megj; set => k_megj = value; }

        public Kollega(int k_ID, string k_nev, string k_tel, string k_mail, string k_mas, int k_nyelv1, string k_ny1, int k_nyelv2, string k_ny2, int k_nyelv3, string k_ny3, int k_nyelv4, string k_ny4, string k_megj)
        {
            K_ID = k_ID;
            K_nev = k_nev;
            K_tel = k_tel;
            K_mail = k_mail;
            K_mas = k_mas;
            K_nyelv1 = k_nyelv1;
            K_ny1 = k_ny1;
            K_nyelv2 = k_nyelv2;
            K_ny2 = k_ny2;
            K_nyelv3 = k_nyelv3;
            K_ny3 = k_ny3;
            K_nyelv4 = k_nyelv4;
            K_ny4 = k_ny4;
            K_megj = k_megj;
        }
        public Kollega()
        {

        }
    }
}
