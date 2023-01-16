namespace OnlineComputerShopApp;

public partial class UserPage : ContentPage
{
	public UserPage()
	{
		InitializeComponent();
        UserListView.ItemsSource = App.DbTrans.GetAllUsers();
    }

    private void BtnAddUser_Clicked(object sender, EventArgs e)

    {
        App.DbTrans.AddUser(new Models.User
        {
            Name = EntFirstName.Text,
            LastName= EntLastName.Text,
            Gender = Convert.ToString(GenderPicker.SelectedItem),
            Date= UserCreateDate.Date,
            Age = Convert.ToInt32(EntUserAge.Text)

        });
        UserListView.ItemsSource = App.DbTrans.GetAllUsers();
    }

    private void BtnDeleteStudent_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DbTrans.DeleteUser((int)button.BindingContext);
        UserListView.ItemsSource = App.DbTrans.GetAllUsers();
    }
}