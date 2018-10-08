using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.HR
{
    class Employment
    {
        public Common.InterviewHandler InHouseReview;
        public event Common.InterviewHandler Recuiments;

        public void StartInterview(IEnumerable<HR.Employee> candidates)
        {
            foreach (var candidate in candidates)
            {
                if (InHouseReview != null)
                {
                    if (InHouseReview(candidate.Firstname + " " + candidate.Lastname,
                        candidate.Age))
                        candidate.Employ();
                }
            }
        }

        public void StartRecuiments(IEnumerable<HR.Employee> candidates)
        {
            foreach (var candidate in candidates)
            {
                if (Recuiments != null)
                {
                    if (Recuiments(candidate.Firstname + " " + candidate.Lastname,
                        candidate.Age))
                        candidate.Employ();
                }
            }
        }
    }
}
