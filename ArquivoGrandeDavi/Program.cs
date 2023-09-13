namespace Artigo_arquivoTexto;

class Program
{
    static void Main(string[] args)
    {
        //declarando a variavel do tipo StreamWriter
        StreamReader x;

        //Colocando o caminho fisico
        string Caminho = @"C:\Users\sandr\OneDrive\Documentos\Estudo Sandra\AWS Lambda.txt";
        //abrindo um arquivo texto
        x = File.OpenText(Caminho);

        //enquanto nao retornar valor booleano true
        while (x.EndOfStream != true)//quer dizer que não chegou no fim do
                                     //arquivo
        {
            //le conteúdo da linha
            string linha = x.ReadLine();
            //escreve na tela o conteúdo da linha
            Console.WriteLine(linha);
           
        }
        //após sair do while, é porque leu todo o conteúdo, então
        //temos que fechar o arquivo texto que está aberto
        x.Close();

        Console.ReadKey();//esse comando é para não fechar a tela do console
                          //fechar so após o usuário clicar em uma tecla do
                          //teclado
    }
}

//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");
//const string filePath = @"C:\Users\sandr\OneDrive\Documentos\Estudo Sandra\Curso de C# usando herança e implementando interfaces.docx";
//const string fileDavi = @"C:\Users\sandr\OneDrive\Documentos\Estudo Sandra\fazendo teste de arquivo.txt";
////var data = File.ReadAllText(filePath);
//var data = File.ReadAllText(fileDavi);
//Console.WriteLine(data);

////https://www.devmedia.com.br/linguagem-csharp-trabalhando-com-arquivos-de-texto/32326
