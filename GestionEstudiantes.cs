using System;

namespace JhonZuluagaAPP
{
    public class GestionEstudiantes
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; } 
        public string Instrumento { get; set; }
        public double CostoClase { get; set; }
        public int NumeroClases { get; set; }


        // Método para calcular el costo total
        public double CalcularCostoTotal()
        {
            return CostoClase * NumeroClases;
        }
    }
}
