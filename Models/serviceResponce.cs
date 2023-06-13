using fireflower_backend.Dtos;
using System.Collections.Generic;

namespace fireflower_backend.Models;

public class serviceResponce<T>
{
    public List<T> Data { get; set; }
    public bool Success { get; set; } = true;
    public string Message { get; set; } = string.Empty;
}