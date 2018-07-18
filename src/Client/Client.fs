module Client
open Elmish
open Elmish.React
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Semantic.Elements.ObjectApi
open Fable.Core


type Counter = int
type Model = Counter option
type Msg = | Increment| Decrement
let init () : Model * Cmd<Msg> = Some 42, Cmd.none
let update (msg : Msg) (model : Model) : Model * Cmd<Msg> =
    let model' =
        match model,  msg with
        | Some x, Increment -> Some (x + 1)
        | Some x, Decrement -> Some (x - 1)
        | _ -> None
    model', Cmd.none

let showObjApiButton strn onCLick = 
             Button.button { 
                 Button.buttonDft with 
                    onClick = onCLick
                    toggle = true
                    animated = U2.Case2 Fade
                    primary = true } 
                    [ 
                        Button.content { Button.contentDft with 
                                             hidden = true  } [
                                             str "-1"
                                         ]
                        Button.content { Button.contentDft with
                                             visible = true } [
                                             str strn
                                         ]
                    ]                                          

open Semantic.Elements.ListApi
let showListApiButton strn onClick  = 
   Button.buttonAsLink 
                 [ Button.OnClick onClick
                   Button.IsNegative true ] 
                 [ 
                     str "Click list api"
                 ]

let view (model : Model) (dispatch : Msg -> unit) =
    div []
        [ h1 [] [ str "SAFE Template" ]
          p  [] [ str "Press buttons to manipulate counter:" ]
          Button.group Button.groupDft (* { Button.groupDft with 
                                         vertical = true }  *)
                                         [
                                             showObjApiButton "Decrement!" (fun _ ->   dispatch Decrement)
                                             Button.Or  { Button.orDft with text = (match model with | Some x -> string x | None -> "Loading...") } 
                                             showListApiButton "=" (fun _ -> dispatch Increment)
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
