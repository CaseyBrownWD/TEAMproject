using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATproj
{
    internal class StudentSorter : IComparer<Student>
    {

        public StudentOrderMethod SortBy = StudentOrderMethod.Pairs;

        public int Compare(Student x, Student y)
        {
            if (SortBy == StudentOrderMethod.PairsThenTrio)
            {
                if (x.Student > y.Student)
                {
                    return 1;
                }
                if (x.Student < y.Student)
                {
                    return -1;
                }
                return x.Student > y.Student ? 1 : -1;
            }
            if (SortBy == StudentOrderMethod.Trio)
            {
                if (x.Student > y.Student)
                {
                    return 1;
                }
                if (x.Student < y.Student)
                {
                    return -1;
                }
                return x.Student > y.Student ? 1 : -1;
            }
            throw new NotImplementedException($"StudentOrderMethod {SortBy} is not implemented.");

        }
    }
}
