
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
mut <- 5    // setting new value for 'mut'


// Array
// -----

let arr1 = [| 1; 2; 3; 4; 5 |]
let arr2 = [| 1..5 |]
assert (arr1 = arr2)

// accessing value by index
let three = arr1.[2]  // complexity: O(1)
assert (3 = three)

// values in arrays can be changed (mutated)
arr1.[3] <- 9


// List
// ----

let list1 = [ 1; 2; 3; 4; 5 ]
let list2 = [ "banana"; "apple"; "cherry" ]

// accessing list element by id
let five = list1.[4]  // complexity: O(n)

// cannot mutate list items
// list1.[2] <- 8 

// prepending value to the existing list with `::` (cons operator)
let list2WithPear = "pear" :: list2

// concatenating lists
let drinks1 = [ "tea"; "coffee" ]
let drinks2 = [ "water"; "beer" ]
let allDrinks = drinks1 @ drinks2


// ------------------------------------------
// Functions
// ------------------------------------------
// functions are expressions, too

let add x y = x + y
let result = add 2 40

// function without parameters
let simpleFunction () =
    let x = 3
    let y = 2 * x
    let result = x + y
    result              // last expression is returned from function


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

for i in [3..5] do
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
let firstTupleValue  = fst tuple
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


// ------------------------------------------
// Records
// ------------------------------------------

// declaring a record type
type Money = {Currency: string; Value: float}

// creating a value which will be inferred to be of the `Money` type
let moneyValue = {Currency = "USD"; Value=100.0}

let wallet = [
        {Currency = "USD"; Value = 123.32}
        {Currency = "EUR"; Value = 83.10}
        {Currency = "CHF"; Value = 45.96}
        {Currency = "GBP"; Value = 756.0}
    ]

type Contact =
    {
        FistName: string
        LastName: string
        EmailAddress: Email option      // this field is optional
    }

   