using System.Data;
using System.Reflection;

namespace aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region "trocando o valor da variavel"

            //string a, b, auxiliar;

            //Console.WriteLine("Informe um valor para a variavel a: ");
            //a = Console.ReadLine();

            //Console.WriteLine("Informe um valor para a variavel b: ");
            //b = Console.ReadLine();

            //Console.WriteLine("Valor da variavel A antes da inversão = " + a);
            //Console.WriteLine("Valor da variavel B antes da inversão = " + b);

            //auxiliar = a;
            //a = "";
            //a = b;
            //b = auxiliar;

            //Console.WriteLine("Valor da variavel A depois da inversão = " + a);
            //Console.WriteLine("Valor da variavel B depois da inversão = " + b);

            //Console.ReadLine();
            #endregion

            #region "invertendo a data"
            //Console.Write("Digite a data no formato DDMMAAAA: ");
            //string data = Console.ReadLine();


            //string dia = data.Substring(0, 2);
            //string mes = data.Substring(2, 2);
            //string ano = data.Substring(4, 4);

            //Console.WriteLine("AAAAMMDD: " + ano + mes + dia);
            //Console.WriteLine("AA MMM DD: " + ano.Substring(2, 2) + dia);

            //Console.ReadLine();
            #endregion

            #region "calculando o volume de combustivel"
            //double distancia, combustivel, consumoMedio;

            //Console.Write("Digite a distância total percorrida (em km): ");
            //distancia = double.Parse(Console.ReadLine());

            //Console.Write("Digite o volume de combustível consumido: ");
            //combustivel = double.Parse(Console.ReadLine());

            //consumoMedio = distancia / combustivel;

            //Console.Write("O consumo médio do automóvel é de " + consumoMedio.ToString("F2") + " km/l.");

            //Console.ReadLine();
            #endregion

            #region "infomando o parafuso"

            //double parafusoA, parafusoB, quantidade, valorU, imposto;

            //Console.WriteLine("Informe qual é o parafuso A: ");
            //parafusoA = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Informe qual é o parafuso B: ");
            //parafusoB = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Informe a quantidade de peças: ");
            //quantidade = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Informe qual é o valor unitario od produto: ");
            //valorU = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Informe quanto de imposto deve ser acresecentado: ");
            //imposto = Convert.ToDouble(Console.ReadLine());

            //Console.ReadLine();
            #endregion

            #region "calculando o salario'
            //double numeroV, salarioFixo, totalDeVendas, resultado, comissao = 50;

            //Console.WriteLine("Informe o numero do vendedor: ");
            //numeroV = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Informe o salario fixo: ");
            //salarioFixo = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Informe o total de vendas concluidas: ");
            //totalDeVendas = Convert.ToDouble(Console.ReadLine());

            //resultado = salarioFixo + comissao * totalDeVendas / 100;

            //Console.WriteLine("O salario final foi: " + resultado);

            //Console.ReadLine();
            #endregion

            #region "graus Celsius para F"
            //double C, F;

            //Console.WriteLine(" Informe a temperatura Celsius: ");
            //C = Convert.ToDouble(Console.ReadLine());

            //F = (9 * C + 160) / 5;
            //Console.WriteLine(" O valor do Fahrenheit: " +F);
            //Console.ReadKey();
            #endregion

            #region "valor da mercadoria"
            //double valordamercadoria, valordaentrada, prestacoes = 3, valordeduasprestacoes, total;

            //Console.Write("Informe o valor da mercadoria: ");
            //valordamercadoria = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Informe o valor da entrada: ");
            //valordaentrada = Convert.ToDouble(Console.ReadLine());

            //total = (valordamercadoria - valordaentrada) / 2;

            //Console.Write("Valor  da entrada " + total.ToString("C"));

            //Console.ReadLine();
            #endregion

            #region "notas"
            //int[] notasDisponiveis = { 100, 50, 20, 10, 5, 2, 1 };
            //int[] distribuicao = new int[notasDisponiveis.Length];

            //Console.Write("Digite o valor a ser sacado: ");
            //int valorSaque = int.Parse(Console.ReadLine());

            //Console.WriteLine("Distribuicao das notas:");

            //for (int i = 0; i < notasDisponiveis.Length; i++)
            //{
            // int quantidadeNotas = valorSaque / notasDisponiveis[i];
            //  if (quantidadeNotas > 0)
            //  {
            //     distribuicao[i] = quantidadeNotas;
            //       valorSaque %= notasDisponiveis[i];
            //      Console.WriteLine($"{quantidadeNotas} nota(s) de R${notasDisponiveis[i]}");
            //  }
            //  if (valorSaque == 0)
            //  {


            // }
            //  }

            //Console.ReadLine();
            #endregion

            #region "Cidade"
            //double ouvintes, n1, n2, n3, r1, r2, r3;

            //Console.WriteLine("Informe o numero de ouvintes dessa cidade: ");
            //ouvintes = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Quantos votos em branco: ");
            //n1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Quantos votos em nulos: ");
            //n2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Quantidade de votos validos:  ");
            //n3 = Convert.ToDouble(Console.ReadLine());

            //r1 = n1 / (n1 + n2 + n3);
            //r2 = n2 / (n1 + n2 + n3);
            //r3 = n3 / (n1 + n2 + n3);

            //Console.WriteLine("O percentual de votos em branco foi: " + r1);
            //Console.WriteLine("O percentual de votos nulos: " + r2);
            //Console.WriteLine("O percentual de votos validos: " + r3);

            //Console.ReadKey();
            #endregion

            #region "quilometragem"
            //double quilometragem, qInicial, qFinal, litros, valorTotal, media, lucro;

            //Console.WriteLine("Informe a quilometragem inicial: ");
            //qInicial = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe a quilometragem final: ");
            //qFinal = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe quanto você gastou com combustivel: ");
            //litros= double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor recebido no fim do dia: ");
            //valorTotal= double.Parse(Console.ReadLine());

            //quilometragem = qFinal - qInicial;
            //media = quilometragem - litros;
            //lucro = valorTotal - (litros * 6.90);

            //Console.WriteLine("A media de Km consumido foi de " + media);
            //Console.WriteLine("O lucro liquido foi de " + lucro);

            //Console.ReadLine();
            #endregion

            #region "Aula 2, numero secreto"
            //int n, secreto;
            //secreto = 7;

            //Console.WriteLine("Digite um numero: ");
            //n = int.Parse(Console.ReadLine());

            //if (n == 7)
            //{
            //    Console.WriteLine("ACERTOU");
            //}
            //else
            //{
            //    Console.WriteLine("ERROU");
            //    if (n > secreto)
            //    {
            //        Console.WriteLine("O numero secreto é menor que " + n);
            //    }
            //    else
            //    {
            //        Console.WriteLine("O valor secreto é maior que " + n);
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region "texte, melhorar o codigo"
            //double salario, reajuste;

            //Console.WriteLine("Informe seu salario: ");
            //salario = double.Parse(Console.ReadLine());

            //reajuste = salario;
            //if (salario <= 900)
            //{
            //    Console.WriteLine("Aumento de 5%");
            //}
            //else if (salario < 1.400)
            //{
            //    Console.WriteLine("Aumento de 8%");
            //}
            //else if (salario >= 1.400)
            //{
            //    Console.WriteLine("Aumento de 10%");
            //}
            #endregion

            #region "salario.net"
            //double salario, reajuste, novoSalario, percentual;
            //Console.WriteLine("Informe seu salario: ");
            //salario = Convert.ToDouble(Console.ReadLine());


            //if (salario <= 900)
            //{
            //    reajuste = salario * 0.05;
            //    novoSalario = salario + reajuste;
            //    percentual = 15;
            //    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            //    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            //    Console.WriteLine("Em percentual: {0} %", percentual);
            //}
            //else if (salario < 1.400)
            //{
            //    reajuste = salario * 0.08;
            //    novoSalario = salario + reajuste;
            //    percentual = 12;
            //    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            //    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            //    Console.WriteLine("Em percentual: {0} %", percentual);
            //}
            //else if (salario >= 1.400)
            //{
            //    reajuste = salario * 0.10;
            //    novoSalario = salario + reajuste;
            //    percentual = 10;
            //    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            //    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            //    Console.WriteLine("Em percentual: {0} %", percentual);
            //}
            // Console.ReadLine();
            #endregion
            // Coreção do professor
            #region "salario.aumento"
            //double salario, aumento;
            //Console.WriteLine("Digite seu salario: ");
            //salario = double.Parse(Console.ReadLine());

            //if (salario <= 900)
            //{
            //    aumento = salario * 5 / 100;
            //}
            //else if (salario > 900 && salario < 1.400) 
            //{
            //    aumento = salario * 8 / 100;
            //}
            //else
            //{
            //    aumento = salario * 10 / 100;
            //}
            //Console.WriteLine("O salario inicial era " + salario);
            //Console.WriteLine("O aumento foi de " + aumento);

            //Console.ReadLine();
            #endregion

            #region "valor do triangulo"
            //int a, b, c;

            //    Console.WriteLine("Digite um valor: ");
            //    a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite um valor: ");
            //    b = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite um valor: ");
            //    c = int.Parse(Console.ReadLine());

            //    if (a + b > c && a + c > b && b + c > a)
            //    {
            //        Console.WriteLine("Os 3 lados formam um triangulo!\n");
            //        if (a == b && a == c)
            //            Console.WriteLine("Equilatero\n");
            //        else if (a == b || a == c || b == c)
            //            Console.WriteLine("Isosceles\n");
            //        else
            //            Console.WriteLine("Escaleno\n");
            //    }
            //    else
            //       Console.WriteLine("Os 3 lados NAO formam um trinagulo!\n");
            //    Console.ReadLine();
            #endregion

            #region "area do triangulo"
            //double b, altura, area;

            //Console.WriteLine("Informe o valor da base: ");
            //b = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor da altura: ");
            //altura = double.Parse(Console.ReadLine());

            //area = b * altura / 2;

            //Console.WriteLine("A area = "+ area);
            //Console.ReadLine();

            #endregion

            #region "media das notas"
            //double n1, n2, n3, n4, media;

            //Console.WriteLine("Informe um valor: ");
            //n1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Informe um valor: ");
            //n2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Informe um valor: ");
            //n3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Informe um valor: ");
            //n4 = Convert.ToDouble(Console.ReadLine());

            //media = (n1 + n2 + n3 + n4) / 4;

            //if (n1 > media)
            //{
            //    Console.WriteLine("n1 maior que media");
            //}
            //if (n2 > media)
            //{
            //    Console.WriteLine("n2 maior que media ");
            //}
            //if  (n3 > media)
            //{
            //    Console.WriteLine("n3 maior que media ");
            //}
            //if (n4 > media)
            //{
            //    Console.WriteLine("n4 maior que media");
            //}
            //Console.ReadLine();
            #endregion

            //"teste"

        }
        }
    }


   