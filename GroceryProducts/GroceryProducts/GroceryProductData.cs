using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryProducts
{
    class GroceryProductData
    {
        private string ID;
        private string description;
        private string lastDaySold;
        private string shelfLife;
        private string department;
        private string price;
        private string unitOfMeasure;
        private string xFor;
        private string cost;

        //////Constructors//////
        //////Constructors//////
        //////Constructors//////
        public GroceryProductData()
        {
            setID("-1");
            setDescription("something");
            setLastSold("0/0/1900");
            setShelfLife("-1D");
            setDepartment("some Department");
            setPrice("0.0");
            setUnitOfMeasure("N/A");
            setxFor("-1");
            setCost("0.0");
        }

        public GroceryProductData(string[] data)
        {
            setID(data[0]);
            setDescription(data[1]);
            setLastSold(data[2]);
            setShelfLife(data[3]);
            setDepartment(data[4]);
            setPrice(data[5]);
            setUnitOfMeasure(data[6]);
            setxFor(data[7]);
            setCost(data[8]);
        }

        //////accessors//////
        //////accessors//////
        //////accessors//////
        /**
         * returns the ID
         * used string.Copy so calling class never has direct access to the private var memory location
         * @return Type: string - returns the (ID) identification number of the item
         */
        public string getID()
        {
            return string.Copy(ID);
            
        }

        /**
         * returns the description of the item
         * used string.Copy so calling class never has direct access to the private var memory location
         * @return Type: string - returns the items name/description
         */
        public string getDescription()
        {
            return string.Copy(description);
        }

        /**
         * Returns the getLastSold all as one date
         * @return Type: string - returns the date in US fashion style (MM/DD/YYYY)
         */
        public string getLastSold()
        {
            return string.Copy(lastDaySold);
        }

        

        /**
         * returns the shelf life in form (#T)
         * where # is amount and T is unit of time (d = days, m = month, y = years)
         * used string.Copy so calling class never has direct access to the private var memory location
         * @return Type: string - returns the items shelflife
         */
        public string getShelfLife()
        {
            return string.Copy(shelfLife);
        }

        /**
         * returns the name of the department the item is located
         * used string.Copy so calling class never has direct access to the private var memory location
         * @return Type: string - returns the items department
         */
        public string getDepartment()
        {
            return string.Copy(department);
        }

        /**
         * returns the price of the item sold
         * used temp var so calling class never has direct access to private var memory location
         * @return Type: string - returns the price of the item in form: $##.##
         */
        public string getPrice()
        {
            //uses number format to format price in the local location US
            //return NumberFormat.getCurrencyInstance(new Locale("en", "US")).format(price);
            return price;
        //TODO:
  //////////////////////////////////////////////////////////////////////////////////////
        }

        /**
         * returns the unit of measurement (i.g.  lb = limb/pound, each = per item)
         * used string.Copy so calling class never has direct access to the private var memory location
         * @return Type: string - returns the items unit of measurement
         */
        public string getUnitOfMeasure()
        {
            return string.Copy(unitOfMeasure);
        }

        /**
         * returns the xFor of the item
         * used string.Copy so calling class never has direct access to the private var memory location
         * ??What is an xFor?? - for causing head aches silly!
         * @return Type: string - returns the items xFor
         */
        public string getxFor()
        {
            return string.Copy(xFor);
        }

        /**
         * returns the cost of the item to HEB
         * used string.Copy so calling class never has direct access to the private var memory location
         * @return Type: int - returns the cost of the item
         */
        public string getCost()
        {
            return string.Copy(cost);
        }





        //////modifiers//////
        //////modifiers//////
        //////modifiers//////

        /**
         * sets the description of the item
         * @param desc is the description of the item
         */
        public void setDescription(string desc)
        {
            this.description = desc;
        }

        /**
         * sets the ID of the item
         * @param ID is the ID of the item
         */
        public void setID(string ID)
        {
            this.ID = ID;
        }

        /**
         * sets the last day sold of the item
         * this will break up the string and set the individual day, month, and year item was sold
         * this is broken up so when we sort by date we can sort by in order of year-month-day
         * @param lastDaySold is the date in format (MM/DD/YYYY) the item was last sold
         */
        public void setLastSold(string lastDaySold)
        {
            this.lastDaySold = lastDaySold;
        }

        /**
         * sets the shelf life in for (#T)
         * Where # = amount and T = unit in time (d = day, m = month, y = year)
         * @param shelfLife is the shelf life of the item
         */
        public void setShelfLife(string shelfLife)
        {
            this.shelfLife = shelfLife;
        }

        /**
         * sets the department the item is catagorized at in HEB
         * @param department is the department the item should fall under
         */
        public void setDepartment(string department)
        {
            this.department = department;
        }

        /**
         * sets the price of the item
         * @param price is the price of the item to be sold to the public
         */
        public void setPrice(string price)
        {
            this.price = price;
        }

        /**
         * sets the unit of measure (i.g. lb = limbs/pounds, each = per item)
         * @param unitOfMeasure is the unit the item is measured in at HEB
         */
        public void setUnitOfMeasure(string unitOfMeasure)
        {
            this.unitOfMeasure = unitOfMeasure;
        }

        /**
         * sets the xFor of the item
         * @param xFor is the xFor for the item
         */
        public void setxFor(string xFor)
        {
            this.xFor = xFor;
        }

        /**
         * sets the cost of the item for HEB internally
         * @param cost of the item internally at HEB
         */
        public void setCost(string cost)
        {
            this.cost = cost;
        }

        public string toCSV()
        {
            return ID + "," + description + "," + lastDaySold + "," + shelfLife + ","
                    + department + "," + price + "," + unitOfMeasure + "," + xFor + "," + cost;
        }
    }
}
