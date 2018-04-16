open FSharpPlus
open FSharpPlus.Data
 
[<EntryPoint>]
let main argv = 
    let a: OptionT<_> = monad {
        let! x = async.Return (Some 1) |> OptionT
        let! y = async.Return 2 |> liftAsync
        return x + y
    } 
    
    0