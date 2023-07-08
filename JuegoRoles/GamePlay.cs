using System;
using EspacioFabrica;
using EspacioPersonaje;
using ImplementacionJuego;

namespace EspacioGamePlay;
public class GamePlay
{
    Random R = new Random();
    /*1) Elija 2 personajes para que compitan entre ellos.
    2) El combate se realiza por turnos. Por cada turno un personaje ataca y el otro se
defiende.
    3) El combate se mantiene hasta que uno es vencido (salud <= 0)
    4) El personaje que pierde la batalla será eliminado de la competencia
    5) El que gane será beneficiado con una mejora en sus habilidades.
por ejemplo: +10 en salud o +5 en defensa. */

    public Personaje jugar(string nombreArchivo)
    {

        Personaje ganador = new Personaje();
        Personaje p1 = new Personaje();
        Personaje p2 = new Personaje();
        
        int indice = 0;
        int indice2 = 0;
        int largo = 0;

        ImplementJuego psJ = new ImplementJuego();
        List<Personaje> listaJugadores = psJ.implementar(nombreArchivo);
        bool final = false;

        do
        { //x cada vuelta obtengo el lago d la lista si es q le ire elimenando dsp
            largo = listaJugadores.Count;

            if (largo == 10)
            {//si es la primera vuelta q se jugara,
             // ya que ire eliminando los jugadores de la lista original
                do
                {
                    indice = R.Next(0, largo - 1);
                    p1 = listaJugadores[indice];
                    indice2 = R.Next(0, largo - 1);
                    p1 = listaJugadores[indice2];
                   

                } while (indice == indice2);
                 listaJugadores.Remove(p1); 
                    listaJugadores.Remove(p2); 
                    //los saco d la lista para no volver a repetir
                    ganador = Combate(p1, p2);


            }
            else//en el caso que no sea el primer juego
            {
                indice = R.Next(0, largo - 1); 
                if(ganador== p1){
                    
                    p2= listaJugadores[indice];
                    listaJugadores.Remove(p2);


                }
                else
                {
                     p1= listaJugadores[indice];
                      listaJugadores.Remove(p1);
                    
                }
                ganador = Combate(p1, p2);

            }






        } while (!final);



        return ganador;

    }

    private  Personaje Combate ( Personaje p1, Personaje p2){
        Personaje ganador = new Personaje();
        int turno = 0; 
          
        turno = R.Next(1,2);
        do
        {
            if (turno ==1)
            {
                p2.Salud -= danioProvocado(p1, p2);
                ganador = p1;// el que pegue al ultimo gana
                turno++;
                
            }
            else
            {
                p1.Salud -= danioProvocado(p1, p2);
                ganador = p2;
                turno--;
            }
            
        } while (p1.Salud >0 && p2.Salud >0 );
        Console.WriteLine($"\t GANADOR DEL COMBATE \n  \t JUGADOR NOMBRE: {ganador.Nombre} \n \t APODO: {ganador.Apodo}");

        return ganador;
    }
    private  int danioProvocado ( Personaje ataca, Personaje defiende){
        int danio=0;
        int Ataque = ataca.Destreza* ataca.Fuerza * ataca.Nivel;


        return danio;

    }


}