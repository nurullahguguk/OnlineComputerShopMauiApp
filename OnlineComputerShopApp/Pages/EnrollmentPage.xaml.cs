
using OnlineComputerShopApp.Models;

namespace OnlineComputerShopApp;

public partial class EnrollmentPage : ContentPage
{
    Cpu cpu;
    Storage storage;
	public EnrollmentPage()
	{
		InitializeComponent();
        CpuListView.ItemsSource = App.DbTrans.GetAllCpu();
        StorageListView.ItemsSource = App.DbTrans.GetAllStorages();
        EnrollmentnListView.ItemsSource = App.DbTrans.GetAllEnrollment();
    }

    private void CpuListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        cpu =(Cpu)e.Item;
    }

    private void BtnApprove_Clicked(object sender, EventArgs e)
    {
        App.DbTrans.AddEnrollment(new Models.Enrollment
        {
            CpuId = cpu.CpuId,
            CpuName = cpu.CpuName,
            StorageId = storage.StorageId,
            StorageBrand = storage.StorageType,
            Date = datePickerPres.Date,
            Hostname = EtnHostName.Text
        });
        EnrollmentnListView.ItemsSource = App.DbTrans.GetAllEnrollment();
    }

    private void BtnDelete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DbTrans.DeleteEnrollment((int)button.BindingContext);
        EnrollmentnListView.ItemsSource = App.DbTrans.GetAllEnrollment();
    }

    private void StorageListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        storage = (Storage)e.Item;
    }
}