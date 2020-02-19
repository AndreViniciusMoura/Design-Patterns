using System;

namespace DesignPatterns.AbstractFactory
{
    // AbstractProduct  
    public abstract class Veiculo
    {
        protected Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }

        public string Modelo { get; set; }
        public Porte Porte { get; set; }

    }

    public enum Porte
    {
        Pequeno,
        Medio,
        Grande
    }

    // Produto Concreto
    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo) : base(modelo, Porte.Pequeno)
        {
        }
    }

    // Produto Concreto
    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo) : base(modelo, Porte.Medio)
        {
        }
    }

    // Produto Concreto
    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo) : base(modelo, Porte.Grande)
        {
        }
    }

    public class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new VeiculoPequeno(modelo);
                case Porte.Medio:
                    return new VeiculoMedio(modelo);
                case Porte.Grande:
                    return new VeiculoGrande(modelo);
                default:
                    throw new ApplicationException("Porte de veiculo desconhecido.");
            }
        }
    }
}   