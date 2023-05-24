using NourGramApp.Models;
using NourGramApp.ViewModel;

namespace NourGramApp.View;


public partial class VideoPage : ContentPage
{
    public static readonly BindableProperty VideoProperty =
       BindableProperty.Create(nameof(Video), typeof(Video), typeof(VideoPage));

    public Video Video
    {
        get => (Video)GetValue(VideoProperty);
        set => SetValue(VideoProperty, value);
    }



    public VideoPage()
	{
		InitializeComponent();
   
	}


    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}
