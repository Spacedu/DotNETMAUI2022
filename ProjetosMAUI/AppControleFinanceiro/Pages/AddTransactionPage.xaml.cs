using AppControleFinanceiro.Models;
using AppControleFinanceiro.Repositories;

namespace AppControleFinanceiro.Pages;

public partial class AddTransactionPage : ContentPage
{
    private IOperationRepository _repository;

    public AddTransactionPage()
	{
		InitializeComponent();
        _repository = new OperationRepository();
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
        if (!Validation()) return;

        var operation = new Operation
        {
            OperationType = (Receita.IsChecked) ? OperationType.Income : OperationType.Expenses,
            Name = Name.Text,
            Date = Date.Date,
            Value = double.Parse(Value.Text)
        };

        _repository.AddOperations(operation);

        //TransactionPage -> Buscar no banco.
        

        Navigation.PopModalAsync();
    }

    private bool Validation()
    {
        bool hasError = false;
        MsgValidationError.Text = string.Empty;

        if (Name.Text == null || Name.Text.Trim().Length == 0)
        {
            hasError = true;
            MsgValidationError.Text += "Favor preencher o campo 'Nome'!" + Environment.NewLine;
        }

        if (Value.Text == null || Value.Text.Trim().Length == 0)
        {
            hasError = true;
            MsgValidationError.Text += "Favor preencher o campo 'Valor'!" + Environment.NewLine;
        }

        if(Value.Text != null) { 
            double result;
            bool isConvert = double.TryParse(Value.Text.Trim(), out result);
            if(!isConvert)
            {
                hasError = true;
                MsgValidationError.Text += "O valor digitado no campo 'Valor' é inválido!";
            }
        }


        return !hasError;
    }
}