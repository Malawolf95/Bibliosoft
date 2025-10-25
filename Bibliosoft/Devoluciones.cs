using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliosoft
{
    public class Devoluciones
    {
        public int id_usuario { get; set; }
        public int id_libro { get; set; }

        public int DiasPrestado { get; set; }

        public Devoluciones()
        {
        }

        public Devoluciones(int id_usuario, int id_libro, int DiasPrestado)
        {
            this.id_usuario = id_usuario;
            this.id_libro = id_libro;
            this.DiasPrestado = DiasPrestado;
        }


    }
}
