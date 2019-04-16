module Fibonnaci.Tests

open Excercises
open Xunit

[<Theory>]
[<InlineData(0, 1)>]
[<InlineData(1, 1)>]
[<InlineData(3, 2)>]
[<InlineData(5, 3)>]
[<InlineData(8, 4)>]
[<InlineData(13, 5)>]
let ``Test Fibonnaci calculation`` input expected =
    let actual = Fibonnaci.calc input
    Assert.Equal(expected, actual)
