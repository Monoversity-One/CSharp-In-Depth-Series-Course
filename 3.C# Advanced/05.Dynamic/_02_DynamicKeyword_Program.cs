namespace _05.Dynamic
{

    /* 
     Programming Languages are divided into 2 types : 

        - Statically-Typed languages : C#, Java (static languages)
            Resolution of types, members, properties, methods is done at compile-time, get errors if not defined when compiled


        - Dynamically-Typed languages: Ruby, Javascript, Python (dynamic languages)
            Resolution of types, members, properties, methods is done at run-time


    
    
         */

    class DynamicKeywordDemo
    {
        public static void Run()
        {
            // 'dynamic' defers member binding to runtime; types can vary across assignments.
            dynamic name = "cyril";
            name = 10;
            /*------------*/
            dynamic a = 10;
            dynamic b = 5;
            var c = a+b;  //c is now dynamic
                          /*-------------*/

            int i = 5;
            dynamic d = i;

            long l = d; //don't need to cast

        }
    }
}
