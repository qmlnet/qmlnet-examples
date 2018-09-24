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
                    Qml.RegisterType<SignalsModel>("Features");
                    Qml.RegisterType<NotifySignalsModel>("Features");
                    Qml.RegisterType<AsyncAwaitModel>("Features");
                    Qml.RegisterType<NetObjectsModel>("Features");
                    Qml.RegisterType<DynamicModel>("Features");
                    Qml.RegisterType<CalculatorModel>("Features");
                    Qml.RegisterType<CollectionsModel>("Features");

                    qmlEngine.Load("Main.qml");
                    
                    return application.Exec();
                }
            }
        }
    }
}
