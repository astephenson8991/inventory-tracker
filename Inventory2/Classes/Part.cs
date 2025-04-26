using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory2
{
    //
    //ABSTRACT PART
    //
    public abstract class Part
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public decimal PartPrice { get; set; }
        public int PartInStock { get; set; }
        public int PartMin { get; set; }
        public int PartMax { get; set; }
    }
    //
    //INHOUSE PART
    //
    public class InPart : Part
    {
        public string MachineID { get; set; }

        public InPart(int id, string name, decimal price, int inStock, int min, int max, string machID)
        {
            PartID = id;
            PartName = name;
            PartPrice = price;
            PartInStock = inStock;
            PartMin = min;
            PartMax = max;
            MachineID = machID;
        }
    }
    //
    //OUTSOURCE PART
    //
    public class OutPart : Part
    {
        public string CompanyName { get; set; }

        public OutPart(int id, string name, decimal price, int inStock, int min, int max, string company)
        {
            PartID = id;
            PartName = name;
            PartPrice = price;
            PartInStock = inStock;
            PartMin = min;
            PartMax = max;
            CompanyName = company;
        }
    }
}
