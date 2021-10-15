using System;
using System.Collections.Generic;
using System.Text;

namespace MisClases
{
    class clsListado
    {
        List<clsPersona> personas;

        public clsListado()
        {
            RellenarPersonas();
        }

        public List<clsPersona> Personas { get => personas; set => personas = value; }

        private void RellenarPersonas() 
        {
            personas.Add(new clsPersona("Fernando Galiana"));
            personas.Add(new clsPersona("Fray Guillermo"));
            personas.Add(new clsPersona("Yo"));
            personas.Add(new clsPersona("Edgard Frank Codd"));
            personas.Add(new clsPersona("Perro Samxez"));
            personas.Add(new clsPersona("Bilbo Baggins"));
            personas.Add(new clsPersona("Manolo"));
        }
        public void AddPersonas(string personaName) 
        {
            personas.Add(new clsPersona(personaName));
        }
    }
}
