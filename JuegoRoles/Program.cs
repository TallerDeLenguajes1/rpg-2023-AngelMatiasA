using System;
using EspacioFabrica;  
using EspacioPersonaje; 
using EspacioGamePlay;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreArchivo = "juegoPrueba.txt";
            Personaje ganador = new Personaje(); 
            FabricaDePersonajes perFab = new FabricaDePersonajes(); 
            GamePlay juegoNuevo = new GamePlay();  
            ganador = juegoNuevo.jugar(nombreArchivo); 

            Console.WriteLine("¡¡¡EL JUEGO TERMINO!!! \n \n ************** \n \n************\n \t\t*****"); 
            Console.WriteLine("presione una tecla para continuar "); 
            Console.ReadKey(); 
            Console.WriteLine("EL GANADOR ES DE TODO EL TORNEO ES  \n \n ************** \n \t "); 
            perFab.mostrarPersonaje(ganador);



                 
            
        }
    }
}