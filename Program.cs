using segregacióndeinterfaz__ISP_.interfaces;
using segregacióndeinterfaz__ISP_;


public class Program
{
    public static void Main(string[] args)
    {
        Document doc = new Document { Name = "Reporte", Description = "Reporte anual" };

        IPrint simplePrinter = new SimplePrinter();
        simplePrinter.Print(doc);

        MultiFunctionPrinter mfp = new MultiFunctionPrinter();
        mfp.Print(doc);
        mfp.Scan(doc);
    }
}