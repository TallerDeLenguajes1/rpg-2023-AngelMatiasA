using System;
using EspacioFabrica;  
using EspacioPersonaje; 

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FabricaDePersonajes fp = new FabricaDePersonajes(); 
             
             Personaje pj = fp.CrearPersonaje();
             
          
            
        }
    }
}