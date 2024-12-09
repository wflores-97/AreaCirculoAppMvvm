using AreaCirculoAppMvvm.ViewModels;

namespace AreaCirculoAppMvvm.Views;

public partial class AreaCirculoView : ContentPage
{
	AreaCirculoViewModels ViewModel;
	public AreaCirculoView()
	{
		InitializeComponent();
		ViewModel = new AreaCirculoViewModels();
		BindingContext=ViewModel;
	
	}
}