using BackendServer.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendServer.Data.Entities
{
    [Table("Comments")]
    public class Comment : IDateTracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)] // Optional: Add a length limit if applicable.
        public string Content { get; set; }

        [ForeignKey("KnowledgeBase")]
        public int KnowledgeBaseId { get; set; }

        [ForeignKey("OwnerUser")]
        public int OwnerUserId { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
