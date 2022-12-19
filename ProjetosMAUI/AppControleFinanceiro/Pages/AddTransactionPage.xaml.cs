namespace AppControleFinanceiro.Pages;

public partial class AddTransactionPage : ContentPage
{
	public AddTransactionPage()
	{
		InitializeComponent();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        Date.WidthRequest = width - 30;
    }
}