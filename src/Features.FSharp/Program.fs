open System
open System.IO
open System.Reflection
open Qml.Net
open Qml.Net.Runtimes

open Features

[<EntryPoint>]
let main argv =
    RuntimeManager.DiscoverOrDownloadSuitableQtRuntime()
    QQuickStyle.SetStyle("Material");
    use app = new QGuiApplication(argv)
    use engine = new QQmlApplicationEngine()
    let registeredTypes = [
        Qml.RegisterType<SignalsModel>("Features")
        Qml.RegisterType<NotifySignalsModel>("Features")
        Qml.RegisterType<AsyncAwaitModel>("Features")
        Qml.RegisterType<NetObjectsModel>("Features")
        Qml.RegisterType<DynamicModel>("Features")
        Qml.RegisterType<CalculatorModel>("Features")
        Qml.RegisterType<CollectionsModel>("Features")

    ]
    let binaryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
    Directory.SetCurrentDirectory(binaryPath)
    engine.Load("Main.qml")
    app.Exec()
