using FigurasGeometricas.Interfaz;

namespace FigurasGeometricas.Modelo
{
    public class Cuadrado : IFiguraGeometrica
    {
        private readonly float _lado;

        public Cuadrado(float lado)
        {
            _lado = lado;
        }

        public float Area()
        {
            return _lado * _lado;
        }

        public float Perimetro()
        {
            return _lado * 4;
        }
    }
}
