using System;


namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[5];

            string opcaoUsuario = ObterOpcaoUsuario();


            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        // TODO
                        break;

                    case "2":
                        //TODO
                        break;

                    case "3":
                        //TODO
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

               opcaoUsuario = ObterOpcaoUsuario();

               


            }


        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Adicione um aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine();

            return opcaoUsuario;
        }
    }
}
