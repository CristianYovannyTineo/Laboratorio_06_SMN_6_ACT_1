// See https://aka.ms/new-console-template for more information

//En la tiendita de Don Mariano se quiere implementar un sistema que permita controlar el aforo de
//las personas que asisten al local, porque nos encontramos en pandemia, diseñe un programa en
//consola que permita llevar el control de asistentes en esta bodega, teniendo en cuenta que Don
//Mariano debe ingresar el número máximo de asistentes, y la gente puede entrar y salir del local.

//Sesion 1
//Indicar la Cantidad Maxima de Personas:
int asistentesPresentes = 0;
int Ingresos = 0;
int Salidas = 0;
int Lleno = 0;
int Vacio = 0;
Console.Write("Ingrese el número máximo de personas: ");
int maxPersonas = int.Parse(Console.ReadLine());
Console.WriteLine("===========================================");
Console.Write("El numero maximo establecido es de " + maxPersonas + " personas, presione un tecla para comenzar a contar_ ");
//Tipo de dato que almacenara en la lista
List<int> historialIngresos = new List<int>();
List<int> historialSalidas = new List<int>();
Console.ReadKey();
Console.Clear(); // Console.Clear "Reinicia la Pantalla"

//Sesion 2

Console.WriteLine("=================================");
Console.WriteLine("| Asistentes actuales | 0");
Console.WriteLine("| Aforo               | 0%");
Console.WriteLine("| Máximo              | " + maxPersonas + " personas");
Console.WriteLine("=================================");
Console.WriteLine("Presione");
Console.WriteLine("[i] si ingresa una persona");
Console.WriteLine("[s] si sale una persona");
Console.WriteLine("[x] para terminar");
Console.ReadKey();
Console.Clear();

while (true)
{
    //Sesion 3
    Console.WriteLine("=================================");
    Console.WriteLine("| Asistentes actuales | " + asistentesPresentes );
    double aforo = (double)asistentesPresentes / maxPersonas * 100;
    Console.WriteLine("| Aforo               | " + aforo + "%");
    Console.WriteLine("| Máximo              | " + maxPersonas + " personas");
    Console.WriteLine("=================================");
    Console.WriteLine("Presione");
    Console.WriteLine("[i] si ingresa una persona");
    Console.WriteLine("[s] si sale una persona");
    Console.WriteLine("[x] para terminar");

    char opciones = Console.ReadKey().KeyChar;
    Console.Clear();

    if (asistentesPresentes == maxPersonas)
    {
        Lleno++;
    }
    else if (asistentesPresentes == 0)
    {
        Vacio++;
    }
    //Sesion 4
    switch (opciones)
    {
        case 'i':
            if (asistentesPresentes < maxPersonas)
            {
                asistentesPresentes++;
                Ingresos++;
                historialIngresos.Add(Ingresos);
            }
            break;
        case 's':
            if (asistentesPresentes > 0)
            {
                asistentesPresentes--;
                Salidas++;
                historialSalidas.Add(Salidas);
            }
            break;
        case 'x':
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("El programa ha terminado");
            Console.WriteLine("=================================");
            Console.WriteLine("Estadísticas:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(Ingresos+ " personas ingresaron");
            Console.WriteLine(Salidas + " personas salieron");
            Console.WriteLine(Lleno   + " veces se llenó el local");
            Console.WriteLine("Estuvo vacío " + Vacio + " veces.");
            return;
        default:
            break;
    }

}


