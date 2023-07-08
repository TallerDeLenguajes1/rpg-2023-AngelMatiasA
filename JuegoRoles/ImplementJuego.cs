using System;
using EspacioFabrica;
using EspacioPersonaje;
using EspacioPersJson;

namespace ImplementacionJuego;

public class ImplementJuego
{
    bool valido = false;

    public void implementar(string nombreArchivo)
    {
        PersonajesJson psjJ = new PersonajesJson();
        FabricaDePersonajes nuevaFabrik = new FabricaDePersonajes();
        Personaje pjNuevo;
        List<Personaje> persList ;
        if (psjJ.Existe(nombreArchivo) && psjJ.LeerPersonajes(nombreArchivo).Count > 0)
        {
            persList = psjJ.LeerPersonajes(nombreArchivo);

            /*Bandera p ver si existe el arch y tiene 10 jug*/
            valido = true;
            foreach (var pj in persList)
            {
                nuevaFabrik.mostrarPersonaje(pj);

            }

        }
        /* Si no existe el archivo crearlo y guuardarle 10 persj*/
        else
        {
            persList = new List<Personaje>();
            for (int i = 0; i < 10; i++)
            {
                pjNuevo = nuevaFabrik.CrearPersonaje();
                persList.Add(pjNuevo);
                
            }
            psjJ.GuardarPersonajes(persList, nombreArchivo);
             
             foreach (var pj in persList)
            {
                nuevaFabrik.mostrarPersonaje(pj);

            }

        }


    }

}