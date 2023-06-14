using System.Text.Json.Serialization;
using Microsoft.Extensions.Primitives;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Storage.Entity
{
    public class Auth
    {
        public int Id { get; set; } 
        public string email { get; set; }
        public int phone { get; set; }
        public string password { get; set; }
        public Users Users { get; set; }
    }
}
