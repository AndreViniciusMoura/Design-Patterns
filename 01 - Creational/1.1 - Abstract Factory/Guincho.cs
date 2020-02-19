using System;

namespace DesignPatterns.AbstractFactory
{
    // AbstractProduct   
    public abstract class Guincho
    {
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
        public Porte Porte { get; set; }
    }

    // Produto Concreto
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno() : base(Porte.Pequeno) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Pequeno - Modelo " + veiculo.Modelo);
        }
    }

    // Produto Concreto
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio() : base(Porte.Medio) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Medio - Modelo " + veiculo.Modelo);
        }
    }

    // Produto Concreto
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande() : base(Porte.Grande) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Grande - Modelo " + veiculo.Modelo);
        }
    }

    public class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno();
                case Porte.Medio:
                    return new GuinchoMedio();
                case Porte.Grande:
                    return new GuinchoGrande();
                default:
                    throw new ApplicationException("Porte de Guincho desconhecido.");
            }
        }
    }
}