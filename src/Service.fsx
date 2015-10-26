#I "../packages/Newtonsoft.Json/lib/net45/"
#r "Newtonsoft.Json.dll"
#load "Model.fsx"

open Newtonsoft.Json
open Newtonsoft.Json.Serialization
open System.IO
open Model.Template

let createLevel level name title cascadeFrom (items:Item list) =
    {
        Level = level
        Name = name
        Title = title
        CascadeFrom = cascadeFrom
        Items = items
    }

let createItem name value link props =
    Item(Name = name, Value = value, Link = link, Prop = props)

let createTextProperty name title =
    TextProperty(Name = name, Title = title)

let createDropdownProperty name title values  =
    DropdownProperty( Name = name, Title = title, Value = values)

let toJson (level:obj) (file: string)=
    let setting  = JsonSerializerSettings()
    setting.ContractResolver <- new CamelCasePropertyNamesContractResolver()
    let json = JsonConvert.SerializeObject(level, Formatting.Indented, setting)
    File.WriteAllText(file,json)
