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

        public T GetRole<T>() where T : DriverDecorator
            {
            if (this is T)
                return (T)this;

            if (!(this.baseDriver is DriverDecorator))
                return null;

            return (this.baseDriver as DriverDecorator).GetRole<T>();
            }

        public IDriver RemoveRole<T>() where T : DriverDecorator
            {
            if (this is T)
                return this.baseDriver;

            if (!(this.baseDriver is DriverDecorator))
                return this;

            this.baseDriver = (this.baseDriver as DriverDecorator).RemoveRole<T>();
            return this;
            }
        }
    }
