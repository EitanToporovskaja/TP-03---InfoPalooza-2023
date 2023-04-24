namespace TP_03___INFOPALOOZA_2023;
class Program
{
    SortedDictionary<string,int> IDCliente=new SortedDictionary<string, int>();
    static void Main(string[] args)
    {
      int menu=IngresarEntero("");
        while (menu>4 || menu<0)
        {
            menu=IngresarEntero("Presione 1 para nueva inscripción. Presione 2 para obtener Estadísticas del Evento. Presione 3 para buscar Cliente. Presione 4 para cambiar entrada de un Cliente. Presione 5 para Salir");
        }
        if (menu==1)
        {
            int tipoentrada=IngresarEntero("Ingresae 1 si quiere ir el dia 1. Ingresar 2 si quiere ir el dia 2. Ingresar 3 si quiere ir el dia 3. Ingresar 4 si quiere ir los 3 dias",4,1);
            DateTime fechainscripcion = DateTime.Today;
            int totalabonado=IngresarEntero("Ingrese lo que tenga que pagar");
            string dni = IngresarString("Ingrese su DNI");
            string ape= IngresarString("Ingrese su apellido");  
            string nom=IngresarString("Ingrese su nombre");
            Cliente per1= new Cliente(tipoentrada,fechainscripcion,totalabonado,dni,ape,nom);
            int plataAbonar;
            if (tipoentrada==1)
            {
                plataAbonar=15000;
                Pago(totalabonado,plataAbonar);
            }
           else if (tipoentrada==2)
            {
                plataAbonar=30000;
                Pago(totalabonado,plataAbonar);
            }
           else if (tipoentrada==3)
            {
                plataAbonar=10000;
                Pago(totalabonado,plataAbonar);
            }
            else if (tipoentrada==4)
            {
                plataAbonar=40000;
                Pago(totalabonado,plataAbonar);
            }
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
    static int IngresarEntero(string frase, int max, int min)
    {
        Console.WriteLine(frase);
        int num;
        num= int.Parse(Console.ReadLine());
        if (num> min || num<=max)
        {
            return num;
        }
        else 
        {
            Console.WriteLine("ERROR, recuerde que debe "+frase);
            num= int.Parse(Console.ReadLine());
            return num;
        }
    }
    static string IngresarString(string frase){
        Console.WriteLine(frase);
        string palabra;
        return palabra=Console.ReadLine();
    }
    static void Pago(int totalabonado,int plataAbonar)
    {
    if (totalabonado>plataAbonar)
        {
            totalabonado=totalabonado-plataAbonar;
            Console.WriteLine("Su vuelto es "+totalabonado+ " pesos.");
        }
        if (totalabonado<plataAbonar)
        {
            plataAbonar=plataAbonar-totalabonado;
            Console.WriteLine("Aun le falta pagar "+plataAbonar+ " pesos.");
        }
    }
}