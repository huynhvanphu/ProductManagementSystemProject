using System;
using Entities;
using DAL;
using System.IO;

namespace BusinessServices
{
    public class SalesReceiptService : ReceiptService
    {
        public SalesReceiptService() : base(FilePathList.pathToSalesReceipts)
        {
            
        }
    }
}
