namespace Features

open System
open Qml.Net

[<Signal("customSignal", NetVariantType.String)>]
type SignalsModel() =
    member this.RaiseSignal() =
        let message = "Signal was raised from F# .NET at " + DateTime.Now.ToLongTimeString()
        this.ActivateSignal("customSignal", message)

