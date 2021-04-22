using System;


namespace DIO.Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Selecao();
            //Triangulo();
            //NotasMoedas();
           // DivisaoEuclidiana();
           Bhaskara();

        }


        /*
        Desafio 1
        Leia 4 valores inteiros A, B, C e D. Com base nisso, se o valor de B for maior do que de C e se D for maior do que A, 
        e a soma de C com D for maior que a soma de A e B e se tanto C quanto D forem positivos e, 
        ainda, se a variável A for par, escreva a mensagem "Valores aceitos", 
        senão escrever "Valores nao aceitos".*/

        private static void Selecao()
        {

        Console.WriteLine("Digite 4 valores separados por espaço!");
        string [] selections = Console.ReadLine().Split(' ');
        int A = int.Parse(selections[0]);
        int B = int.Parse(selections[1]);
        int C = int.Parse(selections[2]);
        int D = int.Parse(selections[3]);


        if ((B > C) && (D>A) && (C+D) > (A+B) && (C>=0) && (D>=0) && (A % 2 == 0 )) {
          Console.WriteLine("Valores aceitos");
        } else {
          Console.WriteLine("Valores nao aceitos");
        };

        }


    /*Desafio 2
    Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. 
    Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:
    Perimetro = XX.X
    Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
    Area = XX.X*/

        private static void Triangulo()
        {
            Console.WriteLine("Digite 3 valores separados por espaço!");
            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if(((a+b)>c )&&((a+c) >b)&&((b+c)>a )) 
            {
                Console.WriteLine("Perimetro = {0:0.0}", a+b+c ); //complete a saida
            }
            else
            {
                Console.WriteLine("Area = {0:0.0}",  ((a+b)*c)/2 ); //complete a saida
            }
        }

        /*Leia um valor de ponto flutuante com duas casas decimais. 
        Este valor representa um valor monetário. 
        A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. 
        As notas consideradas são de 100, 50, 20, 10, 5, 2. 
        As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.*/
        private static void NotasMoedas()
        {
            decimal troco;

            troco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", (int) troco / 100);
            troco = troco % 100;
            Console.WriteLine("{0} nota(s) de R$ 50.00", (int) troco / 50);
            troco = troco % 50;
            Console.WriteLine("{0} nota(s) de R$ 20.00", (int) troco / 20);
            troco = troco % 20;
            Console.WriteLine("{0} nota(s) de R$ 10.00", (int) troco / 10);
            troco = troco % 10;
            Console.WriteLine("{0} nota(s) de R$ 5.00", (int) troco / 5);
            troco = troco % 5;
            Console.WriteLine("{0} nota(s) de R$ 2.00", (int) troco / 2);
            troco = troco % 2;
            troco = troco * 100;

            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", (int)troco / 100);
            troco = troco % 100;
            Console.WriteLine("{0} moeda(s) de R$ 0.50", (int)troco / 50);
            troco = troco % 50;
            Console.WriteLine("{0} moeda(s) de R$ 0.25", (int)troco / 25);
            troco = troco % 25;
            Console.WriteLine("{0} moeda(s) de R$ 0.10", (int)troco / 10);
            troco = troco % 10;
            Console.WriteLine("{0} moeda(s) de R$ 0.05", (int)troco / 5);
            troco = troco % 5;
            Console.WriteLine("{0} moeda(s) de R$ 0.01", (int)troco);
                

        }
        //Implementando a Divisão Euclidiama
        private static void DivisaoEuclidiana()
        {
            string[] valores = Console.ReadLine().Split();
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int q, r;

         
              q = a/b;
              r = a - b*q;

              if(r < 0)
              r = r + Math.Abs(b);

              q = (a-r)/b;

              Console.WriteLine("{0} {1}", q, r);
        }
         //Implementando a Fórmula de Bhaskara
        private static void Bhaskara()
        {
            double a, b, c, delta, r1, r2;
            string[] valor = Console.ReadLine().Split();

            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            delta = (Math.Pow(b, 2) - (4 * a * c));


            if (delta>=0 && a!=0 )
            {
               r1 = (-b + Math.Sqrt(delta)) / (2 * a);
               r2 = (-b - Math.Sqrt(delta)) / (2 * a);

               r1 = Math.Round(r1,5);
               r2 = Math.Round(r2,5);

              Console.WriteLine("R1 = {0}", r1);
              Console.WriteLine("R2 = {0}", r2);
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }

        }

    }
}
