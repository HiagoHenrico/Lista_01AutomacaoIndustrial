using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01_Hiago
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 numExercicio;
            Console.WriteLine("Lista de Exercícios feita por Hiago Henrico Santos Eleuterio");
            Console.WriteLine("Escolha um dos exercícios listados abaixo.");
            for (int i=1; i <= 12; i++)
            {
                Console.WriteLine("{0} - Exercício", i);
            };
            Console.WriteLine("Digite o número exercício");
            numExercicio = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou {0}", numExercicio);
            if(numExercicio>=1)
            {
                switch (numExercicio)
                {
                    case 1:
                        // Ex_1
                        int vl_base = 0, vl_altura = 0, area = 0;
                        Console.WriteLine("Exercício 1 - Calcule a área de um retãngulo");
                        Console.WriteLine("Insira a base do retângulo: ");
                        vl_base = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira a altura do retângulo: ");
                        vl_altura = int.Parse(Console.ReadLine());
                        area = vl_base * vl_altura;
                        Console.WriteLine("A área do retângulo é: " + area);

                        break;
                    case 2:
                        //Ex_2
                        int vl_aresta = 0, area_quadrado = 0;
                        Console.WriteLine("Exercício 2 - Calcule a área do quadrado apartir de uma aresta");
                        Console.WriteLine("Insira aresta: ");
                        vl_aresta = int.Parse(Console.ReadLine());
                        area_quadrado = vl_aresta * vl_aresta;
                        Console.WriteLine("A área do quadrado é: " + area_quadrado);
                        break;
                    case 3:
                        //Ex_3 OBS: Não compreendi o cálculo
                        int diagonal = 0, area_quadrado2 = 0;
                        Console.WriteLine("Exercício 3 - Calcule a área de um quadrado apartir de sua diagonal");
                        Console.WriteLine("Insira a diagonal: ");
                        diagonal = int.Parse(Console.ReadLine());
                        area_quadrado2 = (diagonal * diagonal) / 2;
                        Console.WriteLine("A área do quadrado é: " + area_quadrado2);
                        break;
                    case 4:
                        //Ex_4
                        int vl_base_triangulo = 0, vl_altura_triangulo = 0, area_triangulo = 0;
                        Console.WriteLine("Exercício 4 - Calcular a área de um triângulo inserindo sua base e altura.");
                        Console.WriteLine("Insira a base do triângulo: ");
                        vl_base_triangulo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira a altura do triângulo");
                        vl_altura_triangulo = int.Parse(Console.ReadLine());
                        area_triangulo = (vl_base_triangulo * vl_altura_triangulo) / 2;
                        Console.WriteLine("A área do triangulo é: " + area_triangulo);
                        break;
                    case 5:
                        //Ex_5
                        int vl1 = 0, vl2 = 0, vl3 = 0, vl4 = 0, media = 0;
                        Console.WriteLine("Exercício 5 - Calcule a média aritmética de quatro números;");
                        Console.WriteLine("Insira o  valor 1: ");
                        vl1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o  valor 2: ");
                        vl2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o  valor 3: ");
                        vl3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o  valor 4: ");
                        vl4 = int.Parse(Console.ReadLine());
                        media = (vl1 + vl2 + vl3 + vl4) / 4;
                        Console.WriteLine("A média é: " + media);
                        break;
                    case 6:
                        //Ex_6
                        Double raizCubica;
                        int vl1_mediaG = 0, vl2_mediaG = 0, mediaG = 0;
                        Console.WriteLine("Exercício 6 - Calcule a média geométrica de dois valores");
                        Console.WriteLine("Insira o primeiro número: ");
                        vl1_mediaG = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o segundo número; ");
                        vl2_mediaG = int.Parse(Console.ReadLine());
                        mediaG = (vl1_mediaG * vl2_mediaG);
                        raizCubica = Math.Pow(mediaG, 1.0 / 3.0);
                        Console.WriteLine("A média geométrica dos valores é: " + raizCubica);
                        break;
                    case 7:
                        //Ex_7
                        Double milha = 0, km = 0;
                        Console.WriteLine("Exercício 7 - Converta milhas marítimas para quilômetros");
                        Console.WriteLine("Insira milha: ");
                        milha = double.Parse(Console.ReadLine());
                        km = (1852 * milha) / 1000;
                        Console.WriteLine("Resultado: {0} milhas naúticas são {1} quilômetros",milha, km);
                        break;
                    case 8:
                        //Ex_8
                        Double vl_celsius = 0, vl_farenheit = 0;
                        Console.WriteLine("Exercício 8 - Converter Celsius para Farenheit");
                        Console.WriteLine("Insira temperatura em Celsius: ");
                        vl_celsius = double.Parse(Console.ReadLine());
                        vl_farenheit = (vl_celsius * 1.8) + 32;
                        Console.WriteLine("Resultado: {0}° em Celsius é {1}° Farenheit",vl_celsius, vl_farenheit);
                        break;
                    case 9:
                        //Ex_9
                        Double areaCirculo = 0, pi = 3.14, diametro = 0;
                        Console.WriteLine("Exercício 9 - Calcule a área de um circula apartir de seu diâmetro");
                        Console.WriteLine("Insira o diâmetro: ");
                        diametro = double.Parse(Console.ReadLine());
                        areaCirculo = diametro * pi;
                        Console.WriteLine("A área do circulo é {0}", areaCirculo);
                        break;
                    case 10:
                        //Ex_10
                        decimal cotacao = 0, vl_dolar = 0, vl_real = 0;
                        Console.WriteLine("Exercício 10 - Converta um valor em dolares para reais, inserindo a cotação");
                        Console.WriteLine("Insira cotação: ");
                        cotacao = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Insira valor em Dólar: ");
                        vl_dolar = decimal.Parse(Console.ReadLine());
                        vl_real = vl_dolar * cotacao;
                        Console.WriteLine("Resultado: {0}USD / {1} BRL", vl_dolar, vl_real);
                        break;
                    case 11:
                        //Ex_11
                        Double X = 0, Y = 0, resultadoEx11 = 0;
                        Console.WriteLine("Exercício 11 - Insira um valor X e Y, eleve X por Y demonstrando o cálculo.");
                        Console.WriteLine("Insira o valor X: ");
                        X = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o valor Y");
                        Y = double.Parse(Console.ReadLine());
                        resultadoEx11 = Math.Pow(X, Y);
                        Console.WriteLine("Resultado: {0} elevado ao expoente {1} é igual a {2}", X, Y, resultadoEx11);
                        break;
                    case 12:
                        //Ex_12
                        decimal vl_p1 = 0, vl_p2 = 0, vl_p3 = 0, vl_p4 = 0, vl_p5 = 0, soma = 0, pagamento = 0, troco = 0;
                        Console.WriteLine("Exercício 12 - Inserir o valor de 5 produtos, efetuar o pagamento e exibir o troco");
                        Console.WriteLine("insira o valor produto 1");
                        vl_p1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("insira o valor produto 2");
                        vl_p2 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("insira o valor produto 3");
                        vl_p3 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("insira o valor produto 4");
                        vl_p4 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("insira o valor produto 5");
                        vl_p5 = decimal.Parse(Console.ReadLine());
                        soma = vl_p1 + vl_p2 + vl_p3 + vl_p4 + vl_p5;
                        Console.WriteLine("A compra custou {0}", soma.ToString("F2"));
                        Console.WriteLine("Insira o pagamento");
                        pagamento = decimal.Parse(Console.ReadLine());
                        troco = pagamento - soma;
                        if (pagamento < soma)
                        {
                            Console.WriteLine("Não fazemos fiado aqui!");
                        }
                        else
                        {
                            Console.WriteLine("Seu troco é {0} reais. Volte sempre!", troco.ToString("F2"));
                        }
                        break;
                    default:
                        Console.WriteLine("Índice Inválido");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Erro: Digite um número de 1 a 12 abençoado.");
            }
        }
    }
}
