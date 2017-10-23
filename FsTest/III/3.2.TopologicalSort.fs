module _3_2_TopologicalSort

let sortGraph globalEdges =
    let rec traverceFromV (visited, sorted) V = function
        | [] -> visited,sorted 
        | (edgeSource,edgeDest)::remainingEdges -> if edgeSource = V && not (List.contains edgeDest visited) then traverceFromV (edgeDest::visited, sorted) edgeDest globalEdges |> fun (vis,srt) -> traverceFromV (vis,edgeDest::srt) V remainingEdges
                                                                                                             else traverceFromV (visited, sorted) V remainingEdges
    let rec traverceAll visited sorted = function
        | [] -> sorted
        | (edgeSource,_)::remainEdges -> if List.contains edgeSource visited then traverceAll visited sorted remainEdges
                                                                             else (traverceFromV (edgeSource::visited,sorted) edgeSource globalEdges) |> fun (v,s) -> traverceAll v (edgeSource::s) remainEdges
    traverceAll [] [] globalEdges