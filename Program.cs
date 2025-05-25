// Console.WriteLine("Hello, World!");

// int i;
// int j = 0;
// int[] invertido = new int[10];  
// string numero = Console.ReadLine();
// bool resultado = int.TryParse(numero, out i);
// int copia = i;

// if (resultado && i > 0)
// {

//     while (i > 0)
//     {

//         i /= 10;

//         j++;
//     }
//     Console.Write("Numero invertido: ");
//     for (int k = 0; k < j; k++)
//     {
//         invertido[k] = copia % 10;
//         Console.Write(invertido[k]);
//         copia /= 10;
//     }
// }


int numero;
do
{
    Console.WriteLine("-----------Menu---------");
    Console.WriteLine("1_Suma");
    Console.WriteLine("2_Resta");
    Console.WriteLine("3_Division");
    Console.WriteLine("4_Multiplicacion");
    Console.WriteLine("Escriba 0 para salir");

    Console.WriteLine("Ingrese un numero para elegir la operacion");
    string opcion = Console.ReadLine() ?? "";

    bool control = int.TryParse(opcion, out numero);

    Console.WriteLine("Ingrese el primer numero");
    string numero1 = Console.ReadLine() ?? "";
    float a;
    bool control2 = float.TryParse(numero1, out a);

    Console.WriteLine("Ingrese el segundo numero");
    string numero2 = Console.ReadLine() ?? "";
    float b;
    bool control3 = float.TryParse(numero2, out b);



    switch (numero)
    {
        case 1:
            suma(a, b); 
            break;
        case 2:
            resta(a, b);
            break;
        case 3:
            division(a, b);
            break;
        case 4:
            multiplicacion(a, b);
            break;
        default:
            Console.WriteLine("Ingrese un numero valido");
            break;
    }

} while (numero != 0);

void suma(float a, float b)
{
    float total = a + b;
    Console.WriteLine("El resultado de la suma es: " + total);

}

void resta(float a, float b)
{
    float total = a - b;
    Console.WriteLine("El resultado de la resta es: " + total);

}

void division(float a, float b)
{
    float total = a / b;
    Console.WriteLine("El resultado de la division de a/b es: " + total);

}

void multiplicacion(float a, float b)
{
    float total = a * b;
    Console.WriteLine("El resultado de la multiplicion es: " + total); 

}