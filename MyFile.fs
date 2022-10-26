module MyFile
type Person = {
    Name:string
    Age:int
}

let personAsString (p:Person) : string = sprintf $"%A{p}"
