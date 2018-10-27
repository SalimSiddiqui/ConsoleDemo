using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleDemo.DesignPatern
{
    class FactoryMethodDesignPattern_arch
    {
    }
  public  interface IProduct { }

    public class ConcreateClassA : IProduct { }
    public class ConcreateClassB : IProduct { }

   public abstract class Creater
    {
        public abstract IProduct FactoryCreator(string Type);
    }
    public class ConcreateCreator : Creater
    {
        public override IProduct FactoryCreator(string Type)
        {
            switch (Type)
            {
                case "A": return new ConcreateClassA();
                case "B": return new ConcreateClassB();

                default: throw new ArgumentException("Invalid Type");
                    
            }
        }
    }


}
