using System.ComponentModel.DataAnnotations;

namespace DataApprover.Core.Entity;

public class User
{
    public Guid Id { get; set; }
    public int FriendlyId { get; set; }
    public string Name { get; set; }
    public string? Middlename { get; set; }
    public string Surname { get; set; }
    public string FullName => $"{Name} {Middlename} {Surname}";
    public char[] Username { get; set; }
    public char[] Password { get; set; }
}