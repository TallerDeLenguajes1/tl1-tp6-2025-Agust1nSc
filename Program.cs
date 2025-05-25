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


// int numero;
// do
// {
//     Console.WriteLine("-----------Menu---------");
//     Console.WriteLine("1_Suma");
//     Console.WriteLine("2_Resta");
//     Console.WriteLine("3_Division");
//     Console.WriteLine("4_Multiplicacion");
//     Console.WriteLine("5_Valor absoluto");
//     Console.WriteLine("6_El cuadrado de un numero");
//     Console.WriteLine("7_La raiz de ese numero");
//     Console.WriteLine("8_El seno");
//     Console.WriteLine("9_El coseno");
//     Console.WriteLine("10_Parte entera de un float");
//     Console.WriteLine("Escriba 0 para salir");

//     Console.WriteLine("Ingrese un numero para elegir la operacion");
//     string opcion = Console.ReadLine() ?? "";

//     bool control = int.TryParse(opcion, out numero);

//     if (!control)
//     {
//         Console.WriteLine("Debe ingresar un número válido para seleccionar una opción.");
//         continue;
//     }

//     if (numero == 0) break;

//     Console.WriteLine("Ingrese el primer numero");
//     string numero1 = Console.ReadLine() ?? "";
//     float a;
//     bool control2 = float.TryParse(numero1, out a);

//     if (!control2)
//     {
//         Console.WriteLine("Debe ingresar un número válido para el valor de a.");
//         continue;
//     }

//     Console.WriteLine("Ingrese el segundo numero");
//     string numero2 = Console.ReadLine() ?? "";
//     float b;
//     bool control3 = float.TryParse(numero2, out b);

//     if (!control3)
//     {
//         Console.WriteLine("Debe ingresar un número válido para el valor de b.");
//         continue;
//     }

//     switch (numero)
//     {
//         case 1:
//             suma(a, b);
//             break;
//         case 2:
//             resta(a, b);
//             break;
//         case 3:
//             division(a, b);
//             break;
//         case 4:
//             multiplicacion(a, b);
//             break;
//         case 5:
//             valorAbsoluto(a, b);
//             break;
//         case 6:
//             cuadrado(a, b);
//             break;
//         case 7:
//             raiz(a, b);
//             break;
//         case 8:
//             seno(a, b);
//             break;
//         case 9:
//             coseno(a, b);
//             break;

//         case 10:
//             parteEntera(a, b);

//             break;
//         default:
//             Console.WriteLine("Ingrese un numero valido");
//             break;
//     }

//     numeroMaximo(a, b);

// } while (numero != 0);

// void suma(float a, float b)
// {
//     float total = a + b;
//     Console.WriteLine("El resultado de la suma de " + a.ToString() + " y b " + b.ToString() + " es: " + total.ToString());

// }

// void resta(float a, float b)
// {
//     float total = a - b;
//     Console.WriteLine("El resultado de la resta de " + a.ToString() + " y b " + b.ToString() + " es: " + total.ToString());

// }

// void division(float a, float b)
// {
//     float total = a / b;
//     Console.WriteLine("El resultado de la division de " + a.ToString() + " y b " + b.ToString() + " es: " + total.ToString());

// }

// void multiplicacion(float a, float b)
// {
//     float total = a * b;
//     Console.WriteLine("El resultado de la multiplicacion de " + a.ToString() + " y b " + b.ToString() + " es: " + total.ToString());

// }

// void valorAbsoluto(float a, float b)
// {
//     if (a < 0)
//     {
//         float total = a * -1;
//         Console.WriteLine("El resultado del valor absoludo de " + a.ToString() + " es: " + total.ToString());
//     }
//     else
//     {
//         Console.WriteLine("El resultado del valor absoluto de a es: " + a.ToString());
//     }

//     if (b < 0)
//     {
//         float total2 = b * -1;
//         Console.WriteLine("El resultado del valor absoludo de " + b.ToString() + "es: " + total2.ToString());
//     }
//     else
//     {
//         Console.WriteLine("El resultado del valor absoluto de b es: " + b.ToString());
//     }


