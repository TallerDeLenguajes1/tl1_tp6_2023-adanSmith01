# EJERCICIO 4 - RESPUESTAS A LAS PREGUNTAS ENUNCIADAS

## ¿String es un tipo por valor o un tipo por referencia?

El tipo de dato string es un tipo de dato por referencia. Se representa como un arreglo o colección de objetos de tipo Char.

## ¿Qué secuencias de escape tiene el tipo string?

Entre las secuencias de escape que presenta el tipo string se encuentran:

- Comilla simple: `\'`
- Comilla doble: `\"`
- Barra diagonal inversa: `\\`
- Salto de línea: `\n`
- Tabulación horizontal: `\t`
- Tabulación vertical: `\v`
- Caracter nulo: `\0`
- Retroceso (Permite borrar el último caracter): `\b`
- Retorno de carro (Mueve el cursor al principio de la línea): `\r` 

## ¿Qué sucede cuando utiliza el caracter @ y $ antes de una cadena de texto?

Al usar el caracter especial `@` antes de una cadena de texto se indica que la cadena se debe
considerar como un literal de cadena, es decir, cualquier secuencia de escape o expresión en particular
que se encuentre dentro de la cadena se debe interpretar como parte de la cadena misma.

Por otro lado, anteponer el caracter especial `$` en una cadena de texto es para identificar a la misma
como una cadena interpolada, la cual es una cadena literal que contiene expresiones de cierto tipo y que son
reemplazadas por su representación en cadena de texto.

# EJERCICIO 5 - EXPRESIONES REGULARES

Las expresiones regulares son una secuencia de caracteres que definen un patrón de búsqueda para trabajar sobre
cadenas de texto. Estos patrones se construyen con caracteres normales o, generalmente, con una combinación de caracteres normales y metacaracteres, siendo estos últimos los que describen ciertas construcciones o disposiciones de caracteres.

## ¿Funcionan únicamente en C#?

Las expresiones regulares se pueden aplicar en diversos lenguajes, tales como Perl, Python, Ruby, JavaScript, entre otros. 
Cada lenguaje tiene un tratamiento diferente para cada expresión regular así como una sintaxis para delimitar al mismo.

## ¿En qué casos les parece útiles?

Las expresiones regulares pueden ser usadas para muchas situaciones relacionadas, desde búsquedas de expresiones concretas hasta para
realizar validaciones de alguna cadena con un formato predefinido. Entre las posibles situaciones se encuentran:

- Buscar números telefónicos, que tengan o no una clave del país.
- Comprobación de entradas de usuario.
- Búsquedas en Bases de datos.

## ¿Cómo se hace uso de estas en C#?

Para poder emplear una o más expresiones regulares se pueden utilizar las siguientes clases:
- `Regex`
- `Match`
- `MatchCollection`
- `GroupCollection`

Cada clase proporciona métodos útiles para trabajar con las expresiones regulares ya sea para determinar ocurrencias, reemplazar alguna subcadena o subcadenas por alguna expresión particular, coleccionar las ocurrencias obtenidas dada la o las expresiones regulares, entre otros.
