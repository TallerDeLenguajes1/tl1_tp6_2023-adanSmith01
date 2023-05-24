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