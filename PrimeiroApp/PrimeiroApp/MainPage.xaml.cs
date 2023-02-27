namespace PrimeiroApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void btnVerificar_Clicked(object sender, EventArgs e)
	{
		string texto = $"O nome tem {txtNome.Text.Length} caracteres";
		txtNome.Text = string.Empty;
		DisplayAlert("Mensagem", texto, "Ok");
	}

    private async void btnLimpar_Clicked(object sender, EventArgs e)
    {
        if (await DisplayAlert("Pergunta", "Deseja realmente limpar a tela", "Yes", "No"))
		{
			txtNome.Text = string.Empty;
		}
    }

    private async void btnVerificarDiasVividos_Clicked(object sender, EventArgs e)
    {
		int diasVIvidos = DateTime.Now.Subtract(txtDtNascimento.Date).Days;

		await Application.Current.MainPage.DisplayAlert("Mensagem", $"Você já viveu {diasVIvidos} dias", "Ok");
    }

    private async void btnCalcular_Clicked(object sender, EventArgs e)
    {
		string n1 = await Application.Current.MainPage.DisplayPromptAsync("Mensagem", "Digite o primeiro número", "Ok");

        string n2 = await Application.Current.MainPage.
			DisplayPromptAsync("Mensagem", 
								"Digite o segundo número", 
								"Ok");

		string operacao = await Application.Current.MainPage.
			DisplayActionSheet("Selecione uma opção", 
								"Cancelar", 
								"Ok", 
								"Somar", 
								"Subtração", 
								"Multiplicação", 
								"Dividir");

		switch (operacao)
		{
			case "Somar": 
				{ 
					int resultado = int.Parse(n1) + int.Parse(n2);

					await Application.Current.MainPage.DisplayAlert("Mensagem", $"O resultado {resultado}", "Ok");
				} break;
            case "Subtração": 
				{
                    int resultado = int.Parse(n1) - int.Parse(n2);

                    await Application.Current.MainPage.DisplayAlert("Mensagem", $"O resultado é {resultado}", "Ok");
                } break;
            case "Multiplicação": 
				{
                    int resultado = int.Parse(n1) * int.Parse(n2);

                    await Application.Current.MainPage.DisplayAlert("Mensagem", $"O resultado é {resultado}", "Ok");
                } break;
            case "Dividir": 
				{
                    int resultado = int.Parse(n1) / int.Parse(n2);

                    await Application.Current.MainPage.DisplayAlert("Mensagem", $"O resultado é {resultado}", "Ok");
                } break;
        }
    }
}

