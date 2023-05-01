using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataApprover.Core.Entity;

namespace DataApprover.Core.Interface;

public interface IBaseEntity
{
    [Key]
    Guid Id => Guid.NewGuid();
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    int FriendlyId { get; set; }
    User CreatedBy { get; set; }
    User UpdatedBy { get; set; }
    DateTimeOffset CreateDateTime => DateTimeOffset.Now;
    DateTimeOffset UpdatedDateTime => DateTimeOffset.Now;
    [Timestamp]
    public byte[] RowVersion { get; set; }
}