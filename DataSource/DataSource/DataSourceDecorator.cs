using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    internal class DataSourceDecorator:IDataSource
    {
        private IDataSource wrappee;
        public DataSourceDecorator(IDataSource s)
        {
            wrappee = s;
        }

        public void readData(string data)
        {
            Console.WriteLine("readData.");
        }

        public void writeData(string data)
        {
            Console.WriteLine("writeData");
        }
    }
}
