using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIUT.DAL
{
    partial class ApplicantManager
    {
        public List<Applicant> Sort(ByAttribute attribute)
        {
            var result = GetAll();

            switch (attribute)
            {
                case ByAttribute.Name:
                    result.Sort(new ByNameComparer());
                    return result;
                case ByAttribute.Surname:
                    result.Sort(new BySurnameComparer());
                    return result; 
                case ByAttribute.DoB:
                    result.Sort(new ByDoBComparer());
                    return result;
                case ByAttribute.Course:
                    result.Sort(new ByCourseComparer());
                    return result;
            }

            //if we are here - something went wrong
            return null;
        }

        public List<Applicant> SortLinq(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAll().OrderBy(a => a.Name).ToList();
                case ByAttribute.Surname:
                    var result = from a in GetAll() orderby a.Surname select a;
                    return result.ToList();
                case ByAttribute.DoB:
                    return GetAll().OrderBy(a => a.DoB).ToList();
                case ByAttribute.Course:
                    return GetAll().OrderBy(a => a.Course.Name).ToList();
            }

            //if we are here - something went wrong
            return null;
        }

        public List<Applicant> Search(string value, ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    var result = from a in GetAll() where a.Name.ToUpper().Contains(value.ToUpper()) select a;
                    return result.ToList();
                case ByAttribute.Surname:
                    return GetAll().Where(a => a.Surname.ToUpper().Contains(value.ToUpper())).ToList();
            }

            //if we are here - something went wrong
            return null;
        }


        #region Comparers
        private class ByNameComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }
        
        private class BySurnameComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.Surname, y.Surname);
            }
        }
        
        private class ByDoBComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return DateTime.Compare(x.DoB, y.DoB);
            }
        }
        
        private class ByCourseComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.Course.Name, y.Course.Name);
            }
        }
        #endregion
    }
}
