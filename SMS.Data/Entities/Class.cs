using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Entities
{
    public class Class
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int levelId { get; set; }

        public Level level { get; set; }

        public List<Student> students { get; set; }

    }
}
