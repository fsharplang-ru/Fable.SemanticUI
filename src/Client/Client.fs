module Client
open Elmish
open Elmish.React
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Semantic.Elements.Api
open Fable.Core
open Semantic.Elements
open Fable.Import
// open Semantic.Elements.ObjectApi


type Counter = int
type Model = Counter option
type Msg = | Increment| Decrement
let init () : Model * Cmd<Msg> = 
//    JS.setInterval ( fun () -> JS.console.clear () ) 15000 |> ignore
   Some 43, Cmd.none
let update (msg : Msg) (model : Model) : Model * Cmd<Msg> =
    let model' =
        match model,  msg with
        | Some x, Increment -> Some (x + 1)
        | Some x, Decrement -> Some (x - 1)
        | _ -> None
    model', Cmd.none

let showObjApiButton strn onCLick = 
             Button.button [
                    Button.OnClick  onCLick
                    Button.Option.Toggle true
                    Button.IsAnimated true 
                    Button.Option.Primary true ] 
                    [ 
                        Button.content [  Button.Content.Hidden  true  ] [
                                             str "-1"
                                         ]
                        Button.content [ Button.Content.Visible  true ] [
                                             str strn
                                         ]
                    ]                                          


let showListApiButton strn onClick  = 
       Button.button
                     [ Button.OnClick onClick
                       Button.Option.Negative true ] 
                     [ 
                         str "Click list api"
                     ]

let view (model : Model) (dispatch : Msg -> unit) =
    div [] [  
            Container.container [ Container.TextAlign Semantic.Center
                                  Container.Props [ OnClick (fun _ -> Fable.Import.Browser.console.warn ("asasad") ) ] ] [
              h1 [] [ str "Semanic UI + Fable " ]
              Divider.divider [ Divider.Horizontal true ] [
                  str "From "
                  Flag.flag [ Flag.Name Flags.Russia ]
                  str "with love"
              ] 
              p  [] [ str "Press buttons to manipulate counter:" ]
              Button.group [] [ showObjApiButton "Decrement!" (fun _ ->   dispatch Decrement)
                                Button.or'  [ Button.Or.Text  <| (match model with | Some x -> string x | None -> "Loading...") ]
                                showListApiButton "=" (fun _ -> dispatch Increment)
                                             ]
            ]
    ]


#if DEBUG
open Elmish.Debug
open Elmish.HMR
#endif

Program.mkProgram init update view
#if DEBUG
|> Program.withConsoleTrace
|> Program.withHMR
#endif
|> Program.withReact "elmish-app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run
