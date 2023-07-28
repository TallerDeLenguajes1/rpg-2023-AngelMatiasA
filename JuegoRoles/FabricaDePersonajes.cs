using System;
using EspacioPersonaje;
using Api;

namespace EspacioFabrica // Note: actual namespace depends on the project name.
{
    public class FabricaDePersonajes
    {  
    //  int anio = 0; 
    //  int mes = 0;
    //  int dia = 0;
    
       public string [] apodo = {"luchon", "guerrero", "zeus", "phoenix ", " ninja"};
       string [] nombress = {"Pepe", "Juan","Pedro", "Juana", "Miguel"}; 
       string [] nombreApi;

      

       
   

        
      

       public Personaje CrearPersonaje(){

          Personaje pers = new Personaje(); 

            Random r = new Random(); 
            pers.Apodo= apodo[r.Next(0, 5)]; 
          
            pers.Nombre = obtenerNombre();
            pers.Armadura = r.Next(1, 11); 
            pers.Destreza = r.Next(1, 6); 
            pers.Nivel = r.Next(1, 11); 
            pers.Velocidad = r.Next(1, 11);
            pers.Fuerza = r.Next(1, 11);
            int anio = r.Next(1723,2024);
            int mes = r.Next(1,13);
            int dia = r.Next(1,29);
              pers.fecha_nacimiento = new DateTime(anio, mes, dia);
        pers.Edad = CalcularEdad(pers.fecha_nacimiento);
          

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
              Console.WriteLine($"edad : {persj.Edad} ");
              Console.WriteLine("nombre opcional : " + obtenerNombre());

          
            Console.WriteLine(" \n \t \t ********************** \n ");

        }

        public static int CalcularEdad(DateTime fechaNacimiento)
    {
        int edad = 0;
        DateTime fechaActual = DateTime.Now;
         edad = fechaActual.Year - fechaNacimiento.Year;

        if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
        {
            edad--;
        }
        return edad;
    }
    public string obtenerNombre (){
          Random ran = new Random(); 
       
        string nombre = " ";  
        NombresApi nuevoNombre = new NombresApi() ;
       nombreApi=  nuevoNombre.getNombres();
        int random = ran.Next(nombreApi.Length);
       nombre = nombreApi[random];

        return nombre;
    }

        
    }
}