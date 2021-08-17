using Persona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Negocio
{
    class NClsPersona
    {
        public String Hablar(ClsPersona persona)
        {
            return "La persona con nombre " + persona.Nombre + " Dice Hola ";
        }
        public String Caminar(ClsPersona persona)
        {
            return "La persona " + persona.Nombre + " va Caminando ";
        }
        public String Reir(ClsPersona persona)
        {
            return "La persona " + persona.Nombre + " Está Riendo ";
        }
        public String Observar(ClsPersona persona)
        {
            return "La persona " + persona.Nombre + " Está Observando ";
        }
    }
}
