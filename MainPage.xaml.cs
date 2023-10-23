using ApiExample2.Services;

namespace ApiExample2
{
public partial class MainPage : ContentPage
{
	private readonly IMangaTop _mangaTop;

	public MainPage(IMangaTop service)
	{
		InitializeComponent();
		_mangaTop = service;
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
    loading.IsVisible = true;

    var data = await _mangaTop.Get();
	collectionViewPersonajes.ItemsSource = data; // Cambiar "listViewPersonajes" a "collectionViewPersonajes"

    loading.IsVisible = false;
	}
}
}

