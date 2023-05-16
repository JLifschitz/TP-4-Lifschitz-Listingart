using System.Collections.Generic;
public static class Equipos
{
    public static List<string> ListaEquipos {get; private set;} = new List<string> {"River","Sacachispas","Defensa y Justicia", "Atletico Tucuman", "Racing", "Estudiantes de rio cuarto", "Velez", "Rosario Central", "San Lorenzo", "All boys"};
    public static List<string> ListaMedias {get; private set;} = new List<string> {"medias1.jpg", "medias2.jpg", "medias3.jpg", "medias4.jpg", "medias5.jpg", "medias6.jpg", "medias7.jpg", "medias8.jpg", "medias9.jpg", "medias10.jpg"};
    public static List<string> ListaPantalones {get; private set;} = new List<string> {"pantalon1.jpg", "pantalon2.jpg","pantalon3.jpg", "pantalon4.jpg", "pantalon5.jpg", "pantalon6.jpg", "pantalon7.jpg", "pantalon8.jpg", "pantalon9.jpg", "pantalon10.jpg"};
    public static List<string> ListaRemeras {get; private set;} = new List<string> {"remera1.jpg", "remera2.jpg", "remera3.jpg", "remera4.jpg", "remera5.jpg", "remera6.jpg", "remera7.jpg", "remera8.jpg", "remera9.jpg", "remera10.jpg"};
    public static Dictionary<string, Indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary<string, Indumentaria>();

    public static bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item)
    {
        bool devolver = false;
        if (EquiposIndumentaria.ContainsKey(equipoSeleccionado))
        {
          devolver = true;  
        } 
        else 
        {
            EquiposIndumentaria.Add(equipoSeleccionado, item);
            devolver = false;
        }
        return devolver;
    }
}