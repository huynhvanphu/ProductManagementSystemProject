using System;
using Entities;
using DAL;
using System.IO;

namespace BusinessServices
{
    public class InventoryReceiptService : ReceiptService
    {
        public InventoryReceiptService() : base(FilePathList.pathToInventoryReceipts)
        {
            
        }
    }
}
