using System.Globalization;
namespace Course
{
    class Produto
    {
        // Quando usamos o private, usamos o padrao de nome = _nome
        // Quando usamos o public, usamos o padrao de nome = Nome
        private string _nome;
        private double _preco;
        private int _quantidade;

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
            _preco = preco;
            _quantidade = quantidade;
        }

        // Metodos GET e SET

        /*public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }*/

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
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

        public double Preco { get { return _preco; } }

        public int Quantidade { get { return _quantidade; } }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}