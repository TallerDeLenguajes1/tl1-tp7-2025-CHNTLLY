// See https://aka.ms/new-console-template for more information
using EspacioPersonal;
double suma=0;
int menor = 999;

Empleado[] Empleados =
{
new Empleado("Pepe", "Argento", 'c', Cargos.Administrativo, new DateTime(1969,10,20), new DateTime (1999, 10, 11), 1000000)
,
new Empleado("Jorge", "Rodriguez", 's',Cargos.Auxiliar,new DateTime(2003,8,5), new DateTime(2025,1,1), 300000 )
,
new Empleado("Hermenegildo", "Gonzalez", 'v', Cargos.Ingeniero, new DateTime(1990, 10,2), new DateTime(2004,1,1), 800000)
};

foreach (var empleado in Empleados)
{
    System.Console.WriteLine($"Salario de {empleado.NombreEmpleado} es : {empleado.Salario()}");
    suma += empleado.Salario();
}

System.Console.WriteLine("El monto total de salarios es: " + suma);

foreach (var empleados in Empleados)
{
    if (menor > empleados.AniosJubilarse())
    {
        menor = empleados.AniosJubilarse();
    }
}

foreach (var empleados in Empleados)
{
    if (empleados.AniosJubilarse() == menor)
    {
    System.Console.WriteLine($"Nombre: {empleados.NombreEmpleado}\nApellido: {empleados.ApellidoEmpleado}\nEdad: {empleados.Edad()}\nAntiguedad: {empleados.Antiguedad()}\nAños para Jubilarse: {empleados.AniosJubilarse()}\nSalario: {empleados.Salario()}");  
    }
}