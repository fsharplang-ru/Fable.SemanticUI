namespace Semantic.Elements.Api

open Fable.Import
open Fable.Core
open Fable
open Fable.Helpers.React.Props
open System

[<RequireQualifiedAccessAttribute>]
module Input =
  [<StringEnum>]
  type Position = 
      | Left
  type ActionType = | Action of obj with interface IHTMLProp
  type Options =
      | [<CompiledName "action">]IsAction of bool
      | Action of Button.Options list
      | ActionPosition of Position
      ///An element type to render as f.e. 'div', 'a', etc.
      | As  of string
      | ClassName of string
      ///An Input can show it is currently unable to be interacted with.
      | Disabled of bool
      | Error of bool
      ///An Input can take the width of its container.
      | Fluid of bool 
      ///  ?? TODO check is this need
      | IsIcon of bool
      | Icon of Semantic.Elements.Icons.IIcon
      | IconPosition of Position
      | Input of bool
      ///An Input can be formatted to appear on dark backgrounds.
      | Inverted of bool
      /// A labeled button can format a Label or Icon to appear on the left or right.
    //   | LabelPosition of LabelPostion
      /// A button can show a loading indicator.
      | Loading of bool 
      ///A button can hint towards a negative consequence.
      | Negative of bool
      ///Called after user's click. 
      /// OnClick ( fun (event, data) -> .. ) 
      /// event - React's original SyntheticEvent.
      /// data - All props.
      | OnClick of  (( React.SyntheticEvent * obj) -> unit)
      ///A button can hint towards a positive consequence.
      | Positive of bool 
      //A button can be formatted to show different levels of emphasis.
      | Primary of bool 
      ///The role of the HTML element. default : 'button'
      | Role of string
      ///A button can be formatted to show different levels of emphasis.
      | Secondary of bool 
      ///A button can have different sizes.
      | Size of Semantic.Sizes
      ///A button can receive focus.
      | TabIndex of int
      ///A button can be formatted to toggle on and off.
      | Toggle of bool
       ///Other React props
      | Props of IHTMLProp list
      with interface IHTMLProp

  let input (props: Options list ) =
        let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | Action lst -> (( lst |> JsInterop.toPlainJsObj |> ActionType.Action  ) :> IHTMLProp) :: s
                                                | a -> (a :> IHTMLProp ) :: s  ) []
        Fable.Helpers.React.ofImport "Input" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)