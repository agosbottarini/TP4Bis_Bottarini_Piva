public static class Info
{
    static List <Pais> ListaPaises = new List<Pais>();

    public static void  IniciarLista()
    {
        
        ListaPaises.Add(new Pais("Argentina", "argentina.jpg", 1000, new DateTime (9/7/1816) , "Ushuaia")) ;
        ListaPaises.Add(new Pais("Brasil", "brasil.jpg", 1200, new DateTime (7/9/1822), "Cataratas"));
        ListaPaises.Add(new Pais("Chile", "chile.jpg", 800, new DateTime (12/2/1818), "Cordillera de los Andes"));
        ListaPaises.Add(new Pais("Uruguay", "uruguay.jpg", 900, new DateTime (25/8/1825), "Montevideo"));
        ListaPaises.Add(new Pais("Bolivia", "bolivia.jpg", 500, new DateTime (6/8/1825), "La Paz"));

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