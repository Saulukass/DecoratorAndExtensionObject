using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
    {
    abstract class DriverDecorator : IDriver
        {
        private IDriver baseDriver;

        public DriverDecorator(IDriver driver)
            {
            this.baseDriver = driver;
            }

        public virtual void ChangeSalary(int salary)
            {
            baseDriver.ChangeSalary(salary);
            }

        public virtual void Drive()
            {
            baseDriver.Drive();
            }

        public virtual int GetSalary()
            {
            return baseDriver.GetSalary();
            }

        protected IDriver GetUndecoratedDriver()
            {
            if (this.baseDriver is DriverDecorator)
                return (this.baseDriver as DriverDecorator).GetUndecoratedDriver();

            return this.baseDriver;
            }

        private T GetDecoratorInternal<T>() where T : DriverDecorator
            {
            if (this is T)
                return (T)this;

            return DriverDecorator.GetDecorator<T>(this.baseDriver);
            }

        private IDriver RemoveDecoratorInternal<T>() where T : DriverDecorator
            {
            if (this is T)
                return this.baseDriver;

            this.baseDriver = DriverDecorator.RemoveDecorator<T>(this.baseDriver);
            return this;
            }

        static public T GetDecorator<T>(IDriver driver) where T : DriverDecorator
            {
            if (!(driver is DriverDecorator))
                return null;

            return (driver as DriverDecorator).GetDecoratorInternal<T>();
            }

        static public IDriver RemoveDecorator<T>(IDriver driver) where T : DriverDecorator
            {
            if (!(driver is DriverDecorator))
                return driver;

            return (driver as DriverDecorator).RemoveDecoratorInternal<T>();
            }
        }
    }
