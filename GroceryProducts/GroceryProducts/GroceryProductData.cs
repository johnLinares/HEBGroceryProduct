using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryProducts
{
    //This class is currently not used.  
    //If this was a bigger scale I would use this class to keep track of all data
    //That way I can manipulate data instead of just displaying it
    //Thus, this is a future class
    class GroceryProductData
    {
        //////PIV//////
        //////PIV//////
        //////PIV//////
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

        public GroceryProductData(string[] data) : this ()
        {
            if (data.Length == 8)
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
            else
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
        }


        //////accessors//////
        //////accessors//////
        //////accessors//////
       
        /// <summary>
        /// returns the ID
        /// used string.Copy so calling class never has direct access to the private var memory location
        /// </summary>
        /// <returns>Type: string - returns the (ID) identification number of the item</returns>
        public string getID()
        {
            return string.Copy(ID);
            
        }
        
        /// <summary>
        /// returns the description of the item
        /// used string.Copy so calling class never has direct access to the private var memory location
        /// </summary>
        /// <returns>Type: string - returns the items name/description</returns>
        public string getDescription()
        {
            return string.Copy(description);
        }

        /// <summary>
        /// Returns the getLastSold all as one date
        /// </summary>
        /// <returns>Type: string - returns the date in US fashion style (MM/DD/YYYY)</returns>
        public string getLastSold()
        {
            return string.Copy(lastDaySold);
        }
        
        /// <summary>
        /// returns the shelf life in form (#T)
        /// where # is amount and T is unit of time (d = days, m = month, y = years)
        /// used string.Copy so calling class never has direct access to the private var memory location
        /// </summary>
        /// <returns>Type: string - returns the items shelflife</returns>
        public string getShelfLife()
        {
            return string.Copy(shelfLife);
        }

        /// <summary>
        /// returns the name of the department the item is located
        /// used string.Copy so calling class never has direct access to the private var memory location
        /// </summary>
        /// <returns>Type: string - returns the items department</returns>
        public string getDepartment()
        {
            return string.Copy(department);
        }

        /// <summary>
        /// returns the price of the item sold
        /// used temp var so calling class never has direct access to private var memory location
        /// </summary>
        /// <returns>Type: string - returns the price of the item in form: $##.##</returns>
        public string getPrice()
        {
            //uses number format to format price in the local location US
            //java version:
            //return NumberFormat.getCurrencyInstance(new Locale("en", "US")).format(price);

            return price;
        }

        /// <summary>
        /// returns the unit of measurement (i.g.  lb = limb/pound, each = per item)
        /// used string.Copy so calling class never has direct access to the private var memory location
        /// </summary>
        /// <returns>Type: string - returns the items unit of measurement</returns>
        public string getUnitOfMeasure()
        {
            return string.Copy(unitOfMeasure);
        }

        /// <summary>
        /// returns the xFor of the item
        /// used string.Copy so calling class never has direct access to the private var memory location
        /// ??What is an xFor?? - for causing head aches silly!
        /// </summary>
        /// <returns>Type: string - returns the items xFor</returns>
        public string getxFor()
        {
            return string.Copy(xFor);
        }

        /// <summary>
        /// returns the cost of the item to HEB
        /// used string.Copy so calling class never has direct access to the private var memory location
        /// </summary>
        /// <returns>Type: string - returns the cost of the item</returns>
        public string getCost()
        {
            return string.Copy(cost);
        }

        /// <summary>
        /// returns the product as string with all pieces concatenated with a dilimiter as ,
        /// </summary>
        /// <returns>type: string - string of all data with dilimiter ,</returns>
        public string toCSV()
        {
            return ID + "," + description + "," + lastDaySold + "," + shelfLife + ","
                    + department + "," + price + "," + unitOfMeasure + "," + xFor + "," + cost;
        }


        //////modifiers//////
        //////modifiers//////
        //////modifiers//////

        /// <summary>
        /// sets the description of the item
        /// </summary>
        /// <param name="desc">desc is the description of the item</param>
        public void setDescription(string desc)
        {
            this.description = desc;
        }

        /// <summary>
        /// sets the ID of the item
        /// </summary>
        /// <param name="ID">ID is the ID of the item</param>
        public void setID(string ID)
        {
            this.ID = ID;
        }

        /// <summary>
        /// sets the last day sold of the item
        /// this will break up the string and set the individual day, month, and year item was sold
        /// this is broken up so when we sort by date we can sort by in order of year-month-day
        /// </summary>
        /// <param name="lastDaySold">lastDaySold is the date in format (MM/DD/YYYY) the item was last sold</param>
        public void setLastSold(string lastDaySold)
        {
            this.lastDaySold = lastDaySold;
        }

        /// <summary>
        /// sets the shelf life in for (#T)
        /// Where # = amount and T = unit in time (d = day, m = month, y = year)
        /// </summary>
        /// <param name="shelfLife">shelfLife is the shelf life of the item</param>
        public void setShelfLife(string shelfLife)
        {
            this.shelfLife = shelfLife;
        }

        /// <summary>
        /// sets the department the item is catagorized at in HEB
        /// </summary>
        /// <param name="department">department is the department the item should fall under</param>
        public void setDepartment(string department)
        {
            this.department = department;
        }

        /// <summary>
        /// sets the price of the item
        /// </summary>
        /// <param name="price">price is the price of the item to be sold to the public</param>
        public void setPrice(string price)
        {
            this.price = price;
        }

        /// <summary>
        /// sets the unit of measure (i.g. lb = limbs/pounds, each = per item)
        /// </summary>
        /// <param name="unitOfMeasure">unitOfMeasure is the unit the item is measured in at HEB</param>
        public void setUnitOfMeasure(string unitOfMeasure)
        {
            this.unitOfMeasure = unitOfMeasure;
        }

        /// <summary>
        /// sets the xFor of the ite
        /// </summary>
        /// <param name="xFor"> xFor is the xFor for the item</param>
        public void setxFor(string xFor)
        {
            this.xFor = xFor;
        }

        /// <summary>
        /// sets the cost of the item for HEB internally
        /// </summary>
        /// <param name="cost">cost of the item internally at HEB</param>
        public void setCost(string cost)
        {
            this.cost = cost;
        }
    }
}
