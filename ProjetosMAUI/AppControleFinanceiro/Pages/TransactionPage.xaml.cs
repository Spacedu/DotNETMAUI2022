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

        /*
         * CommunityToolkit.MVVM: WeakReferenceMessage (Pub/Sub)
         * Xamarin.Forms: MessageCenter (Pub/Sub)
         * 
         * .NET7: MessagerCenter > WeakReferenceMessage.
         * 
         * Publishers: Publicador.
         * Subscribers: Assinante/Inscrito.
         * 
         * Publisher: Avisar sobre o Cadastro > Mensagem > Subscribers(Assinantes).
         * Subscriber: Cadastro, Atualização e Exclusão = Operations. > LoadList();
         */
    }

    public void LoadList()
    {
        _repository = new OperationRepository();
        _list = _repository.GetOperations(DateTimeOffset.Now);

        LVOperations.ItemsSource = _list;
    }

    private void OnButtonClicked_To_AddTransactionPage(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new AddTransactionPage());
    }
}