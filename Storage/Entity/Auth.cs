using Microsoft.Extensions.Primitives;

namespace Project.Storage.Entity
{
    public class Auth
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Users Users { get; set; }
    }
}
