using practica;
using System.Diagnostics.Contracts;

List<Evento> eventos = new();



void CreacionDeEventos(Evento evento)
{
    Taller taller = new Taller();
    if (taller.CapacidadMaxima == null)
    {
        Console.WriteLine("Ingrese la capacidad maxima del evento");
        taller.CapacidadMaxima = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("");
    Console.WriteLine("Ingrese el nombre del evento");
    evento.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la fecha del evento");
    evento.Fecha = Console.ReadLine();
    Console.WriteLine("Ingrese la ubicacion del evento");
    evento.Ubicacion = Console.ReadLine();
    eventos.Add(evento);
}

void ListaDeEventos()
{
    foreach (var Listita in eventos)
    {
        Console.WriteLine($" {Listita}");
    }
}

void InscribirParticipante(Taller taller)
{ 
    Participante participante = new Participante();
    int cantparticipantes = 0;
    if (cantparticipantes<=taller.CapacidadMaxima)
    {
        Console.WriteLine("Ingrese el nombre del participante");
        participante.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido del participante");
        participante.Apellido = Console.ReadLine();
        taller.Participante.Add(participante);
        cantparticipantes = cantparticipantes + 1;

    }
    else
    {
        Console.WriteLine("Hay un dicho en este planeta... tonto como una piedra... no es un cumplido.");
    }

}

void BuscarEvento()
{
    foreach (var Buscar in eventos)
    {
        Console.WriteLine("Ingrese el nombre del evento que desea buscar");
        string nombreEvento = Console.ReadLine();
        if (Buscar.Nombre.Equals(nombreEvento))
        {
            Console.WriteLine($"Evento encontrado: {Buscar.Nombre}, Fecha: {Buscar.Fecha}, Ubicacion: {Buscar.Ubicacion}");
            Console.WriteLine("Participantes:");
            foreach (var participante in Buscar.Participante)
            {
                Console.WriteLine($" - {participante.Nombre} {participante.Apellido}");
            }
            return;
        }
    }
}

string Menu;
Menu = Console.ReadLine();
switch (Menu)
{
    case "Crear Evento":

        break;

    case "Listar Eventos":

        break;

    case "Buscar Eventos (y ver participantes)":

        break;

    case "Inscribir Participantes":

        break;

    case "Ver los eventos de hoy":

        break;

}