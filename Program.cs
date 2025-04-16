using System;
using System.IO;

class Program
{
    static void Main()
    {
        bool executando = true;

        while (executando)
        {
            Console.Clear();
            Console.WriteLine("===== Otimizador de PC =====");
            Console.WriteLine("1 - Limpar pastas TEMP");
            Console.WriteLine("9 - Configurações");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    LimparPastasTemp();
                    break;
                case "9":
                    MenuConfiguracoes();
                    break;
                case "0":
                    executando = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (executando)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }

    #region |Funções|

    static void LimparPastasTemp()
    {
        string tempPath = Path.GetTempPath();
        int arquivosDeletados = 0;

        try
        {
            foreach (string arquivo in Directory.GetFiles(tempPath))
            {
                try
                {
                    File.Delete(arquivo);
                    arquivosDeletados++;
                }
                catch { }
            }

            foreach (string pasta in Directory.GetDirectories(tempPath))
            {
                try
                {
                    Directory.Delete(pasta, true);
                }
                catch { }
            }

            Console.WriteLine($"Pasta TEMP limpa com sucesso! {arquivosDeletados} arquivos deletados.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao limpar a pasta TEMP: " + ex.Message);
        }
    }

    static void MenuConfiguracoes()
    {
        Console.Clear();
        Console.WriteLine("===== Configurações =====");
        Console.WriteLine("1 - Exemplo de opção futura");
        Console.WriteLine("0 - Voltar");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Configuração ainda não implementada.");
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    #endregion
}
