using System;
using System.IO;
using Qml.Net;

namespace Features
{
    class Program
    {
        static int Main(string[] args)
        {
            QQuickStyle.SetStyle("Material");

            using (var application = new QGuiApplication(args))
            {
                using (var qmlEngine = new QQmlApplicationEngine())
                {
                    QQmlApplicationEngine.RegisterType<SignalsModel>("Features");
                    QQmlApplicationEngine.RegisterType<NotifySignalsModel>("Features");
                    
                    qmlEngine.Load("Main.qml");
                    
                    return application.Exec();
                }
            }
        }
    }
}
