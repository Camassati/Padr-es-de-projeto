using AdapterPattern;
using AdapterPattern.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        ILumiaXMLTarget lumiaXMLTarget = new LumiaXMLAdapter();
        var xmlLumiaMobile = lumiaXMLTarget.GetLumiaMobilesXMLSpecifications();
        Console.WriteLine(xmlLumiaMobile.InnerText);
    }
}