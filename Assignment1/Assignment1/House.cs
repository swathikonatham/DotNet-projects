﻿/*********************************************************************************************************
 *                                                                                                       *
 *  CSCI:504-MSTR PROGRAMMING PRINCIPLES IN .NET	      Assignment 1					 Spring 2020     *                                          
 *																										 *
 *  Programmer's: Swathi Reddy Konatham (Z1864290),
 *                Abdulsalam Olaoye (Z1836477),
 *                Xuezhi Cang (Z1747635)                                                                 *  	                           
 *																										 *
 *  Class Name: House
 *  Purpose   : Console application that displays the property details of Dekalb Community.				 *
 *********************************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    
    public class House : Residential
    {
        private bool garage;
        private bool? attachedGarage;
        private uint floors;


        public bool Garage
        {
            set { garage = value; }
            get { return garage; }
        }

        public bool? AttachedGarage
        {
            set { attachedGarage = value; }
            get { return attachedGarage; }
        }

        public uint Floors
        {
            set { floors = value; }
            get { return floors; }
        }


 
        public House(string[] args):base(args)
        {
           
            garage = base.StringToBool(args[12]); //Convert.ToBoolean(args[12]);
            if (garage == false)
                attachedGarage = null;
            else
                attachedGarage = base.StringToBool(args[13]);//Convert.ToBoolean(args[13]);
            floors = Convert.ToUInt32(args[14]);


        }
        
        public override string ToString()
        {
            string ret = String.Format("Id    : {0 , -10 }\n", Id);
            ret += String.Format("OwnerID  : {0}\n", OwnerID);
            ret += String.Format("Forsale   : {0}\n", ForSale);
            ret += String.Format("garage   : {0}\n", Garage);
            ret += String.Format("Floors   : {0}\n", floors);

            return ret;
        }
    }
}
