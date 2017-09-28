module _2_5_MaxBranchLength

type BinaryTree<'a> = 
    Empty
    | BinaryTree of BinaryTree<'a> * 'a * BinaryTree<'a>

let rec getMaxBranchLength T count =
    match T with 
    Empty -> count
    | BinaryTree(LT,_,RT) -> max (getMaxBranchLength LT count + 1)
                                 (getMaxBranchLength RT count + 1)