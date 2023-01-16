namespace OnlineComputerShopApp;

public partial class CpuPage : ContentPage
{
    public CpuPage()
    {
        InitializeComponent();
        CpuListView.ItemsSource = App.DbTrans.GetAllCpu();

    }

    private void BtnAddCpu_Clicked(object sender, EventArgs e)
    {
        App.DbTrans.AddCpu(new Models.Cpu
        {
                CpuName = EntCpuName.Text,
                CpuPrice = Int32.Parse(EntCpuPrice.Text)
            }); CpuListView.ItemsSource = App.DbTrans.GetAllCpu();

    }

private void BtnDeleteCpu_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DbTrans.DeleteCpu((int)button.BindingContext);
        CpuListView.ItemsSource = App.DbTrans.GetAllCpu();
    }
}