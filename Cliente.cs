class Cliente {
    public int TipoEntrada{get;private set;}
    public DateTime FechaInscripcion{get;private set;}
    public double TotalAbonado{get;private set;}
    public string DNI{get;private set}
    public string Apellido{get;private set;}
    public string Nombre{get;private set;}
    public Cliente(int tipoentrada,DateTime fechainscripcion,double totalabonado, string dni,string apellido,string nom){
        TipoEntrada=tipoentrada;
        FechaInscripcion=fechainscripcion;
        TotalAbonado=totalabonado;
        DNI=dni;
        Apellido=apellido;
        Nombre=nom;
    }
}