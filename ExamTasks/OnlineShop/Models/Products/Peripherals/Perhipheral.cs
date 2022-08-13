using OnlineShop.Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    public abstract class Perhipheral : Product, IPeripheral
    {

        protected Perhipheral(int id, string manufacturer, string model, decimal price, double overallPerformance, string connectionType) : base(id, manufacturer, model, price, overallPerformance)
        {
            ConnectionType = connectionType;
        }

        public string ConnectionType
        {
            get;     
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString() + string.Format(SuccessMessages.PeripheralToString, this.ConnectionType));
            return sb.ToString().TrimEnd();
        }


    }
}
