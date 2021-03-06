module Exercises.Factorial

open Exercises
open Xunit



(* TASK: Implement this function so it returns n-th expected factorial number 
*)
let rec calculateFactorial n =
    FIXME



[<Theory>]
[<InlineData(1, 0)>]
[<InlineData(1, 1)>]
[<InlineData(2, 2)>]
[<InlineData(6, 3)>]
[<InlineData(24, 4)>]
[<InlineData(120, 5)>]
[<InlineData(720, 6)>]
let ``Test Factorial calculation`` expected input =
    let actual = calculateFactorial input
    AssertEqual expected actual