// }

// void cuadrado(float a, float b)
// {
//     float total = a * a;
//     float total2 = b * b;

//     Console.WriteLine("El resultado del cuadrado de a es: " + total.ToString());
//     Console.WriteLine("El resultado del cuadrado de b es: " + total2.ToString());


// }

// void seno(float a, float b)
// {

//     double total = Math.Sin(a);
//     double total2 = Math.Sin(b);

//     Console.WriteLine("El resultado del seno de a es: " + total.ToString());
//     Console.WriteLine("El resultado del seno de b es: " + total2.ToString());


// }

// void coseno(float a, float b)
// {
//     double total = Math.Cos(a);
//     double total2 = Math.Cos(b);

//     Console.WriteLine("El resultado del seno de a es: " + total.ToString());
//     Console.WriteLine("El resultado del seno de b es: " + total2.ToString());

// }

// void raiz(float a, float b)
// {

//     if (a > 0)
//     {
//         double total = Math.Sqrt(a);
//         Console.WriteLine("La raiz de a es: " + total.ToString());
//     }
//     else
//     {
//         Console.WriteLine("a es menor que 0");
//     }

//     if (b > 0)
//     {
//         double total = Math.Sqrt(b);
//         Console.WriteLine("La raiz de b es: " + total.ToString());
//     }
//     else
//     {
//         Console.WriteLine("b es menor que 0");
//     }

// }

// void parteEntera(float a, float b)
// {
//     int aEntero = (int)a; 
//     int bEntero = (int)b; 

//     Console.WriteLine("Parte entera de a: " + aEntero.ToString());
//     Console.WriteLine("Parte entera de b: " + bEntero.ToString());

// }

// void numeroMaximo(float a, float b)
// {

//     float numeroMasGrande;
//     float numeroMasChico;

//     if (a > b)
//     {
//         numeroMasGrande = a;
//         numeroMasChico = b;
//         Console.WriteLine("Numero mas grande: " + numeroMasGrande);
//         Console.WriteLine("Numero mas chico: " + numeroMasChico);
//     }
//     else if (b > a)
//     {
//         numeroMasGrande = b;
//         numeroMasChico = a;
//         Console.WriteLine("Numero mas grande: " + numeroMasGrande);
//         Console.WriteLine("Numero mas chico: " + numeroMasChico);
//     }
//     else
//     {
//         Console.WriteLine("Ambos numeros son iguales");
//     }

// }



Console.WriteLine("Ingrese una cadena de texto");
string texto = Console.ReadLine() ?? "";
int longitud = texto.Length;
Console.WriteLine("Longitud del la cadena ingresada: " + longitud);

Console.WriteLine("Ingrese otra cadena de texto");
string texto2 = Console.ReadLine() ?? "";
Console.WriteLine("Cadenas concatenadas: " + string.Concat(texto, texto2));

Console.WriteLine("Ingrese el indice de la subcadena para extraer");
int posicion;
string indice = Console.ReadLine() ?? "";
bool aux = int.TryParse(indice, out posicion);

Console.WriteLine("Subcadena: " + texto.Substring(posicion));

foreach (char caracteres in texto)
{
    Console.Write("-" + caracteres);
}
Console.WriteLine("");
Console.WriteLine("Ingrese una palabra a buscar");
string palabraABuscar = Console.ReadLine() ?? "";
int contador = 0;
int lugar = 0;

while ((lugar = texto.IndexOf(palabraABuscar, lugar)) != -1)
{
    contador++;
    lugar += palabraABuscar.Length;

}

Console.WriteLine("Cantidad de veces que aparecio " + palabraABuscar +" :" +contador);

Console.WriteLine("Cadena a mayusculas: " + texto.ToUpper());
Console.WriteLine("Cadena a minusculas: " + texto.ToLower());

string[] palabras = texto.Split(' '); 

foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);
}