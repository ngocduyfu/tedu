using System.ComponentModel.DataAnnotations.Schema;

namespace BackendServer.Data.Entities
{
    [Table("CommandInFunctions")]
    public class CommandInFunction
    {
        public int CommandId { get; set; }
        public int FunctionId { get; set; }
    }
}
