module Client
open Elmish
open Elmish.React
open Fable.Helpers.React
open Semantic.Elements.Api
open Semantic.Elements
open Fable.Core
open Fable.Helpers.React.Props
open Semantic.Elements.Icons
open Fable.Import.React


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
                              str "with "
                              Icon.icon [ Icon.Name Icons.Heart
                                          Icon.Color Semantic.Red ]  ] 
                          Segment.segment [ Segment.Basic true ] [ 
                                  str "Press buttons to manipulate counter:"
                                  Icon.icon [ Icon.Name Icons.ArrowUp ] ]
                          Segment.segment [ Segment.Basic true ] [
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
                          
                          Segment.segment [ Segment.Basic true ] [
                              Reveal.reveal [ Reveal.Animated Reveal.Fade
                                              Reveal.Props [  
                                                  Style [ Width "14%" ; Margin "0 auto" ]
                                                ] ] [
                                  Reveal.content [ Reveal.Content.Visible true ]
                                                 [
                                                   Image.image [    //Image.Centered true 
                                                                    //Image.VerticalAlign Semantic.Middle
                                                                    Image.Size Semantic.Small
                                                                    // Image.Href "https://react.semantic-ui.com/introduction"
                                                                    Image.Src  "https://react.semantic-ui.com/logo.png" ] ]
                                  Reveal.content [ Reveal.Content.Hidden true ] [
                                                   Image.image[ //Image.Centered true
                                                                //Image.VerticalAlign Semantic.Middle
                                                                Image.Size Semantic.Small
                                                                // Image.Href "http://fable.io/" 
                                                                Image.Src "http://fable.io/img/shared/fable_logo.png"]
                                  ]
                              ]

                          ]
                          Segment.segment [ Segment.Basic true ] [ Button.button [ Button.Text "lol"
                                                                                   Button.Icon Icons.Percent] 
                                                                                 [  ] ]
                          Segment.segment [ Segment.Basic true ] [ Input.input [ Input.Action <| Button.button [ Button.Text "Some text" ] []  ] [] ]
                          Segment.segment [ Segment.Basic true ] [ Label.label [] [ str "ama label"]  ]
                          Segment.segment [ Segment.Basic true ] [ Label.label [] [ str "Placeholde For DropDownList"]  ]
                          Segment.segment [ Segment.Basic true ] [
                              Input.input [ Input.IsAction true ] [
                                  Button.button [ Button.Icon Icons.Rub ] [ ]
                                  Button.button [ Button.Icon Icons.Usd ] [ ]
                                  Button.button [ Button.Icon Icons.Eur ] [ ]

                              ] ]
                          Segment.segment [ Segment.Basic true ] [
                              Input.input [ 
                                  Input.Label <|  Button.button [  Button.OnClick (fun _ -> printf "asas") ] [ str "sdsdds" ]   ] []
                          ]
                          Segment.segment [ Segment.Basic true ] [
                              Step.group [
                                //   Step.Group.Items [
                                //       [ 
                                //         //   Step.Icon Icons.Truck
                                //         //   Step.Title [ Semantic.Elements.Api.Step.Title.Options.ContentEl <| str "Shipping" ]
                                //         //   Step.Description [ Step.Description.Options.ContentEl <| str "Choose your shipping options"  ]
                                //       ]
                                //   ]
                               ] []
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
