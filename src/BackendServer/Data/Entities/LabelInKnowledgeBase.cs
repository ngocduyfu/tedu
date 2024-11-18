using System.ComponentModel.DataAnnotations.Schema;

namespace BackendServer.Data.Entities
{
    [Table("LabelInKnowledgeBases")]
    public class LabelInKnowledgeBase
    {
        [ForeignKey("Label")]
        public int LabelId { get; set; }

        [ForeignKey("KnowledgeBase")]
        public int KnowledgeBaseId { get; set; }
    }
}
