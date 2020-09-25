using System;
using System.ComponentModel.DataAnnotations;

namespace cbtest
{
    public class CbtestEntity
    {
        public CbtestEntity()
        {
            CbtestEntityId = Guid.NewGuid();
        }

        public Guid CbtestEntityId { get; set; }
        [Required]
        [MaxLength(25)]
        public string UserAction { get; set; }
    }
}
