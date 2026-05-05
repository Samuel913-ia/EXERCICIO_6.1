using System;
using Exercicio_6._1;

namespace Exercicio_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista para guardar os veículos registados
            List<Veiculo> frota = new List<Veiculo>();

            int opcao;

            do
            {
                Console.WriteLine("\n==========================================");
                Console.WriteLine("    SISTEMA DE ALUGUER DE VEÍCULOS");
                Console.WriteLine("==========================================");
                Console.WriteLine("  1. Registar veículo");
                Console.WriteLine("  2. Actualizar quilometragem");
                Console.WriteLine("  3. Apresentar dados de um veículo");
                Console.WriteLine("  4. Listar todos os veículos");
                Console.WriteLine("  0. Sair");
                Console.WriteLine("==========================================");
                Console.Write("  Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // --- Registar veículo ---
                        Console.WriteLine("\n--- Registar novo veículo ---");
                        Console.Write("  Matrícula      : ");
                        string matricula = Console.ReadLine();

                        Console.Write("  Marca          : ");
                        string marca = Console.ReadLine();

                        Console.Write("  Modelo         : ");
                        string modelo = Console.ReadLine();

                        Console.Write("  Ano Fabricação : ");
                        int ano = int.Parse(Console.ReadLine());

                        Console.Write("  Quilometragem  : ");
                        double km = double.Parse(Console.ReadLine());

                        Veiculo novoVeiculo = new Veiculo(matricula, marca, modelo, ano, km);
                        frota.Add(novoVeiculo);

                        Console.WriteLine("\n  Veículo registado com sucesso!");
                        break;

                    case 2:
                        // --- Actualizar quilometragem ---
                        if (frota.Count == 0)
                        {
                            Console.WriteLine("\n  Não há veículos registados.");
                            break;
                        }

                        Console.Write("\n  Matrícula do veículo: ");
                        string mat = Console.ReadLine();

                        Veiculo encontrado = frota.Find(v => v.Matricula == mat);

                        if (encontrado == null)
                        {
                            Console.WriteLine("  Veículo não encontrado.");
                        }
                        else
                        {
                            Console.Write("  Km percorridos no aluguer: ");
                            double kmAluguer = double.Parse(Console.ReadLine());
                            encontrado.ActualizarQuilometragem(kmAluguer);
                        }
                        break;

                    case 3:
                        // --- Apresentar dados de um veículo ---
                        if (frota.Count == 0)
                        {
                            Console.WriteLine("\n  Não há veículos registados.");
                            break;
                        }

                        Console.Write("\n  Matrícula do veículo: ");
                        string matConsulta = Console.ReadLine();

                        Veiculo vConsulta = frota.Find(v => v.Matricula == matConsulta);

                        if (vConsulta == null)
                        {
                            Console.WriteLine("  Veículo não encontrado.");
                        }
                        else
                        {
                            vConsulta.ApresentarDados();
                        }
                        break;

                    case 4:
                        // --- Listar todos os veículos ---
                        if (frota.Count == 0)
                        {
                            Console.WriteLine("\n  Não há veículos registados.");
                            break;
                        }

                        Console.WriteLine("\n--- Lista de todos os veículos ---");
                        foreach (Veiculo v in frota)
                        {
                            v.ApresentarDados();
                        }
                        break;

                    case 0:
                        Console.WriteLine("\n  A sair do sistema...");
                        break;

                    default:
                        Console.WriteLine("\n  Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 0);

            Console.ReadKey();
        }
    }
}