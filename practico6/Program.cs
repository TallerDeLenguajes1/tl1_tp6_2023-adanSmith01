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
        Console.WriteLine("\nResultado de la operación: " + (a + b));
        break;
        case 2:
        Console.WriteLine("\nResultado de la operación: " + (a - b));
        break;
        case 3:
        Console.WriteLine("\nResultado de la operación: " + (a * b));
        break;
        case 4:
        Console.WriteLine("\nResultado de la operación: " + (a / b));
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

        switch(num_op){
            case 5:
            Console.WriteLine("\nResultado de la operación: " + Math.Abs(a));
            break;
            case 6:
            Console.WriteLine("\nResultado de la operación: " + Math.Pow(a, 2));
            break;
            case 7:
            Console.WriteLine("\nResultado de la operación: " + Math.Sqrt(a));
            break;
            case 8:
            Console.WriteLine("\nResultado de la operación: " + Math.Sin(a));
            break;
            case 9:
            Console.WriteLine("\nResultado de la operación: " + Math.Cos(a));
            break;
            case 10:
            Console.WriteLine("\nResultado de la operación: " + Math.Round(a));
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
            Console.WriteLine("\nResultado de la operación: " + Math.Max(a, b));
        } else{
            Console.WriteLine("\nResultado de la operación: " + Math.Min(a, b));
        }
    }
}