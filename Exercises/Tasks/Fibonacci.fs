module Exercises.Fibonacci

open Xunit



(* TASK: Implement this function so it returns n-th expected fibonacci number 
*)
let rec calculateFibonacci n =
    if n < 2 then
        n
    else
        (calculateFibonacci (n-1)) + (calculateFibonacci (n-2))



[<Theory>]
[<InlineData(0, 0)>]
[<InlineData(1, 1)>]
[<InlineData(1, 2)>]
[<InlineData(2, 3)>]
[<InlineData(3, 4)>]
[<InlineData(5, 5)>]
[<InlineData(8, 6)>]
[<InlineData(13, 7)>]
[<InlineData(21, 8)>]
let ``Test Fibonacci calculation`` expected input =
    let actual = calculateFibonacci input
    AssertEqual expected actual
