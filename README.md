# Learning F#

## Getting started

### Installing

```bash
dotnet new console -lang "F#"
```

This will spin up a F# console application and the files will have the name defaulted to the folder name. We can also specify the project name while running the command like this.

```bash
dotnet new console -lang "F#" -o MyAwesomeFSharpProject
```

Reference:

[Get Started with F# in Visual Studio Code](https://docs.microsoft.com/en-us/dotnet/fsharp/get-started/get-started-vscode)

The folder will contain

- Program.fs
- .fsproj
- obj

`.fsproj` is F# project file.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net5.0</TargetFramework>
    <RootNamespace>fsharp_notes_basics</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <Compile Include="Program.fs" />
  </ItemGroup>

</Project>
```

It specifies that our program is going to include the F# source file, _Program.fs._ It also tells that we are going to build an Executable type program with a dotnet framework.

`Program.fs` is the F# source file. It is where we will write our F# code.

```fsharp
open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    0 // return an integer exit code%
```

`[<EntryPoint>]` tells the program which line to start executing at.

`let` declares/binds a value or function. Here it is a function with a name _`main`._

_`argv`_ is a placeholder for argument which is sent to the function so that it can start running.

_`=`_ tells that we are finished specifying arguments of the function.

`printfn` is print formatted with a new line.

Reference:

[Formatted text using printf](https://fsharpforfunandprofit.com/posts/printf/)

> F# doesn't required a return keyword. It returns what is written in the last line of the function body.

### Signature of the function

Specifies the type of data it takes in and the type of data it returns.

To run the program, enter:

```bash
dotnet run
```

We can specify command line args like this.

```bash
dotnet run abc 123
```

and to print them to the console, we can modify our `Program.fs` file like so

```bash
open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    printfn "The args are %A" argv
    0
```

### Debugging F# Program

Simply run the following command on terminal to watch for the changes.

```bash
dotnet watch run abc 123
```

This is similar to using `nodemon` package in NodeJS.

We can also use VS Code's Run and Debug tab to setup breakpoints and provide command line args and watch for them. But it requires setting up of _launch.json_ and _tasks.json._

## Control Flow

To access an array in F#, we use `.`

```fsharp
open System

[<EntryPoint>]
let main argv =
    let person = argv.[0]
    printfn "Hello world %s" person
    printfn "The args are %A" argv
    0
```

> we are getting the `0th` element of `argv` array and binding it to the name `person`

### Format Specifier

aka placeholder

strongly typed

`%A` → array

`%s` → strings

`%i` → int
