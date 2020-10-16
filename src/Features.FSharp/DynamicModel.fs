namespace Features

open FSharp.Interop.Dynamic

type DynamicModel() =
    member this.InvokeJavascriptFunction(funct: obj, message: string) =
        !?funct message |> ignore

    member this.Add(source: obj, destination: obj) =
        destination?computedResult <- source?value1 + source?value2
