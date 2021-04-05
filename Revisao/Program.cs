using System;


namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[5];
            int indiceAluno =0;

            string opcaoUsuario = ObterOpcaoUsuario();


            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe um nome:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe uma nota:");
                        
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser um numero decimal");
                        }
                       
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO :  {a.Nome}  - NOTA {a.Nota}"); 
                            }
                            
                        }
                        break;

                    case "3":
                        decimal notaTotal=0;
                        var nrAlunos =0;

                        for ( int i=0; i<alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota ;
                                nrAlunos ++;

                            }

                        }
                        
                        var mediaGeral= notaTotal/nrAlunos;
                        EConceito conceito;

                        if(mediaGeral>=9)
                        {
                            conceito = EConceito.A;
                        }
                        else if(mediaGeral>=8)
                        {
                            conceito = EConceito.B;
                        }
                        else if(mediaGeral>=7)
                        {
                            conceito = EConceito.C;
                        }
                        else if(mediaGeral>= 6)
                        {
                            conceito = EConceito.D;
                        }
                        else
                        {
                            conceito = EConceito.E;
                        }



                        Console.WriteLine($"MEDIA GERAL : {mediaGeral} - CONCEITO GERAL: {conceito}");


                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

               opcaoUsuario = ObterOpcaoUsuario();

               


            }


        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Adicione um aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            return opcaoUsuario;
        }
    }
}
