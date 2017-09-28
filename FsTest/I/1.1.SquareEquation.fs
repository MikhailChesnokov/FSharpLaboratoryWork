module _1_1_SquareEquation

type squareEquationRoots = 
    None
    | Any
    | Lin of float
    | Quad of float * float

let isNumber value =
    not (System.Double.IsNaN value || System.Double.IsInfinity value )

let solveSquareEquation a b c =
    if isNumber a &&
       isNumber b && 
       isNumber c then 
                       if a = 0.0 then 
                                       if b = 0.0 then 
                                                       if c = 0.0 then Any 
                                                                  else None
                                                  else Lin(-c / b)
                                  else let D = b * b - 4.0 * a * c
                                       if D < 0.0 then None
                                                  else Quad(((-b + sqrt(D)) / (2.0 * a)),
                                                            ((-b - sqrt(D)) / (2.0 * a)))
     else None

let printRoots roots =
    match roots with
    None -> printf "No roots in real numbers.\n"
    | Any -> printf "Any real number.\n"
    | Lin(x) -> printf "One real root: %f.\n" x
    | Quad(x1, x2) -> printf "Two real roots: %f and %f.\n" x1 x2
    