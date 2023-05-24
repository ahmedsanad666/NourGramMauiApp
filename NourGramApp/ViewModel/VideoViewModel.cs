
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using NourGramApp.Models;
using NourGramApp.Services;
using NourGramApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NourGramApp.ViewModel
{
    [QueryProperty("Video","Video")]
    public partial class VideoViewModel : BaseViewModel
    {
      
        public VideoViewModel()
        {
            
        }
        [ObservableProperty]
        Video video;








        [RelayCommand]
        async Task GoToDetails(Video video)
        {
            if (video is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(VideoPage)}?id={video.id}", true,
                new Dictionary<string, object>
                {
                { "Video", video }
                });
        }


    }
}
