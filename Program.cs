using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetStartWithOOP.HR.Entension;

namespace GetStartWithOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo03();
        }

        private static void Demo15()
        {
            {
                int x = 100;
            }
            {
                Nullable<int> x = null;
                if (x.HasValue)
                    Console.WriteLine(x);
                x = 100;
                if (x.HasValue)
                    Console.WriteLine(x);
            }
            {
                int? x = null;
                if (x.HasValue)
                    Console.WriteLine(x);
                x = 100;
                if (x.HasValue)
                    Console.WriteLine(x);
            }
            {
                int? x = null;
                Console.WriteLine(x ?? 0);
                x = 100;
                Console.WriteLine(x ?? 0);
            }
        }

        private static void Demo14_04()
        {
            //var emps = GetHRSampleDataWithID();
            //emps.Where(emp => emp.Age < 20 )
            //    .ToList()
            //    .ForEach(emp => Console.WriteLine(emp.GetInfo()));

            var emps = GetHRSampleDataWithID();
            emps.Where(emp => emp.Age > 20)
                .ToList()
                .ForEach(emp => Console.WriteLine(emp.GetInfo()));
        }

        private static void Demo14_03()
        {
            var emps = GetHRSampleDataWithID();
            var query = from emp in emps
                        where emp.Age < 20
                        select emp;
            query.ToList()
                .ForEach(emp => Console.WriteLine(emp.GetInfo()));
        }

        private static void Demo14_02()
        {
            var emps = GetHRSampleDataWithID();
            emps.ForEach(emp => Console.WriteLine(emp.GetInfo()));
        }

        private static void Demo14_01()
        {
            var emps = GetHRSampleDataWithID();
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.GetInfo());
            }
        }

        private static void Demo13()
        {
            {
                // no return value
                Action act1 = new Action(Action01);
                Action<string> act2 = new Action<string>(Action02);
                // Has return value
                Func<string> fn1 = new Func<string>(Function01);
                Func<string, string> fn2 = new Func<string, string>(Function02);

                act1();
                act2("How is it?");
                Console.WriteLine(fn1());
                Console.WriteLine(fn2("Fine"));
            }

            {
                Console.WriteLine();
                // using Anonymous Method
                int a = 1;
                // no return value
                Action act1 = new Action(delegate()
                {
                    Console.WriteLine((a++) + ": Hello world !!!");
                });
                Action<string> act2 = new Action<string>(delegate(string msg)
                {
                    Console.WriteLine((a++) + ": Hello world !!! " + msg);
                });
                // Has return value
                Func<string> fn1 = new Func<string>(delegate()
                {
                    Console.WriteLine((a++) + ": Hello world !!!");
                    return "done";
                });
                Func<string, string> fn2 = new Func<string, string>(delegate(string msg)
                {
                    Console.WriteLine((a++) + ": Hello world !!! " + msg);
                    return "done";
                });

                act1();
                act2("How is it?");
                Console.WriteLine(fn1());
                Console.WriteLine(fn2("Fine"));
            }

            {
                Console.WriteLine();
                // using Anonymous Method
                int a = 1;
                // no return value
                Action act1 = delegate()
                {
                    Console.WriteLine((a++) + ": Hello world !!!");
                };
                Action<string> act2 = delegate(string msg)
                {
                    Console.WriteLine((a++) + ": Hello world !!! " + msg);
                };
                // Has return value
                Func<string> fn1 = delegate()
                {
                    Console.WriteLine((a++) + ": Hello world !!!");
                    return "done";
                };
                Func<string, string> fn2 = delegate(string msg)
                {
                    Console.WriteLine((a++) + ": Hello world !!! " + msg);
                    return "done";
                };

                act1();
                act2("How is it?");
                Console.WriteLine(fn1());
                Console.WriteLine(fn2("Fine"));
            }

            {
                Console.WriteLine();
                // using Lamda Expression
                int a = 1;
                // no return value
                Action act1 = () =>
                {
                    Console.WriteLine((a++) + ": Hello world !!!");
                };
                Action<string> act2 = (string msg) =>
                {
                    Console.WriteLine((a++) + ": Hello world !!! " + msg);
                };
                // Has return value
                Func<string> fn1 = () =>
                {
                    Console.WriteLine((a++) + ": Hello world !!!");
                    return "done";
                };
                Func<string, string> fn2 = (string msg) =>
                {
                    Console.WriteLine((a++) + ": Hello world !!! " + msg);
                    return "done";
                };

                act1();
                act2("How is it?");
                Console.WriteLine(fn1());
                Console.WriteLine(fn2("Fine"));
            }

            {
                Console.WriteLine();
                // using Lamda Expression
                int a = 1;
                // no return value
                Action act1 = () =>
                {
                    Console.WriteLine((a++) + ": Hello world !!!");
                };
                Action<string> act2 = (msg) =>
                {
                    Console.WriteLine((a++) + ": Hello world !!! " + msg);
                };
                // Has return value
                Func<string> fn1 = () =>
                {
                    Console.WriteLine((a++) + ": Hello world !!!");
                    return "done";
                };
                Func<string, string> fn2 = (msg) =>
                {
                    Console.WriteLine((a++) + ": Hello world !!! " + msg);
                    return "done";
                };

                act1();
                act2("How is it?");
                Console.WriteLine(fn1());
                Console.WriteLine(fn2("Fine"));
            }

            {
                Console.WriteLine();
                // using Lamda Expression
                int a = 1;
                // no return value
                Action act1 = () => Console.WriteLine((a++) + ": Hello world !!!");
                Action<string> act2 = msg => Console.WriteLine((a++) + ": Hello world !!! " + msg);
                // Has return value
                Func<string> fn1 = () =>
                {
                    Console.WriteLine((a++) + ": Hello world !!!");
                    return "done";
                };
                Func<string, string> fn2 = msg =>
                {
                    Console.WriteLine((a++) + ": Hello world !!! " + msg);
                    return "done";
                };
                Func<string, string> fn3 = msg => String.Format("{0}: Hello world !!! {1}", a++, msg);

                act1();
                act2("How is it?");
                Console.WriteLine(fn1());
                Console.WriteLine(fn2("Fine"));
                Console.WriteLine(fn3("Also can"));
            }
        }

        private static string Function02(string msg)
        {
            Console.WriteLine("Hello world !!! " + msg);
            return "done";
        }

        private static string Function01()
        {
            Console.WriteLine("Hello world !!!");
            return "done";
        }

        private static void Action02(string msg)
        {
            Console.WriteLine("Hello world !!! " + msg);
        }

        private static void Action01()
        {
            Console.WriteLine("Hello world !!!");
        }

        private static void Demo12()
        {
            var emps = GetHRSampleDataWithID();
            foreach (var emp in emps)
            {
                Console.WriteLine(HR.Utilites.CommonUtility.GetFullname(emp));
            }
            Console.WriteLine();
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.GetFullname());
            }
        }

        private static void Demo11()
        {
            var VendorMeeting = new Events.Meeting<IT.Vendor, HR.PermanentEmployee, HR.PermanentEmployee>();
            var InhourseMeeting = new Events.Meeting<HR.PermanentEmployee, HR.Employee, HR.PermanentEmployee>();
            var ParttimerMeeting = new Events.Meeting<HR.Employee, HR.PartTimeEmployee, HR.PartTimeEmployee>();

            //var wM1 = new Events.Meeting<Int32, Int64>();
        }

        private static void Demo10()
        {
            {
                var col = new System.Collections.ArrayList();
                col.Add(1);
                col.Add(new IT.Vendor());

                object o = col[0];
                IT.Vendor v = col[1] as IT.Vendor;
            }
            {
                var col = new List<IT.Vendor>();
                col.Add(new IT.Vendor());

                IT.Vendor v = col[0];
            }
        }

        private static void Demo09()
        {
            var newEmployment = new HR.Employment();

            newEmployment.InHouseReview += InterviewProcess;
            newEmployment.Recuiments += InterviewProcess;

            var emps = GetHRSampleDataWithID();

            newEmployment.StartInterview(emps);
        }

        private static bool InterviewProcess(string fn, byte age)
        {
            return (age >= 18);
        }

        private static void Demo08()
        {
            // Dynamic Class
            dynamic emp = new System.Dynamic.ExpandoObject();
            emp.firstname = "James";
            emp.lastname = "Hong";
        }

        private static void Demo07()
        {
            // Anonymous Class
            var o = new {
                firstname = "James",
                lastname = "Hong"
            };

            var emps = GetHRSampleDataWithID();

            var query = from rcd in emps
                        where rcd is Common.IContractable
                        select new { 
                            Fullname = String.Format("{0} {1}", rcd.Firstname, rcd.Lastname),
                            Age = rcd.Age,
                            ContractNumber = (rcd as Common.IContractable).GetContractNumber()
                        };
            foreach (var emp in query.ToList())
            {
                Console.WriteLine("Contract base employee {0} is age {1} and the document number is {2}",
                    emp.Fullname, emp.Age, emp.ContractNumber);
            }
        }

        private static void Demo06()
        {
            var emps = GetHRSampleDataWithID();

            var query = from rcd in emps
                        where rcd is Common.IContractable
                        select rcd as Common.IContractable;
            foreach (Common.IContractable emp in query.ToList())
            {
                Console.WriteLine("Employee contract {0} {1}", 
                    emp.GetContractNumber(), emp.IsValid()? "is valid": "not valid");
            }

            Common.IContractable[] c = { 
                                           query.First(),
                                           new IT.Vendor()
                                       };
        }

        private static List<HR.Employee> GetHRSampleDataWithID()
        {
            var emps = GetHRSampleData();

            foreach (var emp in emps)
            {
                emp.Employ();
            }
            return emps;
        }

        private static void Demo05()
        {
            var emps = GetHRSampleData();

            foreach (var emp in emps)
            {
                emp.Employ();
            }

            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
        }

        private static void Demo04_03()
        {
            var emps = GetHRSampleData();
            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
        }

        private static void Demo04_02()
        {
            // solution with overriding
            var emps = GetHRSampleData();
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.GetInfo());
            }
        }

        private static void Demo04_01()
        {
            // problem
            var emps = GetHRSampleData();
            foreach (var emp in emps)
            {
                if (emp is HR.PartTimeEmployee)
                {
                    var e = emp as HR.PartTimeEmployee;
                    // ...
                }
                else if (emp is HR.LocalPEmployee)
                {
                    var e = emp as HR.LocalPEmployee;
                    // ...
                }
                else if (emp is HR.ForentPEmployee)
                {
                    var e = emp as HR.ForentPEmployee;
                    // ...
                }
            }
        }

        //private static List<HR.Employee> GetHRSampleData()
        //{
        //    return new List<HR.Employee>()
        //    {
        //        new HR.PartTimeEmployee(Common.Gender.Male, 24) 
        //       { Firstname="Alex", Lastname="Wong", HourlyRate=1.5, WorkingHours=100.5 },
        //        new HR.PartTimeEmployee(Common.Gender.Male, 20) { Firstname="Bin", Lastname="Jeff", 
        //            HourlyRate=1.0, WorkingHours=110.0 },
        //        new HR.LocalPEmployee(Common.Gender.Male, 18) { Firstname="Ali", Lastname="Baba", 
        //            BaseSalary=2000.0, IDNumber="123456-45-1234" },
        //        new HR.LocalPEmployee(Common.Gender.Female, 19) { Firstname="Cindy", Lastname="Tan", 
        //            BaseSalary=2500.0, IDNumber="112233-44-5566" },
        //        new HR.ForentPEmployee(Common.Gender.Male, 30) { Firstname="Mice", Lastname="Dom", 
        //            BaseSalary=3500.0, ContractReferenceCode="C-123456", PassportNumber="X12345" },
        //        new HR.ForentPEmployee(Common.Gender.Female, 21) { Firstname="Fiona", Lastname="Hue", 
        //            BaseSalary=3000.0, ContractReferenceCode="C-456899", PassportNumber="Y4455668" },
        //        new HR.ContractEmployee(Common.Gender.Female, 20) { Firstname="Rola", Lastname="Vix", 
        //            ContractSalary=5000.0, ContractDocumentCode="X-123456" },
        //        new HR.ContractEmployee(Common.Gender.Female, 18) { Firstname="Fendy", Lastname="Xe", 
        //            ContractSalary=5000.0, ContractDocumentCode="X-456899" }
        //    };
        //}
        
        //TODO GetHRSampleData: 1. To list all HR list
        private static List<HR.Employee> GetHRSampleData()
        {
            return new List<HR.Employee>()
            {
                new HR.PartTimeEmployee(Common.Gender.Male, 27)
                {
                    Firstname="Arya", Lastname="Stark", HourlyRate=1.5, WorkingHours=100.5
                },

                new HR.LocalPEmployee(Common.Gender.Male, 28)
                {
                    Firstname="Jon", Lastname="Snow", BaseSalary=2000.0, IDNumber="841110-08-5460", Allowance=20.0
                },

                new HR.ForentPEmployee(Common.Gender.Female, 29)
                {
                    Firstname="Robb", Lastname="Stark", ContractReferenceCode="987939", PassportNumber="983993888788" 
                },

            };
        }

        private static void Demo03()
        {
            {
                int x1 = 10;
                long y = x1;

                int x2 = (int)y;
            }
            {
                HR.PartTimeEmployee pt1 = new HR.PartTimeEmployee();
                HR.Employee e = pt1;

                #region Non Type Safe Operation
                // Below 2 success
                {
                    // if fail throw error : System.InvalidCastException
                    HR.PartTimeEmployee pt2 = (HR.PartTimeEmployee)e;
                    Console.WriteLine(pt2);
                }
                {
                    // if fail return null
                    HR.PartTimeEmployee pt2 = e as HR.PartTimeEmployee;
                    Console.WriteLine(pt2);
                }
                // Below 2 fail on runtime
                {
                    // if fail throw error : System.InvalidCastException
                    HR.PermanentEmployee pm = (HR.PermanentEmployee)e;
                    Console.WriteLine(pm);
                }
                {
                    // if fail return null
                    HR.PermanentEmployee pm = e as HR.PermanentEmployee;
                    Console.WriteLine(pm);
                }
                #endregion

                #region Type Safe Operation
                {
                    if (e is HR.PermanentEmployee)
                    {
                        HR.PermanentEmployee pm = (HR.PermanentEmployee)e;
                        Console.WriteLine(pm);
                    }
                }
                {
                    // if fail return null
                    HR.PermanentEmployee pm = e as HR.PermanentEmployee;
                    if (pm != null)
                        Console.WriteLine(pm);
                }
                #endregion
            }
        }

        private static void Demo02()
        {
            //HR.Employee e = new HR.Employee();
            HR.PartTimeEmployee pt = new HR.PartTimeEmployee();
            HR.ForentPEmployee ft = new HR.ForentPEmployee();

            HR.Employee[] emps = { /* e, */ pt, ft };
        }

        private static void Demo01()
        {
            HR.OldSchool.Employee[] emps;
            HR.OldSchool.PartTimeEmployee[] ptemps;

            System.Collections.ArrayList Employees;
        }
    }
}
