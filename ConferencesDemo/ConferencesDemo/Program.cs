using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Conference c1, c2, c3, c4, c5;
            c1 = new Conference();
            c2 = new Conference();
            c3 = new Conference();
            c4 = new Conference();
            c5 = new Conference();

            displayConference(c1);
            displayConference(c2);
            displayConference(c3);
            displayConference(c4);
            displayConference(c5);

           
           
            


            

          






        }

        public class Conference
        {
            public string groupName;
            public string startDate;
            int numOfAttendees;
            public string conferenceName; 

            public string groupNameProperty
            {
                get
                {
                    return groupName; 
                }
                set
                {
                    groupName = value; 
                }

            }

            public string ConferenceName
            {
                get
                {
                    return conferenceName; 
                }
                set
                {
                    conferenceName = value;
                }

            }

            public string startDateProperty

            {
                get
                {
                    return startDate; 
                }
                set
                {
                    startDate = value;  
                }

            }

            public int numOfAttendeesProperty
            {
                get
                {
                    return numOfAttendees; 
                }
                set
                {
                    numOfAttendees = value;
                }

            }



        }

       /* public static int[] compareConferenceObjects(Conference c1 , Conference c2 , Conference c3 , Conference c4 , Conference c5)
        {

            
            

        }
        */ 

        public static void displayConference(Conference c)
        {
            Console.WriteLine("Enter Conference Name: ");
            c.conferenceName = Console.ReadLine(); 
            Console.WriteLine("Enter group name: ");
            c.groupNameProperty = Console.ReadLine();
            Console.WriteLine("Enter start date: ");
            c.startDateProperty = Console.ReadLine();
            Console.WriteLine("Enter number of attendees: ");
            c.numOfAttendeesProperty = Convert.ToInt32(Console.ReadLine());

        }




    }
   
}
