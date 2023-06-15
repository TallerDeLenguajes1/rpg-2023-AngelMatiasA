using System;

namespace EspacioPersonaje // Note: actual namespace depends on the project name.
{
    public class Personaje
    {
        
        private string? nombre; 
        private string? apodo; 
        private int velocidad;//1a10
        private int destreza;//1a5
        private int nivel;//1a10
        private int armadura;//1a10
        private int salud = 100;//100 
        private DateTime fecha_nacimiento;
 
        public Personaje(){
          
        }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apodo { get => apodo; set => apodo = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int Salud { get => salud; set => salud = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
    }
}