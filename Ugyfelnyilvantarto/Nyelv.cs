using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugyfelnyilvantarto
{
    class Nyelv
    {
        int ny_ID;
        string megnevezes;

        public int Ny_ID { get => ny_ID; set => ny_ID = value; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }

        public Nyelv(int ny_ID, string megnevezes)
        {
            Ny_ID = ny_ID;
            Megnevezes = megnevezes;
        }
        public Nyelv()
        {

        }
    }
}
