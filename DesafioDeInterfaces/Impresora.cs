using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDeInterfaces
{
    class Impresora
    {
        private List<Imprimible> ColaDeImpresion = new List<Imprimible>();//lista de imprimibles

        public void ImprimirTodo()//se encarga de  recorrer la ColaDeImpresion y los imprime
        {
            foreach (Imprimible item in ColaDeImpresion) item.Imprimir();
        }
        public void AgregarImprimible(Imprimible unImprimible)//permite agregar un imprimible a la ColaDeImpresion
        {
            ColaDeImpresion.Add(unImprimible);
        }
    }
}
