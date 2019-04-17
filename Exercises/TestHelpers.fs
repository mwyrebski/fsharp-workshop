[<AutoOpen>]
module Exercises.TestHelpers

open Xunit

let inline FIXME<'T> : 'T = failwith "Please fill in the FIXME"

let AssertEqual (expected:'T) (actual:'T) =
    Assert.Equal<'T>(expected, actual)
