namespace ExercicioFixacao
{
    internal class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Student(string nome, string email, int room)
        {
            Name = nome;
            Email = email;
            Room = room;
        }

        public override string ToString()
        {
            return $"{Room}: {Name}, {Email}";
        }
    }
}
