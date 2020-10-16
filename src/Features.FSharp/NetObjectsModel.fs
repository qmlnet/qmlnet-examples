namespace Features

type NetObject() =
    member val Property = "" with get, set
    member this.UpdateProperty(value: string) = this.Property <- value

type NetObjectsModel() =
    member this.GetNetObject() = NetObject()
