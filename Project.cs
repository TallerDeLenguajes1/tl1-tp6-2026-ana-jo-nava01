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

int opcion;
do
{
    Console.WriteLine("==Calculadora==");
    Console.Write("==Operaciones entre 2 numeros==");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    opcion = int.Parse(Console.ReadLine());

    if(opcion < 1 || opcion > 4)
    {
        Console.WriteLine("Error");
    }
}while(opcion < 1 || opcion > 4);

int num1;
int num2;

Console.WriteLine("Ingrese el primer numero: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
num2 = int.Parse(Console.ReadLine());

int resultado;
string resul;
switch(opcion)
{
    case 1: //Suma
        resultado = num1 + num2;
        resul = resultado.ToString();
        Console.WriteLine($"Resultado = {resul}");
        break;
    case 2: //Resta
        resultado = num1 - num2;
        resul = resultado.ToString();
        Console.WriteLine($"Resultado = {resul}");
        break;
    case 3: //Multiplicacion
        resultado = num1 * num2;
        resul = resultado.ToString();
        Console.WriteLine($"Resultado = {resul}");
        break;
    case 4: //Division
        resultado = num1 / num2;
        resul = resultado.ToString();
        Console.WriteLine($"Resultado = {resul}");
        break;
    default:
        resultado = 0;
        resul = resultado.ToString();
        break;
}

foreach(char elem in resul)
{
    Console.WriteLine(elem);
}

string str, buscada;

Console.WriteLine("Ingrese una string: ");
str = Console.ReadLine();

Console.WriteLine("Ingrese la palabra buscada: ");
buscada = Console.ReadLine();

int indice = str.IndexOf(buscada);
Console.WriteLine($"Palabra encontrada en la posicion: {indice}");

Console.WriteLine($"String en mayusculas: {str.ToUpper()}");
Console.WriteLine($"String en minusculas: {str.ToLower()}");

string split;
Console.WriteLine("Ingrese cadena separada por punto y coma: ");
split = Console.ReadLine();
string[] separada = split.Split(';');

foreach(string palabra in separada)
{
    Console.WriteLine($"{palabra}");
}

char[] operadores = ['+', '-', '*', '-'];
Console.WriteLine("Ingrese la ecuacion: ");
string ecuacion = Console.ReadLine();

string[] operandos = ecuacion.Split(operadores);
int operando1, operando2;
if(int.TryParse(operandos[0], out operando1) && int.TryParse(operandos[1], out operando2))
{
    int total;
    if(ecuacion.IndexOf('+') != -1)
    {
        total = operando1 + operando2;
    } else if(ecuacion.IndexOf('-') != -1)
    {
        total = operando1 - operando2;
    } else if(ecuacion.IndexOf('*') != -1)
    {
        total = operando1 * operando2;
    } else if(ecuacion.IndexOf('/') != -1)
    {
        total = operando1 / operando2;
    } else
    {
        total = -999;
    }

    Console.WriteLine($"Resultado = {total}");
} else
{
    Console.WriteLine("Error");
}