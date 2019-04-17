module Exercises.Records

open Exercises
open Xunit



type Person = { Name: string; Age: int }

[<Fact>]
let ``Create object for a Record type`` () =
    
    let john = { Name = "John"; Age = 15 }
    
    AssertEqual john.Name FIXME
    AssertEqual john.Age FIXME





(* Declare this type and make the test pass *)
type Message = unit

//[<Fact>]
//let ``Declare record type for provided object`` () =
//    let msg : Message = { Text = "Hello World"; Length = 11 }
//    
//    AssertEqual msg.Text    "Hello World"
//    AssertEqual msg.Length  11


