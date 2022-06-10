using MVP.Presenters;
using MVP.Repository;
using MVP.Views;

namespace MVP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();


            string conStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"CarDb\";Integrated Security=True;";

            IMainView view = new MainView();
            ICarRepository repository = new CarRepository(conStr);
           
            new CarPresenter(repository, view);

            Application.Run((Form)view);
        }
    }
}