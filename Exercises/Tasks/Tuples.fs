module Exercises.Tuples

open Exercises
open Xunit


[<Fact>]
let ``Tuple value`` () =
    let tuple = (1, 2 ,3)
    
    AssertEqual tuple FIXME 


[<Fact>]
let ``Access first and second elements of a tuple`` () =
    let tuple = (2, 4)
    let first = fst tuple
    let second = snd tuple
    
    AssertEqual first FIXME 
    AssertEqual second FIXME 


[<Fact>]
let ``Deconstruct tuple values`` () =
    let tuple = FIXME
    
    let (a, b, c) = tuple
    
    AssertEqual a 2 
    AssertEqual b 4 
    AssertEqual c 6 

