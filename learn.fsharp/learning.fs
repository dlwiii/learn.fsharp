// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main (args : string[]) =
  if args.Length <> 2 then
    failwith "error: expected two argumets"
  let greeting, thing = args.[0], args.[1] 
  printfn "Hello %s %s"  greeting thing
  foo.conn
  0 // return an integer exit code

