using System.ComponentModel.DataAnnotations.Schema;


namespace RpgApi.Models;

    public class Usuario
    { 
        //Propriedade que vai guardar o token =)
        //O Token não será guardado no banco, por isso não será mapeado no migrations
        [NotMapped]
        public string token { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] Foto { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? DataAcesso { get; set; }
        [NotMapped]
        public string PasswordString { get; set; }
        public List<Personagem> Personagens { get; set; }
        public string Perfil { get; set; }
        public string Email { get; set; }
    }
