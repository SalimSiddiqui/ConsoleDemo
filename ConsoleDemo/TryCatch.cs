using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleDemo
{
   public class TryCatch
    {
        public void print()
        {
            try
            {

                try
                {

                }
                catch (Exception ex)
                {

                    
                }
            }
            catch (DivideByZeroException e)
            {

            }
            catch (Exception ex)
            {
                              
            }
            
        }


        public void printnew()
        {
            try
            {
                int b = 0;
                int a =  1/b;
            }
            finally
            {
            }
        }
    }
}
