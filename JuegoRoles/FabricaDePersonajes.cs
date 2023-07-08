using System;
using EspacioPersonaje;

namespace EspacioFabrica // Note: actual namespace depends on the project name.
{
    public class FabricaDePersonajes
    {  
     
    
       public string [] apodo = {"luchon", "guerrero", "zeus"};
       string [] nombress = {"pepe", "juan", "phoenix"}; 

      

       
   

        
      

       public Personaje CrearPersonaje(){

          Personaje pers = new Personaje(); 

            Random r = new Random(); 
            pers.Apodo= apodo[r.Next(0, 2)]; 
            pers.Nombre = nombress[r.Next(0, 2)];
            pers.Armadura = r.Next(1, 10); 
            pers.Destreza = r.Next(1, 5); 
            pers.Nivel = r.Next(1, 10); 
            pers.Velocidad = r.Next(1, 10);
            pers.Fuerza = r.Next(1, 10);

          

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
            Console.WriteLine(" \n \t \t ********************** \n ");

        }

        //  public FabricaDePersonajes() {

        // }
        
    }
}