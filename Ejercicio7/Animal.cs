using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string LugarHabitat { get; set; }
        public string Alimentacion { get; set; }
        public int PeriodoExistencia { get; set; }

        public Animal(string nombre, string lugarHabitat, string alimentacion, int periodoExistencia)
        {
            Nombre = nombre;
            LugarHabitat = lugarHabitat;
            Alimentacion = alimentacion;
            PeriodoExistencia = periodoExistencia;
        }

        public virtual void EditarCaracteristicas(string alimentacion, int periodoExistencia)
        {
            Alimentacion = alimentacion;
            PeriodoExistencia = periodoExistencia;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Lugar de Hábitat: {LugarHabitat}, Alimentación: {Alimentacion}, Período de Existencia: {PeriodoExistencia} años";
        }
    }

    public class AnimalAcuatico : Animal
    {
        public AnimalAcuatico(string nombre, string lugarHabitat, string alimentacion, int periodoExistencia)
            : base(nombre, lugarHabitat, alimentacion, periodoExistencia)
        {
        }
    }

    public class AnimalTerrestre : Animal
    {
        public bool Bipedo { get; set; }
        public bool Cuadrupedo { get; set; }
        public bool Exoesqueleto { get; set; }

        public AnimalTerrestre(string nombre, string lugarHabitat, string alimentacion, int periodoExistencia, bool bipedo, bool cuadrupedo, bool exoesqueleto)
            : base(nombre, lugarHabitat, alimentacion, periodoExistencia)
        {
            Bipedo = bipedo;
            Cuadrupedo = cuadrupedo;
            Exoesqueleto = exoesqueleto;
        }

        public override string ToString()
        {
            return base.ToString() + $", Bipedo: {Bipedo}, Cuadrupedo: {Cuadrupedo}, Exoesqueleto: {Exoesqueleto}";
        }
    }

    public class AnimalAereo : Animal
    {
        public double DistanciaVision { get; set; }
        public double VelocidadVuelo { get; set; }

        public AnimalAereo(string nombre, string lugarHabitat, string alimentacion, int periodoExistencia, double distanciaVision, double velocidadVuelo)
            : base(nombre, lugarHabitat, alimentacion, periodoExistencia)
        {
            DistanciaVision = distanciaVision;
            VelocidadVuelo = velocidadVuelo;
        }

        public override string ToString()
        {
            return base.ToString() + $", Distancia de Visión: {DistanciaVision} km, Velocidad de Vuelo: {VelocidadVuelo} km/h";
        }
    }
}
