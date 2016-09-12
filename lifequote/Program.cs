using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifequote
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load(@"XmlFile.xml");

            var root = doc.DocumentElement;

            if (root == null)
                return;

            var quotes = root.SelectNodes("quote");
            if (quotes == null)
                return;

            foreach (XmlNode quote in quotes)
            {
                var title = quote.SelectSingleNode("title");
                var fname = quote.SelectSingleNode("fname");
                var lname = quote.SelectSingleNode("lname");
                var dob = quote.SelectSingleNode("dob");
                var gender = quote.SelectSingleNode("gender");
                var smoke = quote.SelectSingleNode("smoke");
                var postcode =quote.SelectSingleNode("postcode");
                var children = quote.SelectSingleNode("children");
                var exercise = quote.SelectSingleNode("exercise");

                //And so on
            }


        }
    }
}
