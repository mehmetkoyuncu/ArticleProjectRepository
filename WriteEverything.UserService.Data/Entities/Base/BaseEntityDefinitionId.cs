using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteEverything.UserService.Data.Entities.Base
{
    public abstract class BaseEntityDefinitionId:BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
