using System;
using EspacioFabrica;  
using EspacioPersonaje;   
using System.Text.Json;

using System.IO;


namespace EspacioPersJson // Note: actual namespace depends on the project name.
{
    public class PersonajesJson
    {
        public void GuardarPersonajes( List<Personaje> listaPersonaje , string nombreArchivo){ 
            string json = JsonSerializer.Serialize(listaPersonaje); 
            File.WriteAllText(nombreArchivo, json);
                
            
        }
        
        public  List<Personaje>  LeerPersonajes (string nombreArchivo){ //deserializacion

             string json = File.ReadAllText(nombreArchivo);
             List<Personaje> listPers= JsonSerializer.Deserialize<List<Personaje>>(json);
             return listPers;
          
        }

        public bool Existe( string nombre){
            bool existe;
            if (File.Exists(nombre) &&  File.ReadAllText(nombre)!=null)
            { 
                existe = true;
               
                
            }
            else
            {
                existe = false;
            } 
            return existe;
        }






    }
}