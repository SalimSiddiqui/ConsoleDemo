using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Practice
{
    internal class FactoryDP
    {
    }


    public interface IProduct { };
    public class ProductAx : IProduct { };
    public class ProductBx : IProduct { };

    public abstract class Creatornew
    {
        public abstract IProduct ConcreateCreatorfactory(string type);
    }


    public class ConcreteCreator : Creatornew
    {
        public override IProduct ConcreateCreatorfactory(string type)
        {

            switch (type)
            {
                case "A": return new ProductAx();
                case "B": return new ProductBx();
                default: throw new ArgumentException("Invalid Type");

            }
        }
    }
}




