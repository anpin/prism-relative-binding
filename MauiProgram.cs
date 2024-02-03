using Microsoft.Extensions.Logging;


namespace prism_relative_binding;

public static class MauiProgram
{
	private const string root = "root";
	private const string page = "page";
	
	public static MauiApp CreateMauiApp()
	{
		

		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UsePrism(b =>
			{
				b
					.ConfigureLogging(l => l.AddDebug())
					.RegisterTypes(x => x
						.Register<ExceptionCatcher>()
						.RegisterForNavigation<AppShell, ShellModel>(root)
						.RegisterForNavigation<MainPage, PageModel>(page)
						
					
					)
					.OnAppStart(w =>
						
						w.NavigateAsync(root));
			})
			
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		
		
		return builder.Build();
	}
	
}

class ExceptionCatcher
{
	private readonly ILogger<ExceptionCatcher> _logger;

	public ExceptionCatcher(ILogger<ExceptionCatcher> logger)
	{
		_logger = logger;
		AppDomain.CurrentDomain.UnhandledException  += CurrentDomainOnUnhandledException;
	}

	private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		_logger.LogError("Unhandled exception: {0}", e);
	}
}
