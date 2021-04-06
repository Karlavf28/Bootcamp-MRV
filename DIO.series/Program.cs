using System;
using DIO.series;
using DIO.series.Interfaces;
using DIO.series.Classes;

namespace DIO.series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo! Qual séria você vai ver hoje? ");
            string opcaoUsuario = ObterOpcaoUsuario();
            
             while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1": //Listar serie
                        ListarSeries();
                        break;

                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        //AtualizarSerie();
                        break;

                    case "4":
                        //ExcluirSerie();
                        break;
                    
                    case "5":
                        //VisualizarSerie();
                        break;

                    case "6":
                        //Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

               opcaoUsuario = ObterOpcaoUsuario();


        }
    }

        private static void InserirSerie()
        {
           
            Console.WriteLine("Digite um Título para a nova serie:");
            string entradaTitulo  = Console.ReadLine();
            
            Console.WriteLine("Digite um Gênero entre as opcões abaixo:");
            Console.WriteLine();
            foreach(int i in Enum.GetValues(typeof (Genero)))
            {
                Console.WriteLine($" {i} - {Enum.GetName(typeof(Genero),i)}");

            }
            Console.WriteLine();
            int entradaGenero  = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite uma descrição: ");
            string entradaDescricao  = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o ano da Série ");
            int entradaAno  = int.Parse(Console.ReadLine());
            Console.WriteLine();

  
            int novoID = repositorio.ProximoId();
            Serie novaSerie = new Serie(novoID, (Genero)entradaGenero, entradaTitulo, entradaDescricao, entradaAno );
            repositorio.Insere(novaSerie);
        }

        private static void ListarSeries()
        {

            Console.WriteLine("1- Listar Séries:");

            var lista = repositorio.Lista();

            if(lista.Count == 0 )
            {
                Console.WriteLine("Nenhuma serie encontrada");
                return;
            }
            
            foreach(var serie in lista)
            {
                Console.WriteLine($"Id : {serie.RetornaId()}  - Título {serie.RetornaTitulo()} ");
            }

            

        }



        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualisar série");
            Console.WriteLine("6 - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            return opcaoUsuario;
        }
    }
}