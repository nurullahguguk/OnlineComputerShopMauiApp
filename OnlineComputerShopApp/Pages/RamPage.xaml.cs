using Microsoft.Maui.Animations;
using System.Diagnostics;

namespace OnlineComputerShopApp;

public partial class RamPage : ContentPage
{
	public RamPage()
	{
		InitializeComponent();
        RamListView.ItemsSource = App.DbTrans.GetAllRams();
     }

    private void BtnAddRam_Clicked(object sender, EventArgs e)
    {
        App.DbTrans.AddRam(new Models.Ram
        {
            RamName = EntRamBrand.Text,
            RamSize = Convert.ToString(RamSizePicker.SelectedItem)
        }); RamListView.ItemsSource = App.DbTrans.GetAllRams();
    }

    private void BtnDeleteRam_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DbTrans.DeleteRam((int)button.BindingContext);
        RamListView.ItemsSource = App.DbTrans.GetAllRams();
    }
}