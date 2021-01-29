using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
    class RevistaFacultad
    {
        int id;
        Revista revista;
        Facultad facultad;


        public RevistaFacultad()
        { }

        public RevistaFacultad(int id, Revista revista, Facultad facultad)
        {
            this.Id = id;
            this.Revista = revista;
            this.Facultad = facultad;
        }

        public int Id { get => id; set => id = value; }
        public Revista Revista { get => revista; set => revista = value; }
        public Facultad Facultad { get => facultad; set => facultad = value; }
    }
}
