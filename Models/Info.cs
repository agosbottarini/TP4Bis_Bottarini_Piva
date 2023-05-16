public static class Info
{
    static List <Pais> ListaPaises = new List<Pais>();

    public static void  IniciarLista()
    {  
        ListaPaises.Add(new Pais("Argentina", "argentina.jpg", 1000, new DateTime (1816, 7, 9), "Ushuaia")) ;
        ListaPaises.Add(new Pais("Brasil", "brasil.jpg", 1200, new DateTime (1822, 9, 7), "Cataratas"));
        ListaPaises.Add(new Pais("Chile", "chile.jpg", 800, new DateTime (1818, 2, 12), "Cordillera de los Andes"));
        ListaPaises.Add(new Pais("Uruguay", "uruguay.jpg", 900, new DateTime (1825, 8, 25), "Montevideo"));
        ListaPaises.Add(new Pais("Bolivia", "bolivia.jpg", 500, new DateTime (1825, 8, 6), "La Paz"));
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