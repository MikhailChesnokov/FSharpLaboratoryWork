module _3_2_TopologicalSort

type Vertex<'a> = Vertex of 'a * (Vertex<'a> list)

let rec dfs (visited,sorted) = function
    | [] -> visited,sorted
    | (head:Vertex<'a> & Vertex(data,list))::tail -> if List.contains head visited then dfs (visited,sorted) tail
                                                                                   else dfs (head::visited,sorted) list |> fun (v,s) -> dfs (v,data::s) tail