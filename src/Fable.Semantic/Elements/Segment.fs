namespace Semantic.Elements.Api
open Fable.Core
open Fable.Helpers.React.Props
open Fable.Import.React

[<RequireQualifiedAccess>]
module Segment =
  [<StringEnum>]
  type Floated = | Left | Right
  [<StringEnum>]
  type Attached = | Top | Bottom
  [<StringEnum>]
  type Padded = | Very

  [<StringEnum>]
  type TextAligin = | [<CompiledName "left">] TextLeft | [<CompiledName "center">] TextCenter | [<CompiledName "right">] TextRight

  type Options = 
  | As of string
  | Attached of Attached
  | [<CompiledName "attached">]IsAttached of bool
  | Basic of bool
  | Circular of bool
  | ClassName of string
  | Clearing of bool
  | Color of Semantic.Color
  | Compact of bool
  | Disabled of bool
  | Floated of Floated
  | Inverted of bool
  | Loading of bool
  | [<CompiledName "padded">]IsPadded of bool
  | Padded of Padded
  | Piled of bool
  | Raised of bool
  | Secondary of bool
  | Size of Semantic.Sizes
  | Stacked of bool
  | Tertiary of bool
  | Vertical of bool
  | TextAlign of TextAligin
  | Props of IHTMLProp list
  with interface IHTMLProp
  
  module Group =
    type Options =
    | As of string
    | ClassName of string
    | Compact of bool
    | Horizontal of bool
    | Piled of bool
    | Raised of bool
    | Size of Semantic.Sizes
    | Stacked of bool
    | Props of IHTMLProp list
    with interface IHTMLProp
  let segment (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Segment" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  let group (props: Group.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Group.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Segment.Group" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  