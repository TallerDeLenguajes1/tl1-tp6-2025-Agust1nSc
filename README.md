1. ¿String es un tipo por valor o un tipo por referencia?
string es un tipo por referencia, ya que internamente es un objeto en .NET.
Sin embargo, se comporta como si fuera inmutable y por valor, porque una vez creada una cadena, su contenido no puede cambiar. Si se modifica, se crea una nueva instancia.

¿Qué secuencias de escape tiene el tipo string?
El tipo string en C# permite varias secuencias de escape que se usan para representar caracteres especiales:

\\ - Barra invertida

\" - Comillas dobles

\' - Comillas simples

\n - Nueva línea

\r - Retorno de carro

\t - Tabulación horizontal

\a - Alerta (beep)

\b - Retroceso (backspace)

\f - Salto de página

\v - Tabulación vertica

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

El carácter @ antes de una cadena indica que es una cadena literal.
Esto significa que se ignoran las secuencias de escape y se permite el uso de varias líneas.

El carácter $ antes de una cadena permite la interpolación, es decir, insertar valores de variables dentro de la cadena usando {}.