module _2_3_Ferz

let beat (x1,y1) (x2,y2) = (not ((x1=x2) && (y1=y2)) && ((x1=x2) || (y1=y2) || (abs(x1-x2)=abs(y1-y2))))

let isCorrectArrangement pairs = 
    List.forall (fun (x,y) -> List.forall (fun (x1,y1) -> not (beat (x,y) (x1,y1))) pairs) pairs