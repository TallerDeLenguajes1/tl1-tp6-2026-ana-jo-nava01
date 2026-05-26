string entrada;
int num = 0;

Console.WriteLine("Ingrese el numero a invertir: ");
entrada = Console.ReadLine();

if(!int.TryParse(entrada, out num))
{
    Console.WriteLine("La entrada ingresada no es un numero.");
} else
{
    if(num <= 0)
    {
        Console.WriteLine("El numero es menor o igual que 0");
    } else
    {
        int invertido = 0;
        while(num > 0)
        {
            int dig = num % 10;
            invertido = (invertido * 10) + dig;
            num = num / 10;
        }
        Console.WriteLine($"Numero invertido: {invertido}");
    }
}

//Ejercicio 4
string cadena, cadena2;

Console.WriteLine("Ingrese la primera cadena: ");
cadena = Console.ReadLine();

int longitud = cadena.Length;

Console.WriteLine($"Longitud de la cadena: {longitud}");

Console.WriteLine("Ingrese la segunda cadena: ");
cadena2 = Console.ReadLine();

string concat = cadena + cadena2;

Console.WriteLine($"Concatenado: {concat}");

string subst = cadena.Substring(0, 2);

Console.WriteLine($"Subcadena extraida: {subst}");