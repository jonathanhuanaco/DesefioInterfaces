using System;

namespace DesafioDeInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos

            Contrato contrato = new Contrato();
            Foto foto = new Foto();
            Documento documento = new Documento();
            Impresora impresora = new Impresora();

            impresora.AgregarImprimible(contrato);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(documento);
            impresora.ImprimirTodo();

            Console.Read();
        }
    }
}
