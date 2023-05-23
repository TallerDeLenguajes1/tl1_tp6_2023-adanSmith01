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

//EJERCICIO 02
int num_op = 0;
string? operacion, seguir;
bool validoOP = false, continuar = false;

do{
    Console.WriteLine("\n=======MENÚ=======\n");
    Console.WriteLine("1- SUMA");
    Console.WriteLine("2- RESTA");
    Console.WriteLine("3- MULTIPLICACIÓN");
    Console.WriteLine("4- DIVISIÓN");
    Console.WriteLine("5- SALIR");
    Console.Write("\nElija la operación: ");
    operacion = Console.ReadLine();
    if(!int.TryParse(operacion, out num_op)){
        Console.WriteLine("\nERROR. Número de operación inválido.\n");
    } else{
        if(num_op < 1 || num_op > 5){
            Console.WriteLine("\nERROR. Número de operación inválido.\n");
        } else{
            validoOP = true;
            if(num_op != 5){
                operaciones(num_op);
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
    float a, b, res = 0;
    string? num1, num2;

    do{
        Console.Write("Num1: ");
        num1 = Console.ReadLine();
        Console.Write("\nNum2: ");
        num2 = Console.ReadLine();
        if(!float.TryParse(num1, out a) || !float.TryParse(num2, out b)) Console.WriteLine("\nERROR. Alguno de los datos es inválido.\n");
    }while(!float.TryParse(num1, out a) || !float.TryParse(num2, out b));

    switch(num_op){
        case 1:
        res = a + b;
        break;
        case 2:
        res = a - b;
        break;
        case 3:
        res = a * b;
        break;
        case 4:
        res = a / b;
        break;
    }

    Console.WriteLine("Resultado de la operación: " + res);
}




