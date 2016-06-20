#light

let square x = x * x
let numbers = [1 .. 10]
let squares = List.map square numbers
printfn "N^2 = %A" squares

open System
Console.ReadKey(true) 