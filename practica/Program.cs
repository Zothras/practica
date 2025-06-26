using practica;
using System.Diagnostics.Contracts;
List<Evento> eventos = new();


void CreacionDeEventos()
{
    Evento evento = null;
    Console.WriteLine(@"Tipo de evento:
1. Evento
2. Conferencia
3. Taller");
    int Tipo = int.Parse(Console.ReadLine());
    switch (Tipo)
    {
        case 1:
            evento = new Evento();
            break;
        case 2:
            evento = new Conferencia();
            break;
        case 3:
            evento = new Taller();
            break;

        default:
            break;
    }
    Console.WriteLine("Ingrese el nombre");
    evento.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la fecha");
    evento.Fecha = Console.ReadLine();
    Console.WriteLine("Ingrese la ubicacion");
    evento.Ubicacion = Console.ReadLine();
    if (Tipo == 2)
    {
        Console.WriteLine("Ingresa el tema principal");
        (evento as Conferencia).Principal = Console.ReadLine();
    }
    if (Tipo == 3)
    {
        Console.WriteLine("Ingresa la capacidad maxima");
        (evento as Taller).CapacidadMaxima = int.Parse(Console.ReadLine());
    }
    eventos.Add(evento);

}

void ListaDeEventos()
{
    int i = 1;
    foreach (var Listita in eventos)
    {
       Console.WriteLine($" ¨({i++}, {Listita.obtener_descripcion()})");
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
        taller.Inscribir_Participante(participante);
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
                participante.obtener_nombre_completo();
            }
            return;
        }
    }
}
void MostrarEvento(Evento evento)
{
    Console.WriteLine(evento.obtener_descripcion());
    foreach (var p in evento.Participante)
        Console.WriteLine(p.obtener_nombre_completo());
}
void InscribirParticipantes()
{
    Console.WriteLine("ingrese algun dato del evento al que va a asistir");
    string dato = Console.ReadLine();
    var eventoFiltrados = eventos.Where(x => x.obtener_descripcion().Contains(dato)).ToArray();
    int i = 1;
    foreach(Evento e in eventoFiltrados)
    {
        Console.WriteLine($"{i++}. {e.obtener_descripcion()}");

    }
    Console.WriteLine("Seleccione el evento");
    int idEvento = int.Parse(Console.ReadLine());
    var evento = eventoFiltrados
}

int menusalir = 0;


do
{

    Console.WriteLine("Elija una opcion que quiere hacer");
    string Menu;
    Menu = Console.ReadLine();
    Console.WriteLine("Toque una tecla para continuar");
    Console.ReadKey();
    switch (Menu)
{
    case "Crear Evento":
        CreacionDeEventos(taller);
        Console.ReadKey();
        break;

    case "Listar Eventos":
        ListaDeEventos();
        Console.ReadKey();
        break;

    case "Buscar Eventos (y ver participantes)":
        BuscarEvento();
        Console.ReadKey();
        break;

    case "Inscribir Participantes":
        InscribirParticipante(taller);
        Console.ReadKey();
        break;

    case "Ver los eventos de hoy":

        break;
        case "Salir":
            menusalir = 99;
            break;
}
} while (menusalir!=99);
Console.ReadKey();