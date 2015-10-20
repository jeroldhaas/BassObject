module TShirts

open System

module AllShirts =
    
    // Equal Rights
    let equalRights () =
        let reject = 
            [|"Racism"; "Sexism"; 
            "Ageism"; "Homophobia"|]

        for x in reject do
            printfn "I Reject %s!" x

    // I Love My Family
    let iLove () =
        "My Family"

    // I Respect The Elderly
    let iRespect () =
        "The Elderly"

    // I Support The Youth
    let iSupport () =
        "The Youth"

    // Playtime Or Nah
    let playTimeOrNah (input: string) =
        
        match input.ToLower() with
        | "legos" -> printfn "Play Time"
        | "xbox" -> printfn "Play Time"
        | "vegetables" -> printfn "No comment."
        | _ -> printfn "Play Time"