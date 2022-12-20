using AppControleFinanceiro.Models;
using AppControleFinanceiro.Repositories;

namespace AppControleFinanceiro.Pages;

public partial class TransactionPage : ContentPage
{
	private IOperationRepository _repository;
	private List<Operation> _list;
	public TransactionPage()
    {
        InitializeComponent();
        LoadList();
    }

    public void LoadList()
    {
        _repository = new OperationRepository();
        _list = _repository.GetOperations(DateTimeOffset.Now);

        LVOperations.ItemsSource = _list;
    }

    private void OnButtonClicked_To_AddTransactionPage(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new AddTransactionPage(this));
    }
}