using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.DAO
{
    public class GroupSemesters
    {
        public int group_semester_id {  get; set; }

        public int group_id { get; set; }

        public int semester_id { get; set;}

        public virtual Groups Groups { get; set; }

        public virtual semesters semesters { get; set; }


    }
}
