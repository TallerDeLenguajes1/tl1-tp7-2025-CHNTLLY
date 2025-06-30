// See https://aka.ms/new-console-template for more information
namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        public void Sumar(double termino)
        {
            dato = dato + termino;
            Console.WriteLine(dato);
        }
        public void Restar(double termino)
        {
            dato = dato - termino;
            Console.WriteLine(dato);
        }
        public void Multiplicar(double termino)
        {
            dato = dato * termino;
            Console.WriteLine(dato);
        }
        public void Dividir(double termino)
        {
            dato = dato / termino;
            Console.WriteLine(dato);
        }
        public void Limpiar()
        {
            Console.Clear();
        }

        public double Resultado
        {
            get => dato;
        }
    }
}
