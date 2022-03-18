using System.Globalization;
namespace Course
{
    class Produto
    {
        // Quando usamos o private, usamos o padrao de nome = _nome
        // Quando usamos o public, usamos o padrao de nome = Nome
        private string _nome;
        public double Preco { get; private set; } //AutoProperties
        public int Quantidade { get; private set; }

        /*
        Quando criamos um construtor manualmente, 
        o construtor padrao fica indisponivel, 
        ate que nos o criemos explicitamente.
         */

        public Produto()
        {
            // Construtor padrao
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade= quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // Propeties

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}