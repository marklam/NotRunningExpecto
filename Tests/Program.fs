module Tests.Program

open Expecto

[<Tests>]
let tests =
    testList "Tests" [
        test "Dummy" {
            Expect.isTrue true "dotnet test doesn't like it when all the tests are skipped, so 0 tests run."
        }
    ]
