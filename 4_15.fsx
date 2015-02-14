let ptRate = 0.10;;
let payment price ptCard ticket =
  let dprice = price * (1. - ticket) |> floor in
  let ptTrans = ptCard + (dprice * ptRate |> floor) in
  dprice, ptTrans;;

let (price, trans) = payment 980. 50. 0.30;;
printfn "%f %f" price trans;;
