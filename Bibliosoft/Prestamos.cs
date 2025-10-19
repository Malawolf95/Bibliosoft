using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliosoft
{

    public class Prestamo
    {
        public int id_usuario { get; set; }
        public int id_libro { get; set; }
        public int DiasPrestar { get; set; }

        public Prestamo() { }


        public Prestamo(int id_usuario, int id_libro, int DiasPrestar)
        {
            this.id_usuario = id_usuario;
            this.id_libro = id_libro;
            this.DiasPrestar = DiasPrestar;
        }
    }
}
