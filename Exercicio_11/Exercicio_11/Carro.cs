using System;

namespace Exercicio_11
{

    public class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Velocidade { get; set; }

        // Construtor da classe Carro
        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0; // Velocidade inicial é zero
        }

        // Método para acelerar o carro
        public void Acelerar()
        {
            Velocidade += 10; // Aumenta a velocidade em 10
        }

        // Método para frear o carro
        public void Frear()
        {
            Velocidade -= 10; // Diminui a velocidade em 10
                              // Garante que a velocidade nunca seja negativa
            if (Velocidade < 0)
            {
                Velocidade = 0;
            }
        }

        // Método para exibir as informações do carro
        public override string ToString()
        {
            return $"Modelo: {Modelo}, Ano: {Ano}, Velocidade: {Velocidade} km/h";
        }
    }

}
