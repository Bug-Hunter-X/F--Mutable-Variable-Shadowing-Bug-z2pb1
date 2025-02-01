let x = 10
let y = 20

let add x y = 
    let mutable x1 = x
    let mutable y1 = y
    x1 <- x1 + y1
    y1 <- y1 + x1
    x1 + y1

printf "%d %d %d" x y (add x y)

//Alternative solution using immutable variables
let add2 x y = 
    let sum = x + y
    (sum, x + sum) //return tuple

let x2 = 10
let y2 = 20

let (sum, y3) = add2 x2 y2
printfn "%d %d %d" x2 y2 sum