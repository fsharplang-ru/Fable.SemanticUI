namespace Semantic.Modules.Api

open Fable.Import.React
open Fable.Helpers.React.Props
open Fable.Core
[<RequireQualifiedAccess>]
module Checkbox =
  [<StringEnum>]
  type CheckboxTypes = | Checkbox | Radio
  type Options = 
  | As of string
  | Checked of bool
  | DefaultChecked of bool
  | DefaultIndeterminate of bool
  | Disabled of bool
  | Fitted of bool
  | [<CompiledName "id">] IdNumber of int
  | [<CompiledName "id">] IdString of string
  | Indeterminate of bool
  | Name of string
  | OnChange of (SyntheticEvent -> obj -> unit)
  | OnClick of (SyntheticEvent -> obj -> unit)
  | OnMouseDown of (SyntheticEvent -> obj -> unit)
  | Radio of bool
  | ReadOnly of bool
  | Slider of bool
  | [<CompiledName "tabIndex">] TabIndexNumber of int
  | [<CompiledName "tabIndex">] TabIndexSring of string
  | Toggle of bool
  | Type of CheckboxTypes
  | [<CompiledName "value">] ValueNumber of float 
  | [<CompiledName "value">] Value of string
  | Props of IHTMLProp list
  with interface IHTMLProp

  let checkbox (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Checkbox" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  