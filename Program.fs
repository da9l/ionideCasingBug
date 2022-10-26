open MyFile
// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
{
    Name = "Bob"
    Age = 25
}
|> personAsString
|> printfn "%s"
