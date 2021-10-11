// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

[<EntryPoint>]
let main argv =
    let person = 
        if argv.Length > 0 then
            argv.[0]
        else "Mohammed Zeeshan"
    printfn "Welcome %s" person
    0