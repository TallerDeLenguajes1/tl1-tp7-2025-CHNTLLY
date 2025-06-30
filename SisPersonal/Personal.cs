namespace EspacioPersonal
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public class Empleado
    {
        public Empleado(string nombreIngreso, string ApellidoIngreso, char estadoCivilIn, Cargos cargoingreso,
        DateTime fechanac, DateTime fechaing, double sueldo)
        {
            this.apellido = ApellidoIngreso;
            this.nombre = nombreIngreso;
            this.estadoCivil = estadoCivilIn;
            this.cargo = cargoingreso;
            this.fechaNacimiento = fechanac;
            this.FechaIngreso = fechaing;
            this.SueldoBasico = sueldo;
        }

        // Propiedades

        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        public char estadoCivil { get; set; }
        private DateTime FechaIngreso;
        public double SueldoBasico { get; set; }
        public Cargos cargo { get; set; }

        public string NombreEmpleado
        {
            get => nombre;
        }
        public string ApellidoEmpleado
        {
            get => apellido;
        }
        public DateTime FNEmpleado
        {
            get => fechaNacimiento;
        }
        public DateTime FIEmpleado
        {
            get => FechaIngreso;
        }


        public int Antiguedad()
        {
            DateTime Actual = new DateTime();
            Actual = DateTime.Now;

            int antiguedad = Actual.Year - FechaIngreso.Year;
            return antiguedad;
        }
        public int Edad()
        {
            DateTime Actual = new DateTime();
            Actual = DateTime.Now;

            int edad = Actual.Year - fechaNacimiento.Year;
            return edad;
        }
        public int AniosJubilarse()
        {
            int edad = 65 - Edad();
            if (edad <= 0)
            {
                return 0;
            }
            else
            {
                return edad;
            }
        }
        public double Salario()
        {
            double calculo = SueldoBasico + Adicional();
            return calculo;
        }

        public double Adicional()
        {
            double multiplicador = 0;
            double adicional = SueldoBasico;
            if (Antiguedad() <= 20)
            {
                multiplicador = 0.01 * Antiguedad();
            }
            else
            {
                multiplicador = 0.25;
            }

            adicional = adicional * multiplicador;

            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                multiplicador = 0.50;
                adicional = adicional + adicional * multiplicador;
            }

            if (estadoCivil == 'c')
            {
                adicional = adicional + 150000;
            }

            return adicional;
        }
    }
}
