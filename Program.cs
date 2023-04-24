namespace TP_03___INFOPALOOZA_2023;
class Program
{
    SortedDictionary<string,int> PlataCurso=new SortedDictionary<string, int>();
    static void Main(string[] args)
    {
      int menu=IngresarEntero("");
        while (menu>4 || menu<0)
        {
            menu=IngresarEntero("Presione 1 para nueva inscripción. Presione 2 para obtener Estadísticas del Evento. Presione 3 para buscar Cliente. Presione 4 para cambiar entrada de un Cliente. Presione 5 para Salir");
        }
        if (menu==1)
        {

        }

        else if (menu== 2){
          
        }
        else if (menu== 3){
   
           
        }
        else if (menu== 4){
            
        }
        else if (menu== 5){
           Console.WriteLine("Usted ha salido del programa");
           Console.Clear();   
        }
    }
    static int IngresarEntero(string frase)
    {
        Console.WriteLine(frase);
        int num;
        return num= int.Parse(Console.ReadLine());
    }
    static string IngresarString(string frase){
        Console.WriteLine(frase);
        string palabra;
        return palabra=Console.ReadLine();
    }
    }