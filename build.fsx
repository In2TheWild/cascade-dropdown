#I "packages/FAKE/tools"
#r "FakeLib.dll"

open Fake
open Fake.FscHelper
open Fake.FileHelper
open System.IO

let moveDepend src =
    src |> SilentCopy "out"

Target "Compile" (fun _ ->
        ["src/Model.fsx"; "src/Service.fsx"; "src/Project.fsx"]
        |> Fsc(fun p -> { p with Output = "out/Project.exe"; })
        moveDepend ["packages/Newtonsoft.Json/lib/net45/Newtonsoft.Json.dll"]
    )

RunTargetOrDefault "Compile"