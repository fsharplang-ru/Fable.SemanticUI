namespace Semantic.Elements.Api

[<RequireQualifiedAccess>]
module Divider =
  open Fable.Core
  type Options =
      | As of string
       ///Additional classes.
      | ClassName of string
       ///Divider can clear the content above it.
      | Clearing of bool
      ///Divider can be fitted without any space above or below it.
      | Fitted of bool
      ///Divider can divide content without creating a dividing line.
      | Hidden of bool
      ///Divider can segment content horizontally.
      | Horizontal of bool
      ///Divider can have its colours inverted.
      | Inverted of bool
      ///Divider can provide greater margins to divide sections of content.
      | Section of bool
      ///Divider can segment content vertically.
      | Vertical of bool
       ///Other React props
    | Props of Fable.Helpers.React.Props.IHTMLProp list
    with interface Fable.Helpers.React.Props.IHTMLProp
  let divider (props : Options list ) =
       let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> Fable.Helpers.React.Props.IHTMLProp ) :: s  ) []
       Fable.Helpers.React.ofImport "Divider" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)

