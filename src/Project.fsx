
#load "Service.fsx"
open Service
open Model.Template
open System

let text = createTextProperty
let dp = createDropdownProperty
let level = createLevel
let item = createItem

let template = [
    level 1 "prop_cm_title" "title" 0
        [
            item "Name" "Title" []
                []
            item "Name" "Title" []
                []
        ]
    level 2 "prop_cm_title" "title" 0
        [
        ]
]

[<EntryPoint>]
let go args =
    printfn "Hello, world!"
    toJson template "out/Hello.json"
    0