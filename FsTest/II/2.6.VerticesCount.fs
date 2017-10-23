module _2_6_VerticesCount
open _2_5_MaxBranchLength // include tree definition

let rec countVertices count = function
    | Empty -> count
    | BinaryTree(LT,_,RT) -> countVertices (countVertices (count + 1) RT) LT