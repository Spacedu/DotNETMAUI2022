using AppControleFinanceiro.Models;

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

    private void OnTapped_Close(object sender, TappedEventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private void OnButtonClicked_Save(object sender, EventArgs e)
    {
        //TODO - Validar os dados digitados
        var operation = new Operation
        {
            OperationType = (Receita.IsChecked) ? OperationType.Income : OperationType.Expenses,
            Name = Name.Text,
            Date = Date.Date,
            Value = double.Parse(Value.Text)
        };
    }
}