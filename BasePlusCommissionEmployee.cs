namespace SplitProgram
{
    public partial class BasePlusCommissionEmployee : CommissionEmployee
    {
        public double BaseSalary { get; set; }
        // five-argument constructor
        public BasePlusCommissionEmployee(string name, string ssn, double sales, double rate, double salary) : base(name, ssn, sales, rate)
        {
            BaseSalary = salary; // set base salary
        } // end five-argument BasePlusCommissionEmployee constructor

                                   
    } // end class BasePlusCommissionEmployee
}

