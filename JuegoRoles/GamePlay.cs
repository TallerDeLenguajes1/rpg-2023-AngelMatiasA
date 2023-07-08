using System;
using EspacioFabrica;
using EspacioPersonaje;
using ImplementacionJuego;

namespace EspacioGamePlay;
public class GamePlay
{
    Random R = new Random();
    FabricaDePersonajes perFab = new FabricaDePersonajes();
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
        int combate = 1;


        ImplementJuego psJ = new ImplementJuego();
        List<Personaje> listaJugadores = psJ.implementar(nombreArchivo);
        bool final = false;
        largo = listaJugadores.Count;

        do
        { //x cada vuelta obtengo el lago d la lista si es q le ire elimenando dsp


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
                mensajeCombate(combate);
                
                ganador = Combate(p1, p2);


            }
            else//en el caso que no sea el primer juego
            {
                combate++; 
                  mensajeCombate(combate);

                indice = R.Next(0, largo - 1);
                if (ganador == p1)
                {
                    p1 = ganador;
                    p2 = listaJugadores[indice];
                    listaJugadores.Remove(p2);


                }
                else
                {
                    p1 = ganador;
                    p1 = listaJugadores[indice];
                    listaJugadores.Remove(p1);

                }

                ganador = Combate(p1, p2);

            }




            largo = listaJugadores.Count;

        } while (largo > 0);



        return ganador;

    }

    private Personaje Combate(Personaje p1, Personaje p2)
    {
        Personaje ganador = new Personaje();
        int turno = 0;
        int round = 0;
        int danio = 0;


        Console.WriteLine("\n*************** \n \t Se prepara para el combate \n \t **************");
        Console.WriteLine($"\t \t JUGADOR NOMBRE \t APODO {ganador.Apodo}");
        Console.WriteLine($"\t \t {p1.Nombre} \t APODO: {p1.Apodo}");
        Console.WriteLine($"\t \t VERSUS ");
        Console.WriteLine($"\t \t {p2.Nombre} \t APODO: {p2.Apodo}");


        turno = R.Next(1, 2);
        do
        {
            round++;
            Console.WriteLine("Round nro: " + round);

            if (turno == 1)
            {
                danio = danioProvocado(p1, p2);
                mensajeRound(p1, p2);
                p2.Salud -= danio;
                 Console.Write("SALUD: ");
                for (int i = 0; i < p2.Salud; i++)
                {
                    Console.Write('*');

                }
                

                
                ganador = p1;// el que pegue al ultimo gana
                turno++;

            }
            else
            {
                danio = danioProvocado(p2, p1);
                mensajeRound(p2, p1);
                 p1.Salud -= danio;
                Console.Write("SALUD: ");
                for (int i = 0; i < p1.Salud; i++)
                {
                    Console.Write('*');

                }

               
                ganador = p2;
                turno--;
            }

        } while (p1.Salud > 0 && p2.Salud > 0);
        ganador.Salud = 100; //restauro salud 
        if (turno == 1)// dependiendo del turno final beneficio d armor o salud
        {
            ganador.Salud += 10;
        }
        else
        {
            ganador.Armadura += 5;
        }
        Console.WriteLine($"\t GANADOR DEL COMBATE \n  \t JUGADOR NOMBRE: {ganador.Nombre} \n \t APODO: {ganador.Apodo}");
        perFab.mostrarPersonaje(ganador);


        return ganador;
    }
    private int danioProvocado(Personaje ataca, Personaje defiende)
    {
        int danio = 0;
        int Ataque = ataca.Destreza * ataca.Fuerza * ataca.Nivel;
        int efectivdad = R.Next(1, 100);
        int defensa = defiende.Armadura * defiende.Velocidad;
        const int AJUSTE = 500;

        danio = ((Ataque * efectivdad) - defensa) / AJUSTE;



        return danio;

    }

    private void mensajeRound(Personaje ataca, Personaje defiende)
    {
        Console.WriteLine($"se prepara para atacar {ataca.Nombre}, {ataca.Apodo}");
        Console.WriteLine($"\t\t ************** \n se prepara para defender {defiende.Nombre}, {defiende.Apodo}");
        Console.WriteLine($"\t Salud del defensor: {defiende.Nombre}, {defiende.Apodo}");
        Console.Write("SALUD: ");
        for (int i = 0; i < defiende.Salud; i++)
        {
            Console.Write('*');

        }
        Console.WriteLine("\n presione una tecla para atacar ");
        Console.ReadKey();




    }
      private void mensajeCombate(int numeroCombate)
    {
         Console.WriteLine($" Preparese para el Combate numero : {numeroCombate}");
                Console.WriteLine("presione una tecla para comenzar"); 
                Console.ReadKey();




    }

   


}