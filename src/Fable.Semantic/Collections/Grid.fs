namespace Semantic.Collections.Api
open Fable.Core
open Fable.Import.React
open Fable.Helpers.React.Props
open Fable.Helpers.React
open System.Drawing

[<RequireQualifiedAccessAttribute>]
module Grid =
  [<StringEnum>]
  type Divided = | [<CompiledName "verticaly">]VerticallyDivided
  [<StringEnum>]
  type Padded = | [<CompiledName "verticaly">]VerticallyPadded | [<CompiledName "horizontaly">] HorizontalyPadded
  [<StringEnum>]
  type Celled = | Internaly

  type Options =
  | As of string
  | [<CompiledName "celled">]IsCelled of bool
  | Celled of Celled
  | ClassName of string
  | Columns of Semantic.Widths
  | Container of bool
  | Divided of Divided
  | [<CompiledName "divided">] IsDivided of bool
  | Doubling of bool
  | Invered of bool
  | Padded of Padded
  | Relaxed of Semantic.Relaxed
  | [<CompiledName "relaxed">] IsRelaxed of bool
  | Reversed of Semantic.Reverse
  | Stackable of bool
  | Streched of bool
  | TextAlign of Semantic.TextAlignments
  | VerticalAlign of Semantic.VerticalAlignments
  | Props of IHTMLProp list
  with interface IHTMLProp

  let grid (props: Options list) =
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Grid" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
  
  module Column =

      type Options =
      | As of string
      | ClassName of string
      | Color of Semantic.Color
      | Computer of Semantic.Widths
      | Floated of Semantic.Floats
      | LargeScreen of Semantic.Widths
      | Mobile of Semantic.Widths
      | Only of Semantic.Visibility
      | Stretched of bool
      | Tablet of Semantic.Widths
      | TextAlign of Semantic.TextAlignments
      | VerticalAlign of Semantic.VerticalAlignments
      | Widescreen of Semantic.Widths
      | Width of Semantic.Widths
      | Props of IHTMLProp list
      with interface IHTMLProp

  let column (props : Column.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Column.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Grid.Column" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
      
  module Row =
    type Options =
    | As of string
    | Centered of bool
    | ClassName of string
    | Color of Semantic.Color
    | Columns of Semantic.Widths
    | Divided of bool
    | Only of Semantic.Visibility
    | Reversed of Semantic.Reverse
    | Stretched of bool
    | TextAlign of Semantic.TextAlignments
    | VerticalAlign of Semantic.VerticalAlignments
    | Props of IHTMLProp list
    with interface IHTMLProp
  
  let row (props : Row.Options list) =
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Row.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Grid.Row" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  