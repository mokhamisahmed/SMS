using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Entities
{
    public class LevelSubject
    {
        public int levelId { get; set; }

        public int subjectId {get; set; }

        public Level level { get; set; }

        public Subject subject { get; set; }


    }
}
