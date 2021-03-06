﻿/*********************************************************************************************************
 *                                                                                                       *
 *  CSCI:504-MSTR PROGRAMMING PRINCIPLES IN .NET	      Assignment 2					 Spring 2020     *                                          
 *																										 *
 *  Programmer's: Swathi Reddy Konatham (Z1864290),
 *                Abdulsalam Olaoye (Z1836477),
 *                Xuezhi Cang (Z1747635)                                                                 *  	                           
 *																										 *
 *  Class Name: Property
 *  Purpose   : Windows application that displays the property details of Dekalb & Sycamore Communities. *
 *********************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
    //Property class, it stores generic info a property could possess  
    // @implements : IComparable for the "CompareTo" method
    public class Property : IComparable
    {
        //Attributes of the Property class
        private readonly uint id;
        private uint ownerID;
        private readonly uint x, y;
        private string streetAddr, city, state, zip;
        private bool forSale;

        // Attributes used to keep track of 
        // addNumber and streetName
        private uint addNumber;
        private string streetName;

        // Default class constructor
        public Property()
        {
            id = ownerID = x = y = 0;
            streetAddr = city = state = zip = "";
            forSale = false;
        }

        // Method used to covert string value to bool
        // @returns : true or false
        public bool StringToBool(string boolString)
        {
            return (boolString.CompareTo("T") == 0) ? true : false;
        }

        // Alternate constructor for the class
        // @params: String Array, broken down within the 
        //          constructor to fill attr values
        public Property(string[] args)
        {
            id = Convert.ToUInt32(args[0]);
            ownerID = Convert.ToUInt32(args[1]);
            x = Convert.ToUInt32(args[2]);
            y = Convert.ToUInt32(args[3]);
            streetAddr = args[4];
            city = args[5];
            state = args[6];
            zip = args[7];
            forSale = StringToBool(args[8]);

            string[] addressStringArr = streetAddr.Split();
            addNumber = Convert.ToUInt32(addressStringArr[0]);
            streetName = addressStringArr[1] + " " + addressStringArr[2];
        }

        // implementation of CompareTo method
        //     comapres first by State,then City,
        //     then streetName and Address number
        //     then apartment unit
        // Exception if( Null object found )
        public int CompareTo(Object alpha)
        {
            if (alpha == null) throw new ArgumentNullException("Property object being compared with is NULL");

            Property rightOp = alpha as Property;

            if (rightOp != null)
            {
                if (State.ToLower().CompareTo(rightOp.State.ToLower()) == 0)
                {
                    if (City.ToLower().CompareTo(rightOp.City.ToLower()) == 0)
                    {
                        if (StreetName.ToLower().CompareTo(rightOp.StreetName.ToLower()) == 0)
                        {
                            if (AddNumber.CompareTo(rightOp.AddNumber) == 0)
                            {
                                if (rightOp is Apartment)
                                {
                                    Apartment rightObject = (Apartment)rightOp;
                                    Apartment thisObject = (Apartment)this;
                                    return (thisObject.Unit.ToLower().CompareTo(rightObject.Unit.ToLower()));
                                }
                                else
                                {
                                    throw new ArgumentNullException("Error:the address of house has been inputted");
                                }
                            }
                            else
                                return AddNumber.CompareTo(rightOp.AddNumber);
                        }
                        else
                            return StreetName.CompareTo(rightOp.StreetName);


                    }
                    else
                        return City.CompareTo(rightOp.City);
                }

                else
                    return State.CompareTo(rightOp.State);
            }
            else
                throw new ArgumentNullException("Property object being compared with is NULL");
        }

        //get-only prop for id attr
        public uint Id => id;

        // Property for ownerID attr
        // allows: set && get
        public uint OwnerID
        {
            set { ownerID = value; }
            get => ownerID;
        }

        //get-only prop for x attr
        public uint X => x;

        //get-only prop for y attr
        public uint Y => y;

        // Property for streetAddr attr
        // allows: set && get
        public string StreetAddr
        {
            set { streetAddr = value; }
            get => streetAddr;
        }

        // Property for city attr
        // allows: set && get
        public string City
        {
            set { city = value; }
            get => city;
        }

        // Property for state attr
        // allows: set && get
        public string State
        {
            set { state = value; }
            get => state;
        }

        // Property for zip attr
        // allows: set && get
        public string Zip
        {
            set { zip = value; }
            get => zip;
        }

        // Property for forSale attr
        // allows: set && get
        public bool ForSale
        {
            set { forSale = value; }
            get { return forSale; }
        }

        // Property for addNumber attr
        // allows: set && get
        public uint AddNumber
        {
            set { addNumber = value; }
            get { return addNumber; }
        }

        // Property for streetName attr
        // allows: set && get
        public string StreetName
        {
            set { streetName = value; }
            get { return streetName; }
        }
    }
}
