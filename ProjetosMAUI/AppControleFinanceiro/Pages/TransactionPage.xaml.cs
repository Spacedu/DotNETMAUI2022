using AppControleFinanceiro.Models;
using AppControleFinanceiro.Repositories;

namespace AppControleFinanceiro.Pages;

public partial class TransactionPage : ContentPage
{
	private OperationRepository _repository;
	private List<Operation> _list;
	public TransactionPage()
	{
		InitializeComponent();

		_repository = new OperationRepository();
		_list = _repository.GetOperations(DateTimeOffset.Now);

		LVOperations.ItemsSource = _list;

    }
}