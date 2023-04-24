namespace TP_03___INFOPALOOZA_2023;
class Program
{
    static List<Cliente> listaClientes= new List <Cliente>();
    static void Main(string[] args)
    {
      int menu=IngresarEntero("");
        while (menu>4 || menu<0)
        {
            menu=IngresarEntero("");
        }
        while(menu<=4|| menu>0)
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