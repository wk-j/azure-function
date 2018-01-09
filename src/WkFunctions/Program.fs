// Learn more about F# at http://fsharp.org
namespace WkFunctions

open Microsoft.Azure.WebJobs
open Microsoft.Azure.WebJobs.Host
open System

module Say = 
    let private daysUntil (d: DateTime) = 
        (d - DateTime.Now).TotalDays |> int

    let hello (timer: TimerInfo, log: TraceWriter) = 
        let christmas = DateTime(2017, 12, 25)
        daysUntil christmas
        |> sprintf "%d days until Christmas"
        |> log.Info

