Console.WriteLine("Hello, World!");

int i;
int j = 0;
int[] invertido = new int[10];  
string numero = Console.ReadLine();
bool resultado = int.TryParse(numero, out i);
int copia = i;

if (resultado && i > 0)
{

    while (i > 0)
    {

        i /= 10;

        j++;
    }
    Console.WriteLine("Numero invertido: ");
    for (int k = 0; k < j; k++)
    {
        invertido[k] = copia % 10;
        Console.Write(invertido[k]);
        copia /= 10;
    }

    
}