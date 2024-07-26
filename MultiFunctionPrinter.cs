

using segregacióndeinterfaz__ISP_.interfaces;


namespace segregacióndeinterfaz__ISP_
{
    public class MultiFunctionPrinter : IPrint, IScan
    {
        public void Print(Document document)
        {
            // Implementación de la impresión
            Console.WriteLine($"Imprimiendo documento: {document.Name}");
        }

        public void Scan(Document document)
        {
            // Implementación del escaneo
            Console.WriteLine($"Escaneando documento: {document.Name}");
        }
    }
}
