﻿using BackendServer.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendServer.Data.Entities
{
    [Table("ActivityLogs")]
    public class ActivityLog : IDateTracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Action { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string EntityName { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string EntityId { get; set; }

        public int UserId { get; set; }
        public string Content { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
