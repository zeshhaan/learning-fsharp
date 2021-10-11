// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

[<EntryPoint>]
let main argv =
    let person = argv.[0]
    printfn "Hello world %s" person
    printfn "The args are %A" argv
    0