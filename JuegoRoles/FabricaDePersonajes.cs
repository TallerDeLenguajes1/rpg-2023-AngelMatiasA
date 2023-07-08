using System;
using EspacioPersonaje;

namespace EspacioFabrica // Note: actual namespace depends on the project name.
{
    public class FabricaDePersonajes
    {  
     
    
       public string [] apodo = {"luchon", "guerrero", "zeus", "phoenix ", " ninja"};
       string [] nombress = {"Pepe", "Juan","Pedro", "Juana", "Miguel"}; 

      

       
   

        
      

       public Personaje CrearPersonaje(){

          Personaje pers = new Personaje(); 

            Random r = new Random(); 
            pers.Apodo= apodo[r.Next(0, 5)]; 
            pers.Nombre = nombress[r.Next(0, 5)];
            pers.Armadura = r.Next(1, 11); 
            pers.Destreza = r.Next(1, 6); 
            pers.Nivel = r.Next(1, 11); 
            pers.Velocidad = r.Next(1, 11);
            pers.Fuerza = r.Next(1, 11);

          

            return pers;
        }
        public void mostrarPersonaje( Personaje persj){
            Console.WriteLine($"Nombre : {persj.Nombre} ");
            Console.WriteLine($"Apodo : {persj.Apodo} ");
            Console.WriteLine($"Armadura : {persj.Armadura} ");
            Console.WriteLine($"Destreza : {persj.Destreza} ");
            Console.WriteLine($"Nivel : {persj.Nivel} ");
            Console.WriteLine($"Velocidad : {persj.Velocidad} ");
            Console.WriteLine($"Fuerza : {persj.Fuerza} ");
             Console.WriteLine($"Salud : {persj.Salud} ");
            Console.WriteLine(" \n \t \t ********************** \n ");

        }

        //  public FabricaDePersonajes() {

        // }
        
    }
}