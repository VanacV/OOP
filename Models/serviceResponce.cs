using fireflower_backend.Dtos;

namespace fireflower_backend.Models;

public class serviceResponce<T>
{
    public List<productDtos> Data { get; set; }
    public List<paymentDtos> DataPayment { get; set; }
    public bool Success { get; set; } = true;
    public string Messege { get; set; } = string.Empty;
}