#I "packages/FAKE/tools"
#r "FakeLib.dll"

open Fake
open Fake.FscHelper
open Fake.FileHelper
open System.IO

let moveDepend src = src |> SilentCopy "out"
let move() =
    moveDepend [
        "packages/FSharp.Core/lib/net40/FSharp.Core.dll"
        "packages/Newtonsoft.Json/lib/net45/Newtonsoft.Json.dll"]

let sources = ["src/Model.fsx"; "src/Service.fsx";]

Target "dll" (fun _ ->
        sources
        |> Fsc(fun p -> { p with Output = "out/Project.dll"; FscTarget=Library })
        move()
    )

Target "exe" (fun _ ->
        sources |> List.append ["src/Project.fsx"]
        |> Fsc(fun p -> { p with Output = "out/Project.exe"})
        move()
    )

RunTargetOrDefault fsi.CommandLineArgs.[1]