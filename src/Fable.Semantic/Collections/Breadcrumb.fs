namespace Semantic.Collections.Api

open Fable.Core
open System
open Fable.Helpers.React.Props
open Fable.Import.React

[<RequireQualifiedAccessAttribute>]
module Breadcrumb = 
  type Options =
  | As of string
  | ClassName of string
  | Size of Semantic.Sizes
  | Props of IHTMLProp list
  with interface IHTMLProp

  let breadcrumb (props: Options list) =
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Breadcrumb" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
  
  module Divider =
    type Options =
    | As of string
    | ClassName of string
    | Icon of Semantic.Elements.Icons.IIcon
    | Props of IHTMLProp list
    with interface IHTMLProp

  let divider (props : Divider.Options list) =
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Divider.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Breadcrumb.Divider" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  []
  
  module Section =
      type Options =
      | Active of bool
      | As  of string
      | ClassName of string
      | Href of string
      | Link of bool
      | OnCLick of (SyntheticEvent * obj -> unit)
      | Props of IHTMLProp list
      with interface IHTMLProp

  let section (props: Section.Options list) =
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Section.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Breadcrumb.Section" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  