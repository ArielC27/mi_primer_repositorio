var provs = new Dictionary<int, int>();
var parts = new Dictionary<int, int>();
int[] provincias = new int[] { 1, 4, 6, 8, 15, 21 };
int[] partidos = new int[] { 1, 2, 3, 4 };
int contadorVotosTotales = 0;

Console.Write("Ingrese su DNI: ");
var digitos = Console.ReadLine();
var esDniValido = int.TryParse(digitos, out var dni);

InicializarDiccionario(provincias, provs);
InicializarDiccionario(partidos, parts);

void InicializarDiccionario(int[] datos, Dictionary<int, int> diccionario)
{
    for (int i = 0; i < datos.Length; i++)
    {
        diccionario.Add(datos[i], 0);
    }
}


while (dni != 0)
{
    if (esDniValido && !string.IsNullOrEmpty(digitos) && digitos.Length == 8)
    {
        Console.Write("Ingrese la provincia (1, 4, 6, 8, 15, 21): ");
        var prov = int.TryParse(Console.ReadLine(), out var provUsuario);
        if (prov && provincias.Contains(provUsuario))
        {
            Console.Write("Ingrese el partido (1, 2, 3, 4): ");
            var part = int.TryParse(Console.ReadLine(), out var partUsuario);
            if (part && partidos.Contains(partUsuario))
            {
                parts[partUsuario] = parts[partUsuario] + 1;
                provs[provUsuario]++;
                Console.WriteLine("Tu voto ha sido valido!!!");
                contadorVotosTotales++;
            }
            else
            {
                Console.WriteLine("Datos incorrectos, vuelve a ingresar tu DNI");
            }
        }
        else
        {
            Console.WriteLine("Provincia incorrecta, vuelve a intentarlo");
        }
    }
    Console.Write("Ingrese su DNI:");
    esDniValido = int.TryParse(Console.ReadLine(), out dni);
}

//Consigna 1) Cantidad de votos emitidos en cada provincia
Console.WriteLine(InicializarDiccionario(diccionario));

Console.ReadKey();