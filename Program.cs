namespace TP_03___INFOPALOOZA_2023;
class Program
{
    static SortedDictionary<int,Cliente> Registro =new SortedDictionary<int, Cliente>();
    static void Main(string[] args)
    {
      int menu=IngresarEntero("");
        while (menu>4 || menu<0)
        {
            menu=IngresarEntero("Presione 1 para nueva inscripción. Presione 2 para obtener Estadísticas del Evento. Presione 3 para buscar Cliente. Presione 4 para cambiar entrada de un Cliente. Presione 5 para Salir");
        }
        int tipoentrada=IngresarEntero("Ingresae 1 si quiere ir el dia 1. Ingresar 2 si quiere ir el dia 2. Ingresar 3 si quiere ir el dia 3. Ingresar 4 si quiere ir los 3 dias",4,1);
        int cantClientes=0;
        int reccaudacionTotal=0;
        if (menu==1)
        {
            Menu1(cantClientes,reccaudacionTotal,tipoentrada);
        }

        else if (menu== 2){
            Menu2();
        }
        else if (menu== 3){
            Menu3();
        }
        else if (menu== 4){
            Menu4();
        }
        else if (menu== 5){
            Menu5();  
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
    static void Menu1(int cantClientes, int reccaudacionTotal, int tipoentrada)
    {
        DateTime fechainscripcion = DateTime.Today;
        int totalabonado=IngresarEntero("Ingrese lo que tenga que pagar");
        string dni = IngresarString("Ingrese su DNI");
        string ape= IngresarString("Ingrese su apellido");  
        string nom=IngresarString("Ingrese su nombre");
        Cliente per1= new Cliente(tipoentrada,fechainscripcion,totalabonado,dni,ape,nom);
        int ID=Tiquetera.DevolverUltimoID();
        Registro.Add(ID, per1);
        cantClientes++;
        if (tipoentrada==1)
        {
            Pago(totalabonado,15000);
            reccaudacionTotal= reccaudacionTotal+15000;
        }
        else if (tipoentrada==2)
        {
            Pago(totalabonado,30000);
            reccaudacionTotal= reccaudacionTotal+30000;
        }
        else if (tipoentrada==3)
        {
            Pago(totalabonado,10000);
            reccaudacionTotal= reccaudacionTotal+10000;
        }
        else if (tipoentrada==4)
        {
            Pago(totalabonado,40000);
            reccaudacionTotal= reccaudacionTotal+40000;
        }
    }
    static void Menu2()
    {
        double totalRecaudado=0;
        double totalRecaudadoDia1=0;
        double totalRecaudadoDia2=0;
        double totalRecaudadoDia3=0;
        double cantEntradasDia1=0;
        double cantEntradasDia2=0;
        double cantEntradasDia3=0;
        Console.WriteLine("Estadisticas del evento:");
        foreach (int ID in Registro.Keys)
        {
            totalRecaudado=totalRecaudado+Registro[ID].TotalAbonado;
            if (Registro[ID].TipoEntrada==1)
            {
                totalRecaudadoDia1=totalRecaudadoDia1+Registro[ID].TotalAbonado;
                cantEntradasDia1=cantEntradasDia1++;
            }
            if (Registro[ID].TipoEntrada==2)
            {
                totalRecaudadoDia2=totalRecaudadoDia2+Registro[ID].TotalAbonado;
                cantEntradasDia2=cantEntradasDia2++;
            }
            if (Registro[ID].TipoEntrada==3)
            {
                totalRecaudadoDia3=totalRecaudadoDia3+Registro[ID].TotalAbonado;
                cantEntradasDia3=cantEntradasDia3++;
            }
        }
        cantEntradasDia1=Porcentaje(cantEntradasDia1,Registro.Count);
        cantEntradasDia2=Porcentaje(cantEntradasDia2,Registro.Count);
        cantEntradasDia3=Porcentaje(cantEntradasDia3,Registro.Count);
        Console.WriteLine("En total lo que se recaudo es "+totalRecaudado);
        Console.WriteLine("La cantidad clientes inscriptos es "+Registro.Count);
        Console.WriteLine("El total recaudado en el dia 1 "+totalRecaudadoDia1);
        Console.WriteLine("El total recaudado en el dia 2 "+totalRecaudadoDia2);
        Console.WriteLine("El total recaudado en el dia 3 "+totalRecaudadoDia3);
        Console.WriteLine("La cantidad de entradas vendidas en le dia 1 es: "+cantEntradasDia1);
        Console.WriteLine("La cantidad de entradas vendidas en le dia 2 es: "+cantEntradasDia2);
        Console.WriteLine("La cantidad de entradas vendidas en le dia 3 es: "+cantEntradasDia3);
    }
    static void Menu3()
    {
        int IDBuscar=IngresarEntero("Ingrese el ID del cliente que quiera buscar su informacion");
        Console.WriteLine(Registro[IDBuscar]);
    }
    static void Menu4()
    {

    }
    static void Menu5()
    {
        Console.WriteLine("Usted ha salido del programa");
        Console.Clear(); 
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
    static double Porcentaje(double num1,double num2)
    {
        double porce=(num1/num2)*100;
        return porce;
    }
}