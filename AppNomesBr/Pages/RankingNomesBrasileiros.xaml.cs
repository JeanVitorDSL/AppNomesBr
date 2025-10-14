using AppNomesBr.Domain.Interfaces.Services;

namespace AppNomesBr.Pages;

public partial class RankingNomesBrasileiros : ContentPage
{
    private readonly INomesBrService service;
    public RankingNomesBrasileiros(INomesBrService service)
    {
        InitializeComponent();
        this.service = service;
        BtnAtualizar.Clicked += BtnAtualizar_Clicked;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await CarregarNomes();
    }

    private async void BtnAtualizar_Clicked(object sender, EventArgs e)
    {
        var cidade = TxtCidade.Text;
        var sexo = TxtSexo.Text;
        await CarregarNomes(cidade, sexo);
    }

    private async Task CarregarNomes(string cidade = null, string sexo = null)
    {
        var result = await service.ListaRanking(cidade, sexo);
        GrdNomesBr.ItemsSource = result.FirstOrDefault()?.Resultado;
    }
}