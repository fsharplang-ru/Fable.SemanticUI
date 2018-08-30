namespace Semantic.Views.Api

open Fable.Core
open Fable.Helpers.React.Props
open System.Drawing

[<RequireQualifiedAccess>]
module Statistic =
  [<StringEnum>]
  type Size = | Mini | Tiny | Small | Large | Huge
  type Options =
  | As of string
  | ClassName of string
  | Color of Semantic.Color
  | Floated of Semantic.Floats
  | Horizontal of bool
  | Inverted of bool
  | Size of Size
  | Text of bool
  | Props of IHTMLProp list
  with interface IHTMLProp

  let statistic (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Statistic" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Group =
    type Options =
    | As of string
    | ClassName of string
    | Color of Semantic.Color
    | Horizontal of bool
    | Inverted of bool
    | Size of Size
    | Width of Semantic.Widths
    | Props of IHTMLProp list
    with interface IHTMLProp

  let group (props: Group.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Group.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Statistic.Group" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Label =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp

  let label (props: Label.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Label.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Statistic.Label" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Value =
    type Options =
    | As of string
    | ClassName of string
    | Text of bool
    | Props of IHTMLProp list
    with interface IHTMLProp

  let value (props: Value.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Value.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Statistic.Value" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  