module Exercises.Parentheses

open Exercises
open Xunit


(* TASK: Implement this function which should return true
         if provided input contains no parentheses or if
         all the parentheses are properly balanced.
          
         Below are two tests:
         - first checks if the input is valid for  just a single type of parentheses: ( and )
         - second one checks for three types of parentheses: [, ] and {, } and (, )
         
         Please note that any other characters are allowed in any place in the input.
*)
let balancedParentheses (input: string) : bool =
    FIXME



[<Theory>]
[<InlineData(false, ")")>]
[<InlineData(false, "(")>]
[<InlineData(false, "())")>]
[<InlineData(false, ")(")>]
[<InlineData(true, "")>]
[<InlineData(true, "()")>]
[<InlineData(true, "(())()(()((())))")>]
let ``Test if single type parentheses are balanced`` expected input =
    let actual = balancedParentheses input
    AssertEqual expected actual



[<Theory>]
[<InlineData(false, ")")>]
[<InlineData(false, "[")>]
[<InlineData(false, "(])")>]
[<InlineData(false, "{)(}")>]
[<InlineData(true, "")>]
[<InlineData(true, "({[]})")>]
[<InlineData(true, "{[]} {{(())}}")>]
[<InlineData(true, "{} [] ()")>]
let ``Test if all kind of parentheses are balanced`` expected input =
    let actual = balancedParentheses input
    AssertEqual expected actual
