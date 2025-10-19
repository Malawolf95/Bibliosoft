using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliosoft
{
    public class Devoluciones
    {
        public int idbook { get; set; }
        public string title { get; set; }

        public int available { get; set; }

        public Devoluciones()
        {
        }

        public Devoluciones(int idbook, string title, int available)
        {
            this.idbook = idbook;
            this.title = title;
            this.available = available;
        }


    }
}
