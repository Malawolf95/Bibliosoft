using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bibliosoft
{
    public class Libros
    {
        public int idbook { get; set; }
        public string title { get; set; }

        public int available { get; set; }

        public Libros()
        {
        }

        public Libros(int idbook, string title, int available)
        {
            this.idbook = idbook;
            this.title = title;
            this.available = available;
        }
        

    }
}
