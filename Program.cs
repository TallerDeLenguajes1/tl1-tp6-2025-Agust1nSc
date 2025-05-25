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
    Console.WriteLine("5_Valor absoluto");
    Console.WriteLine("6_El cuadrado de un numero");
    Console.WriteLine("7_La raiz de ese numero");
    Console.WriteLine("8_El seno");
    Console.WriteLine("9_El coseno");
    Console.WriteLine("10_Parte entera de un float");
    Console.WriteLine("Escriba 0 para salir");

    Console.WriteLine("Ingrese un numero para elegir la operacion");
    string opcion = Console.ReadLine() ?? "";

    bool control = int.TryParse(opcion, out numero);

    if (!control) 
    {
        Console.WriteLine("Debe ingresar un número válido para seleccionar una opción."); 
        continue;
    }

    if (numero == 0) break;

    Console.WriteLine("Ingrese el primer numero");
    string numero1 = Console.ReadLine() ?? "";
    float a;
    bool control2 = float.TryParse(numero1, out a);

    if (!control2) 
    {
        Console.WriteLine("Debe ingresar un número válido para el valor de a."); 
        continue;
    }

    Console.WriteLine("Ingrese el segundo numero");
    string numero2 = Console.ReadLine() ?? "";
    float b;
    bool control3 = float.TryParse(numero2, out b);

     if (!control3) 
    {
        Console.WriteLine("Debe ingresar un número válido para el valor de b."); 
        continue;
    }



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
        case 5:
            valorAbsoluto(a, b);
            break;
        case 6:
            cuadrado(a, b);
            break;
        case 7:
            raiz(a, b);
            break;
        case 8:
            seno(a, b);
            break;
        case 9:
            coseno(a, b);
            break;

        case 10:
            parteEntera(a, b);

            break;
        default:
            Console.WriteLine("Ingrese un numero valido");
            break;
    }

    numeroMaximo(a, b);

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

void valorAbsoluto(float a, float b)
{
    if (a < 0)
    {
        float total = a * -1;
        Console.WriteLine("El resultado del valor absoluto de a es: " + total);
    }
    else
    {
        Console.WriteLine("El resultado del valor absoluto de a es: " + a);
    }

    if (b < 0)
    {
        float total2 = b * -1;
        Console.WriteLine("El resultado del valor absoluto de a es: " + total2);
    }
    else
    {
        Console.WriteLine("El resultado del valor absoluto de a es: " + b);
    }


}

void cuadrado(float a, float b)
{
    Console.WriteLine("El resultado del cuadrado de a es: " + a * a);
    Console.WriteLine("El resultado del cuadrado de b es: " + b * b);


}

void seno(float a, float b)
{
    Console.WriteLine("El resultado del seno de a es: " + Math.Sin(a));
    Console.WriteLine("El resultado del seno de b es: " + Math.Sin(b));

}

void coseno(float a, float b)
{
    Console.WriteLine("El resultado del coseno de a es: " + Math.Cos(a));
    Console.WriteLine("El resultado del coseno de b es: " + Math.Cos(b));

}

void raiz(float a, float b)
{

    if (a > 0)
    {
        Console.WriteLine("La raiz de a es: " + Math.Sqrt(a));
    }
    else
    {
        Console.WriteLine("a es menor que 0");
    }

    if (b > 0)
    {
        Console.WriteLine("La raiz de b es: " + Math.Sqrt(b));
    }
    else
    {
        Console.WriteLine("b es menor que 0");
    }

}

void parteEntera(float a, float b)
{

    Console.WriteLine("Parte entera de a: " + (int)a);
    Console.WriteLine("Parte entera de b: " + (int)b);

}

void numeroMaximo(float a, float b)
{

    float numeroMasGrande;
    float numeroMasChico;

    if (a > b)
    {
        numeroMasGrande = a;
        numeroMasChico = b;
        Console.WriteLine("Numero mas grande: " + numeroMasGrande);
        Console.WriteLine("Numero mas chico: " + numeroMasChico);
    }
    else if (b > a)
    {
        numeroMasGrande = a;
        numeroMasChico = b;
        Console.WriteLine("Numero mas grande: " + numeroMasGrande);
        Console.WriteLine("Numero mas chico: " + numeroMasChico);
    }
    else
    {
        Console.WriteLine("Ambos numeros son iguales");
    }

}
