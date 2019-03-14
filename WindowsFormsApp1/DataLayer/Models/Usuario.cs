namespace WindowsFormsApp1.DataLayer.Models
{
    public sealed class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Cedula { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
    }
}
