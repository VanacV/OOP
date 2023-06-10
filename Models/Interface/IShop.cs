using fireflower_backend.Models.Realization;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IShop
    {
       Task<List<Shop>>GetAllShop();
    }
}
