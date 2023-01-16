namespace OnlineComputerShopApp;

public partial class MonitorPage : ContentPage
{
    public static string MonitorBrand { get; set; } = "HDD";
    public MonitorPage()
	{
		InitializeComponent();
        MonitorListView.ItemsSource = App.DbTrans.GetAllMonitors();
    }

    private void RbAsus_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
        MonitorBrand = rb.Content.ToString();
    }

    private void BtnAddMonitor_Clicked(object sender, EventArgs e)
    {
        App.DbTrans.AddMonitor(new Models.Monitors
        {
            MonitorInch = Convert.ToString(MonitorInchPicker.SelectedItem),
            MonitorBrand = Convert.ToString(MonitorBrand),
             
        });
        MonitorListView.ItemsSource = App.DbTrans.GetAllMonitors();
    }

    private void BtnDeleteMOnitor_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DbTrans.DeleteMonitor((int)button.BindingContext);
        MonitorListView.ItemsSource = App.DbTrans.GetAllMonitors();
    }
}