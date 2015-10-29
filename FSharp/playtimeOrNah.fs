let playTimeOrNah (input: string) =

    match input.ToLower() with
    | "legos" -> printfn "Play Time"
    | "xbox" -> printfn "Play Time"
    | "vegetables" -> printfn "No comment."
    | _ -> printfn "Play Time"
