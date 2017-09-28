module _2_6_VerticesCount

open _2_5_MaxBranchLength

let rec countVertices T count =
    match T with
    Empty -> count
    | BinaryTree(LT,_,RT) -> countVertices LT (countVertices RT count + 1)