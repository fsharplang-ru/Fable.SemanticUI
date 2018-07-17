module Client
open Elmish
open Elmish.React
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Semantic
open Semantic
type Counter = int
type Model = Counter option
type Msg = | Increment| Decrement
let init () : Model * Cmd<Msg> = Some 467, Cmd.none
let update (msg : Msg) (model : Model) : Model * Cmd<Msg> =
    let model' =
        match model,  msg with
        | Some x, Increment -> Some (x + 1)
        | Some x, Decrement -> Some (x - 1)
        | _ -> None
    model', Cmd.none
let view (model : Model) (dispatch : Msg -> unit) =
    div []
        [ h1 [] [ str "SAFE Template" ]
          p  [] [ str "Press buttons to manipulate counter:" ]
          Button.button [ Button.Active
                          Button.Floated Floats.Right
                          
                          Button.Toggle
                        //   Button.Primary
                          Button.OnClick (fun x -> Fable.Import.JS.console.warn(x) )
                          Button.Role "menu"
                            ]  [ str "Click"  ] 
          Button.button' { active = true ; circular = true  } [ str " lool " ]
          button [ OnClick (fun _ -> dispatch Decrement) ] [ str "--" ]
          div [] [ str "" ]
          button [ OnClick (fun _ -> dispatch Increment) ] [ str "++" ]
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
