
module Template =
    type Property = {
        Name: string
        Title: string
    }

    type Item() =
        member val Name = "" with set,get
        member val Value = "" with set,get

    type TextItem() =
        inherit Item()

    type DropdownItem() =
        inherit Item()
        member val Link = List.empty<string> with set,get

    type Level = {
        Level: int
        Name: string
        Title: string
        CascadeFrom: int
        Items: Item list
    }
