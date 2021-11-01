using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDeInterfaces
{
    class Documento : Imprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un documento de word");
        }
    }
}
