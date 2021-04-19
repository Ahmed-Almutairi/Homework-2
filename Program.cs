using System;

namespace Homework2
{

    
    class Program
    {
        static bool CheckOrderMethod(String Source) {

             if (Source.Length%2 !=0|| Source.Length==0)
            {
                return false;
            }

            int i = 0;
            int j = Source.Length - 1;
            while (Source[i] == Source[j])
            {
                if (i >= j) return true;
                else
                {
                    i++;
                    j--;
                }
            }
          
            return false; }

        static void Main(string[] args)
        {

            Console.WriteLine("------------------------CheckOrderMethod---------------------------");
            Console.WriteLine("Test case 1 (input: <empty>): {0}", CheckOrderMethod(""));
            Console.WriteLine("Test case 2 (input: 7): {0}", CheckOrderMethod("7"));
            Console.WriteLine("Test case 3 (input: 101): {0}", CheckOrderMethod("101"));
            Console.WriteLine("Test case 4 (input: 889988): {0}", CheckOrderMethod("889988"));

            Console.WriteLine("------------------------HTMLBuilder---------------------------");

            HTMLBuilder builder = new HTMLBuilder();

            Console.WriteLine(builder.OpenTag("html lang=\"en\"").OpenTag("head").OpenTag("title").Content("Welcome to HTMLBuilder").EndTag("title").EndTag("head").EndTag("html").getAndClearBuilder());
        }
    }
    class HTMLBuilder
    {
        String value;


        public HTMLBuilder OpenTag(String tag)
        {

            this.value += "<" + tag + ">\n";

            return this;
        }

        public HTMLBuilder Content(String content)
        {
            this.value += content + "\n";

            return this;
        }

        public HTMLBuilder EndTag(String tag)
        {

            this.value += "</" + tag + ">\n";

            return this;
        }
        public String getBuilder()
        {
            return this.value;
        }
        public String getAndClearBuilder()
        {
            String get = this.value;
            this.value = "";
            return get;
        }
    }
}
