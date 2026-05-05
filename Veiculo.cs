using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_6._1
{
    public class Veiculo
    {

        // ATRIBUTOS PRIVADOS

        private string matricula;
        private string marca;
        private string modelo;
        private int anoFabricacao;
        private double quilometragem;

        // CONSTRUTOR SEM PARÂMETROS
        public Veiculo()
        {
            matricula = "Desconhecida";
            marca = "Desconhecida";
            modelo = "Desconhecido";
            anoFabricacao = 0;
            quilometragem = 0.0;
        }

       
        // CONSTRUTOR COM PARÂMETROS
        
        public Veiculo(string matricula, string marca, string modelo,
                       int anoFabricacao, double quilometragem)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
            this.quilometragem = quilometragem;
        }

        
        // PROPRIEDADES (get / set)
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int AnoFabricacao
        {
            get { return anoFabricacao; }
            set { anoFabricacao = value; }
        }

        public double Quilometragem
        {
            get { return quilometragem; }
            private set { quilometragem = value; }
        }

        // MÉTODOS
        public void ActualizarQuilometragem(double kmPercorridos)
        {
            if (kmPercorridos < 0)
            {
                Console.WriteLine("Erro: quilómetros não podem ser negativos.");
                return;
            }
            quilometragem += kmPercorridos;
            Console.WriteLine($"  Quilometragem actualizada: +{kmPercorridos} km → Total: {quilometragem:F1} km");
        }

        public void ApresentarDados()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"  Matrícula      : {matricula}");
            Console.WriteLine($"  Marca         : {marca}");
            Console.WriteLine($"  Modelo        : {modelo}");
            Console.WriteLine($"  Ano Fabricação: {anoFabricacao}");
            Console.WriteLine($"  Quilometragem  : {quilometragem:F1} km");
            Console.WriteLine("------------------------------------------");
        }
    }
}