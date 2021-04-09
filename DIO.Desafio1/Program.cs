using System;
using System.Globalization;

namespace DIO.Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
           // VisitaNaFeira();
           //Tuitando();
           ValidacaoNota();

        }


        /*Desafio 1
        Você está na feira com a sua sacola e parou em uma banca. O feirante lhe entregou pimentões amarelos e vermelhos.
        Agora iremos somar os pimetões amarelos e vermelhos para descobrir o total de pimentões na sacola.  
        Você receberá 2 inteiros que devem ser lidos e armazenados nas variáveis A (pimentões amarelos) e B (pimentões vermelhos). 
        Faça a soma de A e B atribuindo o seu resultado na variável X (total de pimentões).
        Apresente X como descrito na mensagem de exemplo abaixo. Não apresente outra mensagem além da mensagem especificada.

        Entrada
        A entrada contém 2 valores inteiros, separados por um espaço.

        Saída
        Imprimir a mensagem "X = " (sendo a letra X maiúscula) seguido pelo valor da variável X e pelo final de linha.
        Assegure que exista um espaço antes e depois do sinal de igualdade.
        */
        private static void VisitaNaFeira()
        {
            Console.WriteLine("Entre com o numero de pimentoes amarelos e vermelhos separados por espaço e aperte enter: ");

            var input = Console.ReadLine();
            string[] output = input.Split(' ');
            int[] outputInt = Array.ConvertAll(output, str => int.Parse(str));

            int x = outputInt[0] + outputInt[1]; //complete o código de acordo com o cálculo esperado

            Console.WriteLine("X = {0}\n", x);
        }

        /*O microblog Twitter é conhecido por limitar as postagens em 140 caracteres. 
        Conferir se um texto vai caber em um tuíte é sua tarefa.

        Entrada
        A entrada é uma linha de texto T (1 ≤ |T| ≤ 500).

        Saída
        A  saída é dada em uma única linha. 
        Ela deve ser "TWEET" (sem as aspas) se a linha de texto T tem até 140 caracteres. 
        Se T tem mais de 140 caracteres, a saída deve ser "MUTE".*/

        private static void Tuitando()
        {
            string v = Console.ReadLine();
            char[] arr = v.ToCharArray();

            if( arr.Length <= 140 ) //complete a condicional
                Console.WriteLine("TWEET");
            else
                Console.WriteLine("MUTE");

        }

        /*Desafio 3
        Para ajudar a calcular as notas referentes às duas avaliações dos alunos, uma professora pediu para que você desenvolva um
        programa que calcule e imprima a média semestral. 
        Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]).
        Cada nota deve ser validada separadamente.

        Entrada
        A entrada contém vários valores reais, positivos ou negativos.
        O programa deve ser encerrado quando forem lidas duas notas válidas.

        Saída
        Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
        Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo.
        O valor deve ser apresentado com duas casas após o ponto decimal. */

        private static void ValidacaoNota()
        {
            double nota;
            int qtdIgual = 0;
            double soma = 0;

            while (qtdIgual != 2)
            {
                Console.WriteLine("Entre com o valor da nota: ");
                nota = double.Parse(Console.ReadLine(),new CultureInfo("en-US"));
                Console.Write(nota);
                if ( nota >=0  && nota<= 10  )   //complete a condicional
                {
                    soma = nota+soma;
                    qtdIgual++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
                
            }
            Console.WriteLine("media = {0:0.00}", (soma/2)); //insira a variavel correta

        }

            


            }
        }


