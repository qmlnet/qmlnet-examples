namespace Features

open System.Collections.Generic

type Contact = { Name: string; PhoneNumber: string }

type CollectionsModel() =
    let mutable contacts = List<Contact> [ {Name = "Paul Knopf"; PhoneNumber = "525-525-52555" } ]

    member this.AddContact(name: string, phoneNumber: string) =
        if System.String.IsNullOrEmpty name || System.String.IsNullOrEmpty phoneNumber then false
        else 
            contacts.Add {Name = name; PhoneNumber = phoneNumber}
            true

    member this.RemoveContact(index: int) = contacts.RemoveAt(index)
    
    member this.Contacts with get() = contacts
