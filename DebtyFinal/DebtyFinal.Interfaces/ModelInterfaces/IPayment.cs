using System;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.Interfaces.ModelInterfaces
{
    public interface IPayment
    {
        Guid PaymentID { get; set; }
        string PaymentDesc { get; set; }
        DateTime PaymentDate { get; set; }
        decimal PaymentAmount { get; set; }
    }
}
