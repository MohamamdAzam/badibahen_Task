using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace StudentBillingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentBillingController : ControllerBase
    {
        // Endpoint to retrieve student bills for a given student ID.
        [HttpGet("student/{studentId}/bills")]
        public ActionResult<List<Bill>> GetStudentBills(int studentId)
        {
            // Implement the logic to retrieve student bills from the database based on the studentId.
            throw new NotImplementedException();
        }

        // Endpoint to make a payment for a specific bill.
        [HttpPost("bill/{billId}/payment")]
        public IActionResult MakePayment(int billId, [FromBody] PaymentInfo paymentInfo)
        {
            // Implement the logic to make a payment for the given billId and update the database accordingly.
            throw new NotImplementedException();
        }

        // Endpoint to retrieve payment history for a student.
        [HttpGet("student/{studentId}/payment-history")]
        public ActionResult<List<Payment>> GetPaymentHistory(int studentId)
        {
            // Implement the logic to retrieve payment history from the database based on the studentId.
            throw new NotImplementedException();
        }
    }

    // Define your data models (Bill, Payment, PaymentInfo) here to be used in the controller.
    public class Bill
    {
        // Define the properties of a Bill here.
    }

    public class Payment
    {
        // Define the properties of a Payment here.
    }

    public class PaymentInfo
    {
        // Define the properties required for making a payment here.
    }
}
