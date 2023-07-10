namespace CrudManage.Models
{
    public class UsuarioModel
    {
        public int  Id { get; set; }
        public string? Name { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal ValorRenda { get; set; } 
        public int Cpf { get; set; }
    }
}
