module foo 

open System
open System.Data
open System.Data.Linq
open Microsoft.FSharp.Data.TypeProviders
open Microsoft.FSharp.Linq
open System.Data.Metadata.Edm
open Oracle.DataAccess.Client


  let conn = new OracleConnection("User Id=system;Password=Pa$$w0rd;Data Source=localhost/orcl")
  let a= conn.Open()
  let cmd = conn.CreateCommand()
  let b= cmd.CommandText = "select table_name from dba_tables where owner = 'ADMUSER'"
  let rdr = cmd.ExecuteReader()
  let empIds = 
      [while rdr.Read() do
         yield rdr.GetString(0)]

//let db = dbSchema.CO

  let printTruthTable f = 
    printfn ""
    printfn "%5b %5b" (f true  true ) (f true  false)
    printfn "%5b %5b" (f false true ) (f false false)
    ;;  

  let rec factorial x = 
    if x<=1.0
    then
      1.0
    else
      let temp = factorial(x-1.0)
      let result = temp * x
      result;;
      
  let factorialTail x = 
    let rec factorialTR x acc = 
      if x<=1.0 then
        acc
      else
        factorialTR  (x-1.) (acc*x) 
    factorialTR x 1.
        ;;
;;