﻿/*********************************************************************************************************
 *                                                                                                       *
 *  CSCI:504-MSTR PROGRAMMING PRINCIPLES IN .NET	      Assignment 6					 Spring 2020     *                                          
 *																										 *
 *  Programmer's: Swathi Reddy Konatham (Z1864290),
 *                Abdulsalam Olaoye (Z1836477),
 *                Xuezhi Cang (Z1747635)                                                                 *  	                           
 *																										 *
 *  Class Name: DataModel
 *  Purpose   : Implementation of different Charts.                                                      *
 *********************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asx_Assign6
{
    public class DataModel
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

        public Int64 PopulationIn2006 { get; set; }
        public Int64 PopulationIn2007 { get; set; }
        public Int64 PopulationIn2008 { get; set; }
        public Int64 PopulationIn2009 { get; set; }
        public Int64 PopulationIn2010 { get; set; }

        public Int64 PopulationIn2011 { get; set; }
        public Int64 PopulationIn2012 { get; set; }
        public Int64 PopulationIn2013 { get; set; }
        public Int64 PopulationIn2014 { get; set; }
        public Int64 PopulationIn2015 { get; set; }
    }
}
