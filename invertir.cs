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


