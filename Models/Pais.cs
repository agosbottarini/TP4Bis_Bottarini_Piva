using System;
public class Pais
{
   public string Nombre {get;private set;}
    public string ImgBnadera {get;private set;}
    public int Poblacion {get;private set;}
    public DateTime FechaIndependencia {get;private set;}
    public string AtractivosTuristicos {get;private set;}

public Pais()
{

}

public Pais(string nombre, string imgBandera, int poblacion, DateTime fechaIndependencia, string atractivosTuristicos)
{
    Nombre = nombre;
    ImgBnadera = imgBandera;
    Poblacion = poblacion;
    FechaIndependencia =  fechaIndependencia;
    AtractivosTuristicos = atractivosTuristicos;
}
}

