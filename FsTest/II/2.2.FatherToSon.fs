module _2_2_FatherToSon

let rec printChildren pairs man buffer = 
    List.fold (fun (acc:string) (father,son) -> acc + (if father = man then (buffer + son + "\n" + (printChildren pairs son (buffer + "  "))) else "")) "" pairs