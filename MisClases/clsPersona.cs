using System;

namespace MisClases
{
    public class clsPersona

    {
        #region atributos privados
        private string nombre;
        #endregion
        #region constructores
        public clsPersona() {}
        public clsPersona(string nombre) 
        {
            Nombre = nombre;
        }
        #endregion
        #region propiedades publicas
        //public string Nombre(get; set;) *Propiedades autoimplementadas*
        //public string Nombre{get{} set{...}}
        public string Nombre { get => nombre; set => nombre = value; }
        #endregion
    }
}
