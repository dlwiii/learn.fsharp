module foo
let printTruthTable f = 
  printfn ""
  printfn "%5b %5b" (f true  true ) (f true  false)
  printfn "%5b %5b" (f false true ) (f false false)
  ;;
