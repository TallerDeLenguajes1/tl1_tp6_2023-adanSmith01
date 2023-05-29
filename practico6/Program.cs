// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);

int num;
string? numeroIngresado;
bool valido;

do{
    Console.Write("Ingrese un número positivo: ");
    numeroIngresado = Console.ReadLine();
    valido = int.TryParse(numeroIngresado, out num);
    if(!valido){
        Console.WriteLine("ERROR. Dato inválido.");
        valido = false;
    } else{
        if(num <= 0){
            Console.WriteLine("ERROR. No se ingresú un número positivo.");
            valido = false;
        } else{
            invertirNumero(num);
        }
    }
}while(!valido);

void invertirNumero(int num){
    int aux;
    if(num < 10){
        Console.WriteLine("Valor invertido: " + num);
    } else{
        Console.Write("Valor invertido: ");
        while(num != 0){
            aux = num % 10;
            num /= 10;
            Console.Write(aux);
        }
        Console.Write("\n");
    }
}*/

//EJERCICIO 02 Y 03
/*int num_op = 0;
string? operacion, seguir;
bool validoOP = false, continuar = false;

do{
    Console.WriteLine("\n=======MENÚ=======\n");
    Console.WriteLine("1- SUMA");
    Console.WriteLine("2- RESTA");
    Console.WriteLine("3- MULTIPLICACIÓN");
    Console.WriteLine("4- DIVISIÓN");
    Console.WriteLine("5- VALOR ABSOLUTO DE UN NÚMERO");
    Console.WriteLine("6- CUADRADO DE UN NÚMERO");
    Console.WriteLine("7- RAÍZ CUADRADA DE UN NÚMERO");
    Console.WriteLine("8- SENO DE UN NÚMERO");
    Console.WriteLine("9- COSENO DE UN MÚMERO");
    Console.WriteLine("10- PARTE ENTERA");
    Console.WriteLine("11- MÁXIMO ENTRE DOS NÚMEROS");
    Console.WriteLine("12- MÍNIMO ENTRE DOS NÚMEROS");
    Console.WriteLine("13- SALIR");
    Console.Write("\nElija la operación: ");
    operacion = Console.ReadLine();
    if(!int.TryParse(operacion, out num_op)){
        Console.WriteLine("\nERROR. Número de operación inválido.\n");
    } else{
        if(num_op < 1 || num_op > 13){
            Console.WriteLine("\nERROR. Número de operación inválido.\n");
        } else{
            validoOP = true;
            if(num_op != 13){
                if(num_op < 5){
                    operaciones(num_op);
                } else{
                    operacionesAvanzadas(num_op);
                } 
                Console.WriteLine("\n¿Desea realizar otra operación? Sí / No");
                seguir = Console.ReadLine();
                if(seguir == "Si" || seguir == "Sí" || seguir == "si" || seguir == "sí"){
                    continuar = true;
                } else{
                    continuar = false;
                }
            } else{
                continuar = false;
            }
        }
    }
}while(!validoOP || continuar);



void operaciones(int num_op){
    float a, b;
    string? num1, num2;

    do{
        Console.Write("Num1: ");
        num1 = Console.ReadLine();
        Console.Write("Num2: ");
        num2 = Console.ReadLine();
        if(!float.TryParse(num1, out a) || !float.TryParse(num2, out b)) Console.WriteLine("\nERROR. Alguno de los datos es inválido.\n");
    }while(!float.TryParse(num1, out a) || !float.TryParse(num2, out b));

    switch(num_op){
        case 1:
        Console.WriteLine($"La suma de {a.ToString()} y de {b.ToString()} es igual a: {(a + b).ToString()}");
        break;
        case 2:
        Console.WriteLine($"La diferencia de {a.ToString()} y de {b.ToString()} es igual a: {(a - b).ToString()}");
        break;
        case 3:
        Console.WriteLine($"El producto de {a.ToString()} y de {b.ToString()} es igual a: {(a * b).ToString()}");
        break;
        case 4:
        Console.WriteLine($"La división de {a.ToString()} y de {b.ToString()} es igual a: {(a / b).ToString()}");
        break;
    }
}

void operacionesAvanzadas(int num_op){
    float a, b;
    string? numIngresado, num1, num2;

    if(num_op <= 10){

        do{
            Console.Write("Ingrese un número: ");
            numIngresado = Console.ReadLine();
            if(!float.TryParse(numIngresado, out a)) Console.WriteLine("\nERROR. Número inválido.\n");
        }while(!float.TryParse(numIngresado, out a));

        Console.Write("\n");
        switch(num_op){
            case 5:
            Console.WriteLine($"El valor absoluto de {a} es : {Math.Abs(a).ToString()}");
            break;
            case 6:
            Console.WriteLine($"El cuadrado de {a} es : {Math.Pow(a, 2).ToString()}");
            break;
            case 7:
            Console.WriteLine($"La raíz cuadrada de {a} es : {Math.Sqrt(a).ToString()}");
            break;
            case 8:
            Console.WriteLine($"El seno de {a} es : {Math.Sin(a).ToString()}");
            break;
            case 9:
            Console.WriteLine($"El coseno de {a} es : {Math.Cos(a).ToString()}");
            break;
            case 10:
            Console.WriteLine($"La parte entera de {a} es : {Math.Round(a).ToString()}");
            break;
        }
    } else{
        do{
            Console.Write("Num1: ");
            num1 = Console.ReadLine();
            Console.Write("Num2: ");
            num2 = Console.ReadLine();
            if(!float.TryParse(num1, out a) || !float.TryParse(num2, out b)) Console.WriteLine("\nERROR. Alguno de los datos es inválido.\n");
        }while(!float.TryParse(num1, out a) || !float.TryParse(num2, out b));

        if(num_op == 11){
            Console.WriteLine($"El máximo entre {a.ToString()} y {b.ToString()} es: {Math.Max(a, b).ToString()}");
        } else{
            Console.WriteLine($"El mínimo entre {a.ToString()} y {b.ToString()} es: {Math.Max(a, b).ToString()}");
        }
    }
}

// EJERCICIO 04
string? cadenaIngresada, op, cadenaAConcatenar, cadenaOcurrencia;
int operacionCadena = 0;
ConsoleKeyInfo caracterSep;
char sep;
string[] cadenaDes;
bool valido = false;

do{
    Console.WriteLine("\n===========OPERACIONES DE CADENA===========\n");
    Console.WriteLine("\n1- Longitud de la cadena");
    Console.WriteLine("2- Concatenar dos cadenas");
    Console.WriteLine("3- Extraer una subcadena");
    Console.WriteLine("4- Recorrer la cadena por cada caracter");
    Console.WriteLine("5- Buscar la ocurrencia de una palabra en una cadena ingresada");
    Console.WriteLine("6- Convertir la cadena ingresada a mayúscula");
    Console.WriteLine("7- Convertir la cadena ingresada a minúscula");
    Console.WriteLine("8- Separar una cadena por el caracter ingresado");
    Console.WriteLine("9- Resolver una expresión matemática");
    Console.WriteLine("10- Ninguna operación");
    Console.Write("\nElija la operación: ");
    op = Console.ReadLine();
    if(!int.TryParse(op, out operacionCadena)){
        Console.WriteLine("\nERROR. Número de operación inválido\n");
    } else{
        if(operacionCadena < 1 || operacionCadena > 10){
            Console.WriteLine("\nERROR. Número de operación inválido\n");
        } else{
            valido = true;
            if(operacionCadena != 9 && operacionCadena != 10){
                do{
                    Console.Write("Ingrese una cadena: ");
                    cadenaIngresada = Console.ReadLine();
                    if(cadenaIngresada == "" || cadenaIngresada == " ") Console.WriteLine("\nERROR. Cadena de texto inválida\n");
                }while(cadenaIngresada == "" || cadenaIngresada == " ");

                if(cadenaIngresada != null){
                    switch(operacionCadena){
                        case 1:
                        Console.WriteLine($"Longitud de la cadena ingresada: {cadenaIngresada.Length}");
                        break;
                        case 2:
                        do{
                            Console.Write("Ingrese una otra cadena: ");
                            cadenaAConcatenar = Console.ReadLine();
                            if(String.IsNullOrEmpty(cadenaAConcatenar)) Console.WriteLine("\nERROR. Cadena de texto inválida\n");
                        }while(String.IsNullOrEmpty(cadenaAConcatenar));

                        Console.WriteLine($"\nCadena resultante: {cadenaIngresada + cadenaAConcatenar}\n");
                        break;
                        case 3:
                        Console.WriteLine("\nSubcadena extraída desde el segundo elemento: " + cadenaIngresada.Substring(2));
                        break;
                        case 4:
                        Console.Write("Cadena recorrida por caracter:");
                        foreach (char elem in cadenaIngresada){
                            Console.Write($" {elem}");
                        }
                        Console.WriteLine("\n");
                        break;
                        case 5:
                        do{
                            Console.Write("Ingrese la subcadena a buscar: ");
                            cadenaOcurrencia = Console.ReadLine();
                            if(String.IsNullOrEmpty(cadenaOcurrencia)) Console.WriteLine("\nERROR. Cadena de texto inválida\n");
                        }while(String.IsNullOrEmpty(cadenaOcurrencia));
                        
                        if(cadenaIngresada.Contains(cadenaOcurrencia)){
                            Console.WriteLine($"La subcadena {cadenaOcurrencia} se encuentra dentro de la cadena ingresada.");
                        } else{
                            Console.WriteLine($"La subcadena {cadenaOcurrencia} no se encuentra dentro de la cadena ingresada.");
                        }
                        break;
                        case 6:
                        Console.WriteLine($"Cadena ingresada en mayúscula: {cadenaIngresada.ToUpper()}");
                        break;
                        case 7:
                        Console.WriteLine($"Cadena ingresada en minúscula: {cadenaIngresada.ToLower()}");
                        break;
                        case 8:
                        Console.Write("Ingrese el caracter separador: ");
                        caracterSep = Console.ReadKey();
                        sep = caracterSep.KeyChar;
                        cadenaDes = cadenaIngresada.Split(sep);
                        Console.WriteLine("\nResultado: ");
                        foreach(string cad in cadenaDes){
                            Console.WriteLine(cad);
                        }
                        break;
                    }
                }
            } else{
                if(operacionCadena == 9){
                    resolverExpresion();
                }
            }
            
        }
    }
}while(!valido || operacionCadena != 10);



void resolverExpresion(){
    string? expresionMat;
    string[] operandos;
    bool expresionValida = false, operadorEncontrado = false;
    int i = 0;
    float a, b;
    char op;

    do{
        Console.Write("\nIngrese una expresión matemática simple (Solo dos numeros para operar): ");
        expresionMat = Console.ReadLine();
        operadorEncontrado = false;
        i = 0;
        if(expresionMat != null){
            while(!operadorEncontrado && i < expresionMat.Length){
                if(expresionMat[i] == '+' || expresionMat[i] == '-' || expresionMat[i] == '*' || expresionMat[i] == 'x' || expresionMat[i] == '/'){
                    operadorEncontrado = true;
                }
                i += 1;
            }

            if(operadorEncontrado){
                operandos = expresionMat.Split(expresionMat[i - 1]);
                if(operandos.Length != 2){
                    Console.WriteLine("\nERROR. Solo se puede ingresar dos números\n");
                } else{
                    if(!float.TryParse(operandos[0], out a) || !float.TryParse(operandos[1], out b)){
                        Console.WriteLine("\nERROR. Expresión inválida.\n");
                    } else{
                        expresionValida = true;
                        op = expresionMat[i - 1];

                        switch(op){
                            case '+':
                            Console.WriteLine($"Resultado de {a}{op}{b}: {a + b}");
                            break;
                            case '-':
                            Console.WriteLine($"Resultado de {a}{op}{b}: {a - b}");
                            break;
                            case '*':
                            case 'x':
                            Console.WriteLine($"Resultado de {a}{op}{b}: {a * b}");
                            break;
                            case '/':
                            Console.WriteLine($"Resultado de {a}{op}{b}: {a / b}");
                            break;
                        }
                    }
                }
            } else{
                Console.WriteLine("\nERROR. Expresión inválida\n");
            }
        }
    }while(!expresionValida);
}*/

// EJERCICIO 05
using System.Text.RegularExpressions;

Console.Write("Ingrese una dirección de mail: ");
string correoElec = Console.ReadLine();

string patronCorreo = @"(@)(.+)$";

if(Regex.IsMatch(correoElec, patronCorreo)){
    Console.WriteLine("Es una dirección de correo electrónico válido.");
    Console.WriteLine($"La dirección de mail que ingreso es: {correoElec}");
} else{
    Console.WriteLine("No es una dirección válida.");
}

Console.Write("Ingrese una dirección web: ");
string direccionWeb = Console.ReadLine();

string patronWeb = @"^(https?://)?(www\.)?[\w-]+(\.[\w-]+)+(/[^\s]*)?$";

if(Regex.IsMatch(direccionWeb, patronWeb)){
    Console.WriteLine("Es una dirección web válida.");
    Console.WriteLine($"La dirección de mail que ingreso es: {direccionWeb}");
} else{
    Console.WriteLine("No es una dirección web válida.");
}