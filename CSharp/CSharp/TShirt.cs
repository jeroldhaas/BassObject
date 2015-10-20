using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class TShirt
    {

        //Equal Rights
        public void equalRights ()
        {
            var reject = 
                new string[]
                {
                    "Racism", "Sexism", "Ageism", "Homophobia"
                };
            foreach(var x in reject)
            {
                Console.WriteLine("I reject " + x + "!");
            }
        } 

        //I Love My Family
        public string iLove ()
        {
            return "My Family";
        }

        //I Respect The Elderly
        public string iRespect ()
        {
            return "The Elderly";
        }

        // I Support The Youth
        public string iSupport ()
        {
            return "The Youth";
        }

        //Playtime Or Nah
        public void playTimeOrNah (string input)
        {
            string answer;

            switch (input.ToLower())
            {
                case "legos":
                    answer = "Play Time";
                    break;
                case "xbox":
                    answer = "Play Time";
                    break;
                case "vegetables":
                    answer = "No comment.";
                    break;
                default:
                    answer = "Play Time";
                    break;
            }
            Console.WriteLine(answer);
        }
    }
}
