public static class Info
{
    static List <Pais> ListaPaises = new List<Pais>();

    public static void  IniciarLista()
    {
        
        ListaPaises.Add(new Pais("Argentina", imgBandera, 1000, , "Ushuaia")) ;
        ListaPaises.Add(new Pais("Brasil", imgBandera, 1200, fechaIndependencia, "Cataratas"));
        ListaPaises.Add(new Pais("Chile", imgBandera, 800, fechaIndependencia, "Cordillera de los Andes"));
        ListaPaises.Add(new Pais("Uruguay", imgBandera, 900, fechaIndependencia, "Montevideo"));
        ListaPaises.Add(new Pais("Bolivia", imgBandera, 500, fechaIndependencia, "La Paz"));
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