using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Chengchen.Demos.Host.Domain.Entities
{
    public class Calendar
    {
        [Key]
        public long Id { get; set; }
        public string Content { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime DueTime { get; set; }

    }
}
