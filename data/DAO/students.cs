using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.DAO
{
    public class students
    {
        public int students_id {  get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        public string patronymic { get; set; }

        public int group_id { get; set; }

        public virtual Groups Groups { get; set; }
    }
}
