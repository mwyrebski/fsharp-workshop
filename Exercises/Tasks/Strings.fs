module Exercises.Strings
open Xunit



[<Fact>]
let ``String value`` () =
    let value = "Message"
    
    AssertEqual "Message" value


[<Fact>]
let ``Strings concatenation`` () =
    let hello = "Hello"
    let world = "World"
    
    let concatenatedString = hello + " " + world 
    
    AssertEqual "Hello World" concatenatedString


