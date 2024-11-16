using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.DAO
{
    public class GroupSubjects
    {
        public int GroupSubjects_id { get; set; }

        public int GroupSubjects_group_id { get; set; }

        public int subject_id { get; set; }

        public int semester { get; set; }

        public virtual Groups Groups { get; set; }

        public virtual subject subject { get; set; }
    }
}
