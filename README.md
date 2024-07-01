# Bcm.Aed.MAUI

## App.xaml
Definiert anwendungsweite Ressourcen, bspw. Farben und Stile für Steuerelemente

## App.xaml.cs
Codebehind für App.xaml, definiert die App-Klasse, welche das Hauptfenster `MainPage` erzeugt. Man kann Anwendungslebenszyklus-Ereignishanadler überschreiben u.a. `OnStart`, `OnResume` und `OnSleep`.

## AppShell.xaml
Ist die Hauptstruktur einer .NET MAUI Anwendung. Hier können verschiedene Feastures definiert werden. Bspw. App-Formatierung, URI-basierter Navigation, Layoutoptionen oder Registerkarten für das Stammverzeichnis der Anwendung.

## MainPage.xaml
Definition der UI des Hauptfensters (analog zu WPF). Siehe auch Kommentare in der xaml Datei.

## MainPage.xaml.cs
Codebehind des Hauptfensters. `Clicked` Ereignishanadler - so, wie mans nicht macht!
Die statische `Announce` Methode der Klasse `SemanticScreenReader` weist der Sprachausgabe an, einen Text vorzulesen (Barrierefreiheit).

## MauiProgram.cs
Jede native Platform hat einen anderen Einstiegspunkt in die Anwendung, diesen Code befindet sich im Ordner **Platforms**. Diese rufen die Methode `CreateMauiApp` der statischen Klasse `MauiProgram` auf.
### Steuerungsablauf beim Start einer MAUI App
!(https://learn.microsoft.com/de-de/training/dot-net-maui/build-mobile-and-desktop-apps/media/3-startup-flow.png)
