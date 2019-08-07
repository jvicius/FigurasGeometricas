using FigurasGeometricas.Interfaz;

namespace FigurasGeometricas.Modelo
{
    public class Triagulo : IFiguraGeometrica
    {
        private readonly float _lado1;
        private readonly float _lado2;
        private readonly float _lado3;
        private readonly float _base;
        private readonly float _altura;

        public Triagulo(float lado1, float lado2, float lado3, float baseT, float altura)
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _lado3 = lado3;
            _base = baseT;
            _altura = altura;
        }

        public float Area()
        {
            return _base * _altura;
        }

        public float Perimetro()
        {
            return _lado1 + _lado2 + _lado3;
        }
    }
}
