using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    //delegate
    delegate void Intmethod(int x);
    public delegate double TwoLongsOp(long first, long second);
   
    class mathOperations
    {
        public static double MultiplyByTwo(double value)
        {
            return value * 2;
        }

        public static double Square(double value)
        {
            return value * value;

        }
    }


    class Program
    {
        delegate double DoubleOp(double x);
        private delegate string Getstring();
        static void Main(string[] args)
        {
            #region delegate select
            /*
            int x = 40;
            Getstring getstring = new Getstring(x.ToString);
            Console.WriteLine($"string is {getstring()}");
            
            //getstring References an instance method
            Currency balance = new Currency(34, 50);           
            getstring = balance.ToString;
            Console.WriteLine($"String is {getstring()}");

            //getstring References a static method
            
            getstring = new Getstring(Currency.GetCurrencyUnit);
            Console.WriteLine($"string is {getstring()}");
            */
            #endregion


            DoubleOp[] operations1 =
            {
                mathOperations.MultiplyByTwo,
                mathOperations.Square
            };
            Func<double, double>[] operations =
            {
                mathOperations.MultiplyByTwo,
                mathOperations.Square
            };
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine($"Using operations [{i}]");
                ProcessAndDisplayNumber1(operations1[i], 3.0);
                ProcessAndDisplayNumber(operations[i], 3.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                Console.WriteLine() ;
            }

            static void ProcessAndDisplayNumber1(DoubleOp action, double value)
            {
                 double result = action(value);
                Console.WriteLine($"Value is {value},result of operation is {result}");

            }

            static void ProcessAndDisplayNumber(Func<double ,double >action,double value)
            {
                double result = action(value);
                Console.WriteLine($"Value is {value},result of operation is {result}");

            }
            Console.ReadLine();
        }

        struct Currency
        {
            public uint Dollars;
            public ushort Cents;
            public Currency(uint dollars, ushort cents)
            {
                this.Dollars = dollars;
                this.Cents = cents;
            }
            public override string ToString()
            {
                return string.Format($"{Dollars},{Cents,2:00}");
            }
            public static string GetCurrencyUnit()
            {
                return "Dollar";
            }
            public static explicit operator Currency(float value)
            {
                checked
                {
                    uint dollars = (uint)value;
                    ushort cents = (ushort)((value - dollars) * 100);
                    return new Currency(dollars, cents);
                }
            }

            public static implicit operator float(Currency value)
            {
                return value.Dollars + (value.Cents / 100.0f);

            }

            public static implicit operator Currency(uint value)
            {
                return new Currency(value,0);
            }

            public static implicit operator uint (Currency value)
            {
                return value.Dollars;
            }
        }

        #region BubbleSorter
        class BubbleSorter
        {
            static public void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparison)
            {
                bool swapped = true;
                do
                {
                    swapped = false;
                    for (int i = 0; i < sortArray.Count - 1; i++)
                    {
                        if (comparison(sortArray[i + 1], sortArray[i]))
                        {
                            T temp = sortArray[i];
                            sortArray[i + 1] = temp;
                            swapped = true;
                        }
                    }
                }
                while (swapped);
            }
        }
        #endregion

        #region Empolyee
        class Employee
        {
            public string Name { get; private set; }
            public decimal Salary { get; private set; }
            public Employee(string name, Decimal salary)
            {
                this.Name = name;
                this.Salary = salary;
            }
            public override string ToString()
            {
                return string.Format($"{Name}{Salary:c}");
            }
            public static bool CompareSalary(Employee e1,Employee e2)
            {
                return e1.Salary < e2.Salary;
            }
        }
        #endregion 
    }
}
