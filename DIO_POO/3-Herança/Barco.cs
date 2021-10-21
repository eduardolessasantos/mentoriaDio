using System;

namespace Heranca{
    public class Barco : Veiculo{
        public int _numeroDeVelas { get; set; }
        
        public Barco(string marca, string modelo, string cor, int numeroDeVelas)
        : base(marca, modelo, cor)
        {
            Console.WriteLine("Eu sou um barco");
            _numeroDeVelas = numeroDeVelas;
        }
    }
}