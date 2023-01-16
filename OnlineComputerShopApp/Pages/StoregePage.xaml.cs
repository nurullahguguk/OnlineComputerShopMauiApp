namespace OnlineComputerShopApp;

public partial class StoregePage : ContentPage
{
    public static string StorageType { get; set; } = "HDD";
    public StoregePage()
	{
		InitializeComponent();
        StorageListView.ItemsSource = App.DbTrans.GetAllStorages();
    }
    

    private void BtnAddStorage_Clicked(object sender, EventArgs e)
    {
        App.DbTrans.AddStorage(new Models.Storage
        {
            StorageType = Convert.ToString(StorageType),
            StorageSize = Convert.ToString(StorageSizePicker.SelectedItem)
        });
        StorageListView.ItemsSource = App.DbTrans.GetAllStorages();
    }

    private void RbHdd_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
        StorageType = rb.Content.ToString();
    }

    private void BtnDeleteStorage_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DbTrans.DeleteStorage((int)button.BindingContext);
        StorageListView.ItemsSource = App.DbTrans.GetAllStorages();
    }
}