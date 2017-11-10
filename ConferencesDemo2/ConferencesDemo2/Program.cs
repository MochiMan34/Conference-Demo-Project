using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConferencesDemo2
{
    class Program
    {

        static void Main(string[] args)
        {

            Conference[] c = new Conference[5]; 

            int[] attendees = new int[5];

            for (int i = 0; i < c.Length; i++)
            {
                c[i] = new Conference();
                displayConference(c[i]);
                
            }
            Array.Sort(c); 
            for(int v = 0; v < c.Length; v++)
            {
                Console.WriteLine("Conference Name: " +  c[v].ConferenceNameProperty + "\n Group Name: " + c[v].groupNameProperty + "\n Start date: "  + c[v].startDateProperty + "\n Number of attendees: " + c[v].numOfAttendeesProperty);
                Console.ReadLine(); 
            }
           
            Console.ReadLine(); 
                
            

           
            
          

      

























        }

        public class Conference : IComparable
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

            public string ConferenceNameProperty
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
            
            // Compares the Conference objects 
            int IComparable.CompareTo(object obj)
            {
                int returnVal; // return value 

                Conference temp = (Conference)obj; // temporary conference object 

                if(this.numOfAttendees > temp.numOfAttendees) // if the current object's number of attendees is greater than the temporary Conference object's 
                {
                    returnVal = 1;// return value is 1 
                    
                }
                else
                {
                    if(this.numOfAttendees < temp.numOfAttendees) // if less, 
                    {
                        returnVal = -1; // return value is -1 
                        

                    }
                    else
                    {
                        returnVal = 0; // else return value is the same. 
                       

                    }

                }
                return returnVal;// return value is returned 
            
            }

            
           


        }

      
        public static void displayConference(Conference c)
        {
             

            Console.WriteLine("Enter Conference Name: ");
            c.ConferenceNameProperty = Console.ReadLine();
            Console.WriteLine("Enter group name: ");
            c.groupNameProperty = Console.ReadLine();
            Console.WriteLine("Enter start date: ");
            c.startDateProperty = Console.ReadLine();
            Console.WriteLine("Enter number of attendees: ");
            c.numOfAttendeesProperty = Convert.ToInt32(Console.ReadLine());

            

        }




    }

}

