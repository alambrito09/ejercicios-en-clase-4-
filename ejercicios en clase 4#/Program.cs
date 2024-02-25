Console.WriteLine("parte 1 ejercicio 1#");
for (int numero = 2; numero <= 10; numero += 2)
{

    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
    }
}
Console.WriteLine("ejercicio 2#");
int suma = 0;

for (int i = 1; i <= 10; i++)
{

    suma += i;
}


Console.WriteLine("La suma de los primeros 10 numeros naturales es: " + suma);

Console.WriteLine("enunciado 2 ejercicio 1#");

                  int suma1 = 0;

int numero1;


do
{

    Console.WriteLine("Ingrese un número entero positivo (o un número negativo para terminar): ");
    numero1 = int.Parse(Console.ReadLine());


    if (numero1 > 0)
    {
        suma1 += numero1;
    }
} while (numero1 > 0);

Console.WriteLine("La suma de los números ingresados es: " + suma1);

Console.WriteLine("ejercicio 2 enuciado 2#");
int numero3 = 1;


while (numero3 % 7 != 0 || numero3 % 11 != 0)
{

    numero3++;
}
Console.WriteLine("El primer número divisible entre 7 y 11 es: " + numero3);


Console.WriteLine("enenuciado 3 ejercicio 1#");
string contra = "jutiapa";


string contraseña;


do
{

    Console.WriteLine("Ingrese la contraseña: ");
    contraseña = Console.ReadLine();

} while (contraseña != contra);


Console.WriteLine("Contraseña correcta!");



