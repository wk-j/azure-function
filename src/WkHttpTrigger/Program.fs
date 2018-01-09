// Learn more about F# at http://fsharp.org

namespace WkHttpTrigger

open Microsoft.AspNetCore.Mvc
open Microsoft.AspNetCore.Http
open Microsoft.Azure.WebJobs.Host

module Program = 
    let run(req: HttpRequest, log: TraceWriter) =
        log.Info("F# HTTP trigger function processed a request.")
        ContentResult(Content = "HO HO HO Merry Christmas", ContentType = "text/html")
