using fireflower_backend.Models.Realization;
using fireflower_backend.Storage.Entity;
using Project.Models;

namespace fireflower_backend.Models.Interface
{
    public interface IShop
    {
       Task<serviceResponce<List<Shop>>> GetAllShop();
    }
}
