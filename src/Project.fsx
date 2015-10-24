
#load "Service.fsx"
open Service

let text = createText
let dp = createDropdown

let template = [
    createLevel 1 "prop_cm_title" "title" 0
        [
            text "Main1" "Main1"
            text "Main2" "Main2"
            text "Main3" "Main3"
        ]
    createLevel 2 "prop_cm_description" "Description" 1
        [
            dp "Sub11" "Sub11" ["Main1"; "Main2"]
            dp "Sub12" "Sub12" ["Main1"]
        ]
    createLevel 3 "prop_cm_author" "Author" 2
        [
            dp "Sub21" "Sub21" ["Sub11"]
        ]
]

[<EntryPoint>]
let go args =
    printfn "Hello, world!"
    toJson template "out/Hello.json"
    0