﻿using NourGramApp.View;

namespace NourGramApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(VideoPage), typeof(VideoPage));
    }
}
