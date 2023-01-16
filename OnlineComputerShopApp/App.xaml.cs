using OnlineComputerShopApp.Data_Transactions;

namespace OnlineComputerShopApp;

public partial class App : Application
{
    public static DbTrans DbTrans { get; private set; }
    public App(DbTrans dbTrans)
    {
        InitializeComponent();

        MainPage = new AppShell();

        DbTrans = dbTrans;
    }
}
