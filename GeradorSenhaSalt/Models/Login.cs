namespace EscritorioVirtual.Shared.Models
{
    public class Login
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Username { get; set; }

        public string Senha { get; set; }

        public string Salt { get; set; }
    }

}
