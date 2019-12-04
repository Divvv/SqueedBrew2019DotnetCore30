using SqueedBrewDemos.DemoFakes;

namespace SqueedBrewDemos
{
    public class SqueedBrewRepository
    {
        private readonly IDbContextFactory _contextFactory;
        public SqueedBrewRepository(IDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void SaveNewSqueedBrew(string brewName)
        {
            using var context = _contextFactory.CreateContext();

            /*
             * context.SqueedBrews.Add(new SqueedBrew { Name: brewName });
             * context.SaveChanges();
             */

        }
    }
}
