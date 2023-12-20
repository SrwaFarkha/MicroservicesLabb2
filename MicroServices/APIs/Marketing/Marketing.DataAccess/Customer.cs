using System.Runtime.Serialization;
using Domain.Common.Interfaces.DataAccess;

namespace Marketing.DataAccess;

public class Customer : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}