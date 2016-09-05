using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesInventory
{
    class ClassStructItems
    {
        private string item_id, item_desc, price, last_unit_cost, item_type, location, safe_lvl, critical_lvl, reorder_lvl, qty_hand, qty_so, qty_po, preffered_supplier_id;

        public string ITEM_ID
        {
            get { return item_id; }
            set { item_id = value; }
        }
        public string ITEM_DESC
        {
            get { return item_desc; }
            set { item_desc = value; }
        }
        public string PRICE
        {
            get { return price; }
            set { price = value; }
        }
        public string LAST_UNIT_COST
        {
            get { return last_unit_cost; }
            set { last_unit_cost = value; }
        }
        public string ITEM_TYPE
        {
            get { return item_type; }
            set { item_type = value; }
        }
        public string LOCATION
        {
            get { return location; }
            set { location = value; }
        }
        public string SAFE_LEVEL
        {
            get { return safe_lvl; }
            set { safe_lvl = value; }
        }
        public string CRITICAL_LEVEL
        {
            get { return critical_lvl; }
            set { critical_lvl = value; }
        }
        public string REORDER_LEVEL
        {
            get { return reorder_lvl; }
            set { reorder_lvl = value; }
        }
        public string QTY_HAND
        {
            get { return qty_hand; }
            set { qty_hand = value; }
        }
        public string QTY_SO
        {
            get { return qty_so; }
            set { qty_so = value; }
        }
        public string QTY_PO
        {
            get { return qty_po; }
            set { qty_po = value; }
        }
        public string PREFFERED_SUPPLIER_ID
        {
            get { return preffered_supplier_id; }
            set { preffered_supplier_id = value; }
        }
    }
}
