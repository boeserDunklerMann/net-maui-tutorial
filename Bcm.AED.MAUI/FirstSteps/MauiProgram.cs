using Microsoft.Extensions.Logging;

namespace FirstSteps
{
	public static class MauiProgram
	{
		/// <summary>
		/// erzeugt die Maui Anwendung und wird vom nativen Plattform-Code aufgerufen
		/// </summary>
		/// <returns></returns>
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
