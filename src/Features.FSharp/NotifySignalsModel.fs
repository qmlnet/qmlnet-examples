namespace Features

open System
open Qml.Net

type NotifySignalsModel() =
    let mutable bindableProperty = ""

    [<NotifySignal>]
    member this.BindableProperty
        with get() = bindableProperty
        and set(value) = 
            bindableProperty <- value
            this.ActivateSignal("bindablePropertyChanged") |> ignore
    
    member this.ChangeBindableProperty() = 
        this.BindableProperty <- DateTime.Now.ToLongTimeString();
