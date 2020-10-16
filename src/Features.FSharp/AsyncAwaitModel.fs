namespace Features

open System
open System.Threading.Tasks

type AsyncAwaitModel() =
    member this.RunAsyncTask(message: string) = 
        async {
            do! Async.Sleep 2000
            return message
        } |> Async.StartAsTask
