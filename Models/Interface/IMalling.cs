using fireflower_backend.Dtos;

namespace fireflower_backend.Models.Interface
{
    public interface IMalling
    {
        Task<serviceResponce<userMailingDtos>> AddMailing(userMailingDtos userMailingDtos);
    }
}
