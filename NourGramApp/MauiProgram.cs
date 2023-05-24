using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using NourGramApp.View;
using NourGramApp.ViewModel;

namespace NourGramApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkitMediaElement()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<VideoViewModel>();
		builder.Services.AddTransient<VideoViewModel>();
		builder.Services.AddTransient<VideoPage>();



#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
