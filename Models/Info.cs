public static class Info
{
    static List <Pais> ListaPaises = new List<Pais>();

    public static void  IniciarLista()
    {
        
        ListaPaises.Add(new Pais("Argentina", imgBandera, poblacion, fechaIndependencia, atractivosTuristicos));
        ListaPaises.Add(new Pais(Brasil, imgBandera, poblacion, fechaIndependencia, atractivosTuristicos));
        ListaPaises.Add(new Pais(nombre, imgBandera, poblacion, fechaIndependencia, atractivosTuristicos));
        ListaPaises.Add(new Pais(nombre, imgBandera, poblacion, fechaIndependencia, atractivosTuristicos));
        ListaPaises.Add(new Pais(nombre, imgBandera, poblacion, fechaIndependencia, atractivosTuristicos));
    }

    public static List<Pais> ListarPaises()
    {
        if(ListaPaises.Count == 0)
        {
            IniciarLista();
            return ListaPaises;
        }
        return ListaPaises; 
    }

    public static Pais DetallePais(string Nombre)
    {
        foreach(Pais busqueda in ListaPaises)
        {
            if(busqueda.Nombre == Nombre)
            {
                return busqueda;
            }
        }
        return null;
        
    }
}