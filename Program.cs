// See https://aka.ms/new-console-template for more information
using System;
// using System.Collections.Generic;
// using System.Linq;

namespace DIO.Series // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        public static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                    throw new ArgumentOutOfRangeException();


                }
            }
            //Series meuObjeto = new Series();

            System.Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
private static void ExcluirSerie()
{
    Console.Write("Digite o id da série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    repositorio.Exclui(indiceSerie);
}
private static void AtualizarSerie()
{
    Console.WriteLine("Digite o id da série:");
    int indiceSerie = int.Parse(Console.ReadLine());

    foreach (var i in Enum.GetValues(Type(Genero)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(type(Genero), i));
    }
    Console.Write("Digite o genero entre as opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.Write("Digite o titulo da serie: ");
    int entradaTitulo = int.Parse(Console.ReadLine());

    Console.Write("Digite o ano de inicio da serie: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.Write("Digite a descrição da serie: ");
    int EntradaDescricao = int.Parse(Console.ReadLine());

    Series atualizaSerie = new Series(id: indiceSerie,
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descricao: EntradaDescricao);
}
            private static void ListarSeries()
            {
                Console.WriteLine("Listar séries");

                var Lista = repositorio.Lista();

                if (Lista.Count == 0)
                {
                    Console.WriteLine("Nenhuma série cadastrada.");
                    return;
                }

                foreach (var series in Lista)
                {
                    var Excluido = series.retornaExcluido();
                    
                    Console.WriteLine("#ID {0}:  {1} - {2}", series.retornaId(). series.retornaTitulo(), (Excluido ? "Excluido" : "") );
                }
            }

            private static void InserirSerie()
            {
                Console.WriteLine("Inserir nova serie");

                foreach (var i in Enum.GetName(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.WriteLine("Digite o genero entre as opções: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o titulo da Serie> ");
                string entradaTitulo = Console.ReadLine();

                Console.WriteLine("Digite o ano de inicio da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a descrição da Série: ");
                string EntradaDescricao = Console.ReadLine();

                Series novaSerie = new Serie (id: repositorio.ProximoId(),
                                              genero: (Genero)entradaGenero,
                                              titulo: entradaTitulo,
                                              ano: entradaAno,
                                              EntradaDescricao: EntradaDescricao);
            }
            
                
            
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Listar série");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("c- Limpar Tela");
            Console.WriteLine("x- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
