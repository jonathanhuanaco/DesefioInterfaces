using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDeInterfaces
{
    class Foto : Imprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy una selfie pal insta");
        }
    }
}
