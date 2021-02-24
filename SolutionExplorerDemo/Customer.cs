using System;

namespace SolutionExplorerDemo
{
    public class Customer
    {
        public Customer()
        {
        }
        public DateTime? PaidUpTo { get; set; }
        public Status CurrentStatus
        {
            get
            {
                if (this.PaidUpTo.HasValue == false)
                {
                    return Status.Temporary;
                }
                if (this.PaidUpTo > DateTime.Today)
                {
                    return Status.Financial;
                }
                else
                {
                    if (this.PaidUpTo >= DateTime.Today.AddMonths(-3))
                        return Status.Unfinancial;
                    else
                        return Status.Suspended;
                }
            }
        }
    }
}