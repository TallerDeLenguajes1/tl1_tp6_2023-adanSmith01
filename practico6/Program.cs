// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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
    Console.Write("Ingrese un numero positivo: ");
    numeroIngresado = Console.ReadLine();
    valido = int.TryParse(numeroIngresado, out num);
    if(!valido){
        Console.WriteLine("ERROR. Dato invalido");
        valido = false;
    } else{
        if(num <= 0){
            Console.WriteLine("ERROR. No se ingreso un numero positivo.");
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
}