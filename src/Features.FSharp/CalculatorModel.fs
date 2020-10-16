namespace Features

open Qml.Net

type CalculatorModel() =
    let mutable isValid = false
    let mutable computedResult = ""

    [<NotifySignal>]
    member this.ComputedResult
        with get() = computedResult
        and set(value) = 
            if value <> computedResult then
                computedResult <- value
                this.ActivateSignal("computedResultChanged") |> ignore

    [<NotifySignal>]
    member this.IsValid
        with get() = isValid
        and set(value) =
            if value <> isValid then
                isValid <- value
                this.ActivateSignal("isValidChanged")  |> ignore

    member this.Add(inputValue1: string, inputValue2: string) =
        let a = decimal inputValue1
        let b = decimal inputValue2
        let result = a + b
        this.ComputedResult <- string result

    member this.Subtract(inputValue1: string, inputValue2: string) =
        let a = decimal inputValue1
        let b = decimal inputValue2
        let result = a - b
        this.ComputedResult <- string result

    member this.Multiply(inputValue1: string, inputValue2: string) =
        let a = decimal inputValue1
        let b = decimal inputValue2
        let result = a * b
        this.ComputedResult <- string result

    member this.Divide(inputValue1: string, inputValue2: string) =
        let a = decimal inputValue1
        let b = decimal inputValue2
        try
            let result = a / b
            this.ComputedResult <- string result
        with | :? System.DivideByZeroException -> this.ComputedResult <- "Division by zero!"
