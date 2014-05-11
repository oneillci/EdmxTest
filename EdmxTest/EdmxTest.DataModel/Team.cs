using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EdmxTest.DataModel
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
