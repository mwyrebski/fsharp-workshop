module Exercises.Lists
open Xunit



[<Fact>]
let ``List value`` () =
    let value = [1;2;3]
    
    AssertEqual [1; 2; 3] value


[<Fact>]
let ``Prepend list with a value`` () =
    let list = [ "banana"; "apple" ]
    
    let result = "pear" :: list
    
    AssertEqual result [ "pear"; "banana"; "apple" ]


[<Fact>]
let ``Concatenate two lists`` () =
    let first = [ "banana"; "apple" ]
    let second = [ "pear"; "cherry" ]
    
    let result = first @ second
    
    AssertEqual ["banana"; "apple"; "pear"; "cherry"] result


[<Fact>]
let ``Access list element by index`` () =
    let first = [ "banana"; "apple"; "cherry" ]
    
    let apple = first.[1]
    
    AssertEqual apple "apple"


[<Fact>]
let ``Filter list items`` () =
    let list = [ "banana"; "apple"; "cherry"; "ananas" ]
    
    let startsWithA (s: string) =
        s.StartsWith('a')
    
    // filter `list` items picking only elements starting with `a`
    let fruitsOnA = List.filter startsWithA list
    
    AssertEqual fruitsOnA [ "apple"; "ananas" ]


