module Factorial.Tests

open Excercises
open Xunit

[<Theory>]
[<InlineData(1, 0)>]
[<InlineData(1, 1)>]
[<InlineData(2, 2)>]
[<InlineData(6, 3)>]
[<InlineData(24, 4)>]
[<InlineData(120, 5)>]
[<InlineData(720, 6)>]
let ``Test Factorial calculation`` expected input =
    let actual = Factorial.calc input
    Assert.Equal(expected, actual)
