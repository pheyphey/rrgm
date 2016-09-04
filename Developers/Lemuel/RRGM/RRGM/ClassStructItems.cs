using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRGM
{
    class ClassStructItems
    {
        private string item_ID, description, price, last_cost_unit, item_type, location, safe_level, critical_level, reorder_level, qty_Hand, qty_SO, qty_PO, supplier_ID;

        public string ITEMID
        {
            get { return item_ID; }
            set { item_ID = value; }
        }

        public string DESCRIPTION
        {
            get { return description; }
            set { description = value; }
        }

        public string PRICE
        {
            get { return price; }
            set { price = value; }
        }

        public string LASTCOSTUNIT
        {
            get { return last_cost_unit; }
            set { last_cost_unit = value; }
        }

        public string ITEMTYPE
        {
            get { return item_type; }
            set { item_type = value; }
        }

        public string LOCATION
        {
            get { return location; }
            set { location = value; }
        }

        public string SAFELEVEL
        {
            get { return safe_level; }
            set { safe_level = value; }
        }

        public string CRITICALLEVEL
        {
            get { return critical_level; }
            set { critical_level = value; }
        }

        public string REORDERLEVEL
        {
            get { return reorder_level; }
            set { reorder_level = value; }
        }

        public string QTYHAND
        {
            get { return qty_Hand; }
            set { qty_Hand = value; }
        }

        public string QTYSO
        {
            get { return qty_SO; }
            set { qty_SO = value; }
        }

        public string QTYPO
        {
            get { return qty_PO; }
            set { qty_PO = value; }
        }

        public string SUPPLIERID
        {
            get { return supplier_ID; }
            set { supplier_ID = value; }
        }
    }
}
