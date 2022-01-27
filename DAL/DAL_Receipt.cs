using System;
using System.Collections.Generic;
using System.IO;
using Entities;
using Newtonsoft.Json;

namespace DAL
{
    public class DAL_Receipt
    {
        public DAL_Receipt(string _FilePath)
        {
            FilePath = _FilePath;
        }

        private string FilePath { set; get; }

        public List<Receipt> ReadReceipts()
        {
            StreamReader stream = new StreamReader(FilePath);

            List<Receipt> receipts = JsonConvert.DeserializeObject<List<Receipt>>(stream.ReadToEnd());

            stream.Close();

            return receipts;
        }
        public bool SaveReceiptsList(List<Receipt> receipts)
        {
            if (!File.Exists(FilePath))
            {
                throw new Exception("File lưu trữ không tồn tại");
            }
            StreamWriter stream = new StreamWriter(FilePath);
            string jsonFile = JsonConvert.SerializeObject(receipts);
            stream.Write(jsonFile);
            stream.Close();
            return true;
        }
        public bool SaveReceipt(Receipt receipt)
        {
            List<Receipt> receiptsList = ReadReceipts();

            int index = -1;

            index = receiptsList.FindIndex(i => i.Id == receipt.Id);

            if (index == -1)
            {
                receiptsList.Add(receipt);
            }
            else
            {
                receiptsList[index] = receipt;
            }
            return SaveReceiptsList(receiptsList);
        }
        public void DeleteReceipt(int id)
        {
            List<Receipt> inventoryReceipts = ReadReceipts();

            int index = -1;

            index = inventoryReceipts.FindIndex(inv => inv.Id == id);

            if (index != -1)
            {
                inventoryReceipts.RemoveAt(index);

                SaveReceiptsList(inventoryReceipts);
            }
        }
    }
}
