using System;

namespace ExercicioFixacaoComposicao.Entities
{
    internal class Client
    {
        // AutoProps
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        // Constructors
        public Client() { }

        public Client(string name, string email, DateTime birthdate)
        {
            Name = name;
            Email = email;
            BirthDate = birthdate;
        }
    }
}
