using System;
using System.Collections.Generic;

namespace Entities
{
    public class Receipt
    {
        public int Id { set; get; }

        public DateTime CreatedDate { set; get; }

        public List<ReceiptDetails> receiptDetailsList { set; get; }

        public Receipt()
        {
            receiptDetailsList = new List<ReceiptDetails>();
        }
    }
}
