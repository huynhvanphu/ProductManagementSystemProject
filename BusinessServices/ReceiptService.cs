using System;
using Entities;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace BusinessServices
{
    public class ReceiptService
    {
        public ReceiptService(string FilePath)
        {
            dalReceipt = new DAL_Receipt(FilePath);
            receipts = new List<Receipt>();
        }

        private DAL_Receipt dalReceipt { set; get; }

        public List<Receipt> receipts { set; get; }

        public List<Receipt> ReadReceipts() => dalReceipt.ReadReceipts();

        public bool SaveReceipt(Receipt receipt) => dalReceipt.SaveReceipt(receipt);

        public int GenerateID()
        {
            int maxID = 0;
            receipts = dalReceipt.ReadReceipts();

            if (receipts.Count == 0)
            {
                return 1;
            }
            else
            {
                foreach (var i in receipts)
                {
                    if (maxID < i.Id) maxID = i.Id;
                }
            }
            return maxID + 1;
        }
        public Receipt FindReceiptById(int id)
        {
            receipts = dalReceipt.ReadReceipts();

            var result = receipts.Where(i => i.Id == id).FirstOrDefault();

            if (result == null) throw new Exception("Không tìm thấy hoá đơn");

            return result;

        }
        public void DeleteReceipts(int id) => dalReceipt.DeleteReceipt(id);

        public List<Receipt> SortDate(DateTime fromDate, DateTime toDate)
        {
            receipts = dalReceipt.ReadReceipts();
            var result = from i in receipts
                         where i.CreatedDate.Date >= fromDate.Date && i.CreatedDate.Date <= toDate.Date
                         select i;

            return result.ToList();
        }
    }
}
