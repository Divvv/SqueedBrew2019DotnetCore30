using System;
using System.Collections.Generic;
using System.Text;

namespace SqueedBrewDemos.DemoFakes
{
    public interface IDbContextFactory
    {
        public DbContext CreateContext();
    }

    public class DbContext : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
