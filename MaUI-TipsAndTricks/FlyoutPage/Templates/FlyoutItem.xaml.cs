namespace FlyoutPage.Templates;

public partial class FlyoutItem : ContentView
{
	public FlyoutItem()
	{
		InitializeComponent();
	}


    public static readonly BindableProperty IconProperty =
                BindableProperty.Create(nameof(Icon), typeof(string), typeof(FlyoutItem));

    public static readonly BindableProperty TitleProperty =
                BindableProperty.Create(nameof(Title), typeof(string), typeof(FlyoutItem));

    public string Icon
    {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
}