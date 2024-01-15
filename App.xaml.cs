using Microsoft.Maui.Platform;
using ChekaT2.Handlers;
using Java.Lang;

namespace ChekaT2;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
        {
            if (view is BorderlessEntry)
            {
#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
#elif __IOS__
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
            }
        });

        Routing.RegisterRoute("SignIn", typeof(SignIn));
        Routing.RegisterRoute("SignUp", typeof(SignUp));
        Routing.RegisterRoute("Inicio", typeof(Inicio));
        Routing.RegisterRoute("Notificaciones", typeof(Notificaciones));
        Routing.RegisterRoute("Cumpleaños", typeof(Cumpleaños));
        Routing.RegisterRoute("Actividades", typeof(Actividades));
        Routing.RegisterRoute("Recordatorios", typeof(Recordatorios));

        MainPage = new AppShell();
    }
  
}