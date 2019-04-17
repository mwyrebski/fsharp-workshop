module Exercises.Fibonnaci

open Xunit



let rec calculateFibonnaci n =
    FIXME



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
let ``Test Fibonnaci calculation`` expected input =
    let actual = calculateFibonnaci input
    Assert.Equal(expected, actual)
