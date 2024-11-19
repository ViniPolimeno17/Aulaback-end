namespace Construtores.Classes
{
    public class Jogo
    {''
        public string? nome { get; set; }

        public int lancamento { get; set; }
        public string? genero { get; set; }
        public float preco { get; set; }


        public Jogo()
        {
        //     nome = no;
        //     lancamento = lan;
        //     genero = ge;
        //     preco = pre;

            // Console.WriteLine($"O jogo foi criado");

        }
         public void ExibirDados()
        {
            Console.WriteLine(@$"
            Marca: {nome}
            Lançamento: {lancamento}
            Genero: {genero}
            Preço: {preco}
            ");
            
        }
    }
 }