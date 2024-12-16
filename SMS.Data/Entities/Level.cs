using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Entities
{
    public class Level
    {

        public int Id { get; set; }

        public string LevelName { get; set; }

         public List<Subject> subjects { get; set; }

    }
}
