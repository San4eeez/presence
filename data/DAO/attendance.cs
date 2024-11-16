using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.DAO
{
    public class attendance
    {
        public int attendance_id {  get; set; }

        public int lesson_number { get; set; }

        public DateTime date { get; set; }



        public int student_id {  get; set; }
        public virtual students students { get; set; }



        public int subject_id { get; set; }
        public virtual subject subject { get; set; }      


        public int status_id { get; set; }

        public virtual status status { get; set; }


    }
}
