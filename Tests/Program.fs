module Tests.Program

open Expecto

[<Tests>]
let tests =
    testList "Tests" [
        test "Dummy" {
            Expect.isTrue true "true should be true"
        }
    ]
