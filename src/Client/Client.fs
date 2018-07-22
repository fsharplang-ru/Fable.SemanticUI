module Client
open Elmish
open Elmish.React
open Fable.Helpers.React
open Semantic.Elements.Api
open Semantic.Elements
open Fable.Core
open Fable.Helpers.React.Props


type Counter = int
type Model = Counter option
type Msg = | Increment| Decrement
let init () : Model * Cmd<Msg> = 
   Some 42, Cmd.none
let update (msg : Msg) (model : Model) : Model * Cmd<Msg> =
    let model' =
        match model,  msg with
        | Some x, Increment -> Some (x + 1)
        | Some x, Decrement -> Some (x - 1)
        | _ -> None
    model', Cmd.none


let view (model : Model) (dispatch : Msg -> unit) =
    Container.container [ 
                          Container.TextAlign Semantic.Center
                          Container.Props [ OnClick (fun _ -> Fable.Import.Browser.console.warn ("Hello!") ) ] ]  
                        [
                          Header.header [ Header.Size <| Header.Huge] 
                                        [ str "Semanic UI + Fable" ]
                          Divider.divider [ Divider.Horizontal true ] [
                              str "From "
                              Flag.flag [ Flag.Name Flags.Russia ]
                              str "with love"  ] 
                          p  [] [ str "Press buttons to manipulate counter:"
                                  Icon.icon [ Icon.Name Icons.ArrowUp ] ]
                          p [] [
                                Button.group [] [ 
                                                Button.button [
                                                            Button.OnClick  (fun _ -> dispatch Decrement)
                                                            Button.Toggle true
                                                            Button.IsAnimated true 
                                                            Button.Primary true ] 
                                                            [ 
                                                                Button.content [  Button.Content.Hidden  true  ] [
                                                                                     str "-1"
                                                                                 ]
                                                                Button.content [ Button.Content.Visible  true ] [
                                                                                     str "Decrement"
                                                                                 ]
                                                            ]
                                                Button.or'  [ Button.Or.Text  <| (match model with | Some x -> string x | None -> "Loading...")
                                                              Button.Or.Props [ OnClick ( fun _ ->  Fable.Import.Browser.window.alert ( model |> string ) ) ]  ]
                                                Button.button
                                                     [ Button.OnClick (fun _ -> dispatch Increment )
                                                       Button.Animated Button.Fade
                                                       Button.Negative true ] 
                                                     [ 
                                                         Button.content [ Button.Content.Hidden true ] [
                                                             str "+1"
                                                         ]
                                                         Button.content [ Button.Content.Visible true ] [
                                                            str "Increment"
                                                         ]
                                                     ]
                                             ]
                                  ]
                          
                          p [  ] [
                              Image.image [ Image.Centered true 
                                            Image.VerticalAlign Semantic.Middle
                                            Image.Size Semantic.Small
                                            Image.Href "https://react.semantic-ui.com/introduction"
                                            Image.Src "https://react.semantic-ui.com/logo.png" ]
                          ]
                          p [] [ Button.button [ Button.Text "lol"
                                                 Button.Icon Icons.Percent
                                               ] [  ] ]
                          p [] [ Input.input [ Input.Action <| Button.button [ Button.Text "Some text" ] []  ] [] ]
                          p [] [ Label.label [] [ str "ama label"]  ]
                          p [] [
                              Input.input [ Input.IsAction true ] [
                                  Button.button [ Button.Icon Icons.Rub ] [ ]
                                  Button.button [ Button.Icon Icons.Usd ] [ ]
                                  Button.button [ Button.Icon Icons.Eur ] [ ]

                              ] ]
                          p [] [
                              Input.input [ 
                                  Input.Label <|  Button.button [  Button.OnClick (fun _ -> printf "asas") ] [ str "sdsdds" ]   ] []
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
