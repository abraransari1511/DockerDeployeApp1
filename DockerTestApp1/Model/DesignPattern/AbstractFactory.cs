using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerTestApp1.Model
{
    public interface AbstractFactory
    {
        AbstractProductA CreateProductA();
        AbstractProductB CreateProductB();
    }
    public class ConcreteFactoryA : AbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
    public class ConcreteFactoryB : AbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
    public interface AbstractProductA { }
    public class ProductA1 : AbstractProductA { }
    public class ProductA2 : AbstractProductA { }
    public interface AbstractProductB { }
    public class ProductB1 : AbstractProductB { }
    public class ProductB2 : AbstractProductB { }
    public class Client
    {
        private AbstractProductA _productA;
        private AbstractProductB _productB;
        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }
    }
}
