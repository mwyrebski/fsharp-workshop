module Exercises.DiscriminatedUnions

open Xunit


module ``Convert to Discriminated Union`` =

    type MyId = MyId of int

    [<Fact>]
    let ``Change type to single-case discriminated union``() =
        let myid = (*FIXME*) 42

        AssertEqual typeof<MyId> (myid.GetType())


module ``Create Discriminated Union`` =

    type Animal =
        | Cat of name: string
        | Dog of name: string

    [<Fact>]
    let ``Create simple discriminated union value``() =
        let animal = FIXME

        AssertEqual (Dog "Blacky") animal


module ``Pattern Matching`` =

    type Color = | White | Yellow | Green | Red | Black
    type Brand = | Suzuki | BMW | Honda | Lamborgini
    type Vehicle =
        | Car of topSpeed: int * make: Brand * model: string * color: Color
        | Motorbike of topSpeed: int * make: Brand * color: Color

    let whiteSuzuki = Motorbike(220, Suzuki, White)
    let greenBMW = Motorbike(305, BMW, Green)
    let blackBMW = Motorbike(298, BMW, Black)
    let redHonda = Car(307, Honda, "NSX", Red)
    let blackHonda = Car(227, Honda, "Civic R", Black)
    let yellowLamborgini = Car(484, Lamborgini, "Hennessey Venom F5", Yellow)
    let allVehicles = [ whiteSuzuki; greenBMW; blackBMW; redHonda; blackHonda; yellowLamborgini ]

    [<Fact>]
    let ``Check for fastest vehicle``() =

        let check vehicle =
            match vehicle with
            | Car(color = Red) -> "Red cars are very fast"
            | Car(topSpeed = 200) -> "It's the fastest known car" // FIXME: fix pattern matching for named field
            | Car _ -> "Some car"
            | Motorbike _ -> "Some motorbike"

        AssertEqual "Red cars are very fast" (check redHonda)
        AssertEqual "Some car" (check blackHonda)
        AssertEqual "It's the fastest known car" (check yellowLamborgini)

    [<Fact>]
    let ``Find motorbikes with top speed divisible by 2``() =
        let findSpecificVehicle vehicle =
            match vehicle with
            | Motorbike(topSpeed = speed) when speed % 2 = 0 -> true
            | Car _ -> false
            | Motorbike _ -> false
        let actual = List.filter findSpecificVehicle allVehicles

        AssertEqual actual FIXME

    [<Fact>]
    let ``Find vehicles with top speed over 300``() =
        let findFastest vehicle =
            match vehicle with
            (* FIXME *)
            | Car _ -> false
            | Motorbike _ -> false

        let actual = List.filter findFastest allVehicles

        AssertEqual [ greenBMW; redHonda; yellowLamborgini ] actual

