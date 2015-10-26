
module Template =
    type Property() =
        member val Name = "" with set,get
        member val Title = "" with set,get

    type TextProperty() =
        inherit Property()

    type DropdownProperty() =
        inherit Property()
        member val Value = List.empty<string> with set,get

    type Item() =
        member val Name = "" with set,get
        member val Value = "" with set,get
        member val Link = List.empty<string> with set,get
        member val Prop = List.empty<Property> with set,get

    type Level = {
        Level: int
        Name: string
        Title: string
        CascadeFrom: int
        Items: Item list
    }
