

using segregacióndeinterfaz__ISP_.interfaces;


namespace segregacióndeinterfaz__ISP_
{
    public class SimplePrinter :IPrint
    {
        public void Print(Document document)
        {
            // Implementación de la impresión
            Console.WriteLine($"Imprimiendo documento: {document.Name}");
        }
    }
}
