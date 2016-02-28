module Program

open canopy
open reporters

[<EntryPoint>]
let main argv =
  reporter <- new LiveHtmlReporter(Firefox, "") :> IReporter
  reporter.setEnvironment "canopy test page"

  let args = args.parse argv
  start args.Browser

  misc.all()
  run()

  System.Console.ReadKey() |> ignore
  quit ()

  //return code
  canopy.runner.failedCount