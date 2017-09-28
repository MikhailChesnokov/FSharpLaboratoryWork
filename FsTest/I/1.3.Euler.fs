module _1_3_Euler

let rec gcd n m =
    if m = 0 then n
             else gcd m (n % m)

let euler N =
    if N < 1 then None
             else 
    let rec innerEuler curN count =
        if curN = 1 then count
                    else innerEuler (curN - 1) (count + if gcd N curN = 1 then 1 else 0)
    Some(innerEuler N 1)