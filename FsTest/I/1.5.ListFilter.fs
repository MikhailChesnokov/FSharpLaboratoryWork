module _1_5_ListFilter

let filterIndex f L =
    let rec innerIndexFilter f L lres count =
        match L with
        [] -> lres
        | (h::t) ->  innerIndexFilter f t (if f count then (h::lres) else lres) (count + 1)
    List.rev (innerIndexFilter f L [] 0)

let removeEverySecond L =
    filterIndex (fun i -> i % 2 = 0) L