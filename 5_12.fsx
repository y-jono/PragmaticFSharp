let safeDivision x =
  | 0 -> (false, 0)
  | y -> (true, x/y);;
  
