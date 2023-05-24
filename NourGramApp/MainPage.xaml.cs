using NourGramApp.Models;
using NourGramApp.Services;
using NourGramApp.View;
using NourGramApp.ViewModel;
using System.Collections.Generic;
using System.Windows.Input;

namespace NourGramApp;

public partial class MainPage : ContentPage
{

	private VideoService VideoService = new VideoService();
    private List<Video> _videos;
    public List<Video> Videos
    {
        get => _videos;
        set
        {
            _videos = value;
            OnPropertyChanged(); // Notify property change
        }
    }
    public  MainPage()
	{
		InitializeComponent();
        BindingContext = this;
        LoadData();
	}

 public async void LoadData()
	{   
		List<Video> allVideos = await VideoService.GetAll();
        Videos = allVideos;
	}

    //public ICommand ShowVideoDetailsCommand => new Command<Video>(async (video) =>
    //{
    //    var videoDetailsPage = new VideoPage();
    //    videoDetailsPage.BindingContext = VideoViewModel;
    //    videoDetailsPage.Video = video;
    //    await Navigation.PushAsync(videoDetailsPage);
    //});
}

