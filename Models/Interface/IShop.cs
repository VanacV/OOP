using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IShop
    {
        Task<IList<Shop>> OutputShop();
    }
}
