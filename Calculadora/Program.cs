using EspacioCalculadora;
string opcionS;
int opcionI = 1;

string numS;
double numD;

Console.WriteLine("opcion 1: Sumar");
Console.WriteLine("opcion 2: Restar");
Console.WriteLine("opcion 3: Multiplicar");
Console.WriteLine("opcion 4: Dividir");
Console.WriteLine("opcion 5: Limpiar la Consola");
Console.WriteLine("opcion 6: Mostrar valor actual");
Console.WriteLine("opcion 0: Salir del programa");

Calculadora calculadora1 = new Calculadora();

do
{
    if (opcionI != 0)
    {
        do
        {
            Console.WriteLine("Ingrese una opcion para continuar (0 para salir):");
            opcionS = Console.ReadLine();
            int.TryParse(opcionS, out opcionI);
        } while (opcionI < 0 || opcionI > 6);
    }

    if(opcionI!=0)
    {
        do
        {
            Console.Write("Ingrese un numero para operar:");
            numS = Console.ReadLine();
            double.TryParse(numS, out numD);
            if (!double.TryParse(numS, out numD))
            {
                Console.WriteLine("Numero Invalido");
            }
        } while (!double.TryParse(numS, out numD));

        switch (opcionI)
        {
            case 1:
                calculadora1.Sumar(numD);
                break;
            case 2:
                calculadora1.Restar(numD);
                break;
            case 3:
                calculadora1.Multiplicar(numD);
                break;
            case 4:
                if (numD != 0)
                {
                    calculadora1.Dividir(numD);
                }
                else
                {
                    Console.WriteLine("El numero debe ser distinto de 0 para dividir");
                }
                break;
            case 5:
                calculadora1.Limpiar();
                break;
            case 6:
                Console.WriteLine($"{calculadora1.Resultado}");
                break;
            default:
                break;
        }
    }
} while (opcionI != 0);