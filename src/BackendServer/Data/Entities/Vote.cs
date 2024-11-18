using BackendServer.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendServer.Data.Entities
{
    [Table("Votes")]
    public class Vote : IDateTracking
    {
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string UserId { get; set; }

        [Required]
        [ForeignKey("KnowledgeBase")]
        public int KnowledgeBaseId { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
