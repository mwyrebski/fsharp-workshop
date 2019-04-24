
// ------------------------------------------
// Basic data type
// ------------------------------------------
// everything is an expression

// Declaring expressions
let str = "Hello"
let num = 42

// print output
printfn "%s, %d" str num

// Mutable types
let mutable mut = -1
mut <- 5 // setting new value for 'mut'


// Array
// -----

let arr1 = [| 1; 2; 3; 4; 5 |]
let arr2 = [| 1..5 |]
assert (arr1 = arr2)

// accessing value by index
let three = arr1.[2] // complexity: O(1)
assert (3 = three)

// values in arrays can be changed (mutated)
arr1.[3] <- 9


// List
// ----
// - lists are immutable (cannot replace their elements & cannot add/remove elements)
// - complexity of accessing n-th element is O(n)
// - elements can be prepended using cons operator `::`
// - lists can be joined with `@` operator

let list1 = [ 1; 2; 3; 4; 5 ]
let list2 = [ "banana"; "apple"; "cherry" ]

// accessing list element by id
let five = list1.[4] // complexity: O(n)

// cannot mutate list items
// list1.[2] <- 8

// prepending value to the existing list with `::` (cons operator)
let list2WithPear = "pear" :: list2

// concatenating lists
let drinks1 = [ "tea"; "coffee" ]
let drinks2 = [ "water"; "beer" ]
let allDrinks = drinks1 @ drinks2


// Set
// ---
// - sets are immutable
// - sets never contain any duplicated elements
// - order of elements is not guaranteed

let set1 = Set [ 7; 2; 7; 3; 5; 5 ]
let set2 = Set [ 2; 3; 5; 7 ]
assert (set1 = set2)


// Map
// ---
// - maps are immutable
// - F#-native dictionary structure


// creating new map
Map.empty
    .Add("key1", "value")
    .Add("key2", "value2")

// creating map out of sequence
let sequence = seq {
    yield ("one", 1)
    yield ("two", 2 + 5)
 }
let map1 = Map sequence

// accessing map's element by key
map1.["one"]


// ------------------------------------------
// Functions
// ------------------------------------------
// functions are expressions, too

let add x y =
    x + y
let result = add 3 5

// function without parameters
let simpleFunction() =
    let x = 3
    let y = 2 * x
    let square i =
        i * i
    let result = x + y + (square 8)
    result // last expression is returned from function


// ------------------------------------------
// Conditions
// ------------------------------------------

if 8 / 2 = 4 then
    printfn "8 is divisible by 2"
else
    printfn "computer error"

// example with more conditional branches
if result = 42 then "equals"
elif result < 42 then "is less than"
elif result = 100 then "is equal to 100"
else "is greater than"

// ------------------------------------------
// Loops
// ------------------------------------------

// for..to
for i = 3 to 5 do
    printfn "%d" i

for i = 5 downto 3 do
    printfn "%d" i

for i in [ 3..5 ] do
    printfn "%d" i

let mutable i = 3
while i <= 5 do
    printfn "%d" i
    i <- i + 1


// ------------------------------------------
// Tuples
// ------------------------------------------

let tuple = (13, "Seven")
let widerTuple = (1, "one", "uno")

// tuple deconstruction
let (thirteen, seven) = tuple


let (_, Seven) = tuple
let (_, middle, _) = widerTuple


// accessing first and second element with `fst` and `snd`
let firstTupleValue = fst tuple
let secondTupleValue = snd tuple


// ------------------------------------------
// Discriminated Unions
// ------------------------------------------

type Animal =
    | Monkey
    | Parrot

// single-case discriminated union
type Email =
    | Email of string

type CustomerId =
    | CustomerId of int


// Pattern matching
// ----------------

type ShapeSize =
    | Square of float
    | Rectangle of float * float

let calculateArea shape =
    match shape with
    | Square x -> x * x
    | Rectangle(x, y) -> x * y

// ^ can be also written as:
let calculateArea' = function
    | Square x -> x * x
    | Rectangle(x, y) -> x * y

// matching lists (cons pattern)
let matchList list =
    match list with
    | head :: tail -> head
    | _ -> -1

assert (2 = (matchList [ 2; 3; 4 ]))
assert (-1 = (matchList []))

// Matching named fields

type Fruit =
    | Apple of color: string * weight: float
    | Banana of weight: float
    | Strawberry of dried: bool * weight: float

let smallRedApple = Apple(color = "red", weight = 66.0)
let smallYellowApple = Apple(color = "yellow", weight = 69.0)
let bigYellowApple = Apple(color = "yellow", weight = 110.0)

let chooseFruit fruit =
    match fruit with
    | Strawberry(dried = false) -> printfn "Non-dried strawberry"
    | Banana(weight) when weight > 170.0 -> printfn "Quite a banana"
    | Apple(color = "red") -> printfn "Nice red apple"
    | Apple(color, weight) when color = "yellow" && weight < 70.0 -> printfn "Small yellow apple"
    | Strawberry _ -> printfn "A strawberry"
    | Banana _ -> printfn "A banana"
    | Apple _ -> printfn "An apple"

// more pattern matching examples:
// - https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/pattern-matching
// - https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/match-expressions


// ------------------------------------------
// Records
// ------------------------------------------

// declaring a record type
type Money = { Currency: string; Value: float }

// creating a value which will be inferred to be of the `Money` type
let moneyValue = { Currency = "USD"; Value = 100.0 }

// list of Money values
let wallet = [
        { Currency = "USD"; Value = 123.32 }
        { Currency = "EUR"; Value = 83.10 }
        { Currency = "CHF"; Value = 45.96 }
        { Currency = "GBP"; Value = 756.0 }
    ]

type Contact =
    {
        FistName: string
        LastName: string
        EmailAddress: Email option // this field is optional
        mutable Age: int // this field is mutable
    }

type Point = { X: float; Y: float; Z: float; }
let point1 = { X = 1.0; Y = 1.0; Z = 1.0 }

// create new value based on another with only one value changed
let point2 = { point1 with Z = 2.0 }

