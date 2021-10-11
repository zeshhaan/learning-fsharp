// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

[<EntryPoint>]
let main argv =
    let mutable person = "Mohammed Zeeshan"
    if argv.Length > 0 then
        person <- argv.[0]
    printfn "Welcome %s" person
    0