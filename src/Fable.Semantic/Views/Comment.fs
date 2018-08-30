namespace Semantic.Views.Api
open Fable.Helpers.React.Props
open Fable.Core

[<RequireQualifiedAccess>]
module Comment =
  type Options =
  | As of string
  | ClassName of string
  | Collapsed of bool
  | Props of IHTMLProp list
  with interface IHTMLProp

  let comment (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Comment" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Action =
    type Options =
      | Active of bool
      | As of string
      | ClassName of string
      | Props of IHTMLProp list
      with interface IHTMLProp

  let action (props: Action.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Action.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Comment.Action" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Actions =
    type Options =
      | As of string
      | ClassName of string
      | Props of IHTMLProp list
      with interface IHTMLProp

  let actions (props: Actions.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Actions.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Comment.Actions" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Author =
    type Options =
      | As of string
      | ClassName of string
      | Props of IHTMLProp list
      with interface IHTMLProp

  let author (props: Author.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Author.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Comment.Author" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Avatar =
    type Options =
      | As of string
      | ClassName of string
      | Src of string
      | Props of IHTMLProp list
      with interface IHTMLProp

  let avatar ( props: Avatar.Options list ) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Avatar.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Comment.Avatar" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  []

  module Content =
    type Options =
      | As of string
      | ClassName of string
      | Props of IHTMLProp list
      with interface IHTMLProp

  let content ( props: Content.Options list ) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Content.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Comment.Content" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)

  module Group =
    type Options =
      | As of string
      | ClassName of string
      | Collapsed of bool
      | Minimal of bool
      | Size of Semantic.Sizes
      | Threaded of bool
      | Props of IHTMLProp list
      with interface IHTMLProp

  let group ( props: Group.Options list ) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Group.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Comment.Group" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p) 

  module Metadata =
    type Options =
      | As of string
      | ClassName of string
      | Props of IHTMLProp list
      with interface IHTMLProp

  let metadata  ( props: Metadata.Options list ) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Metadata.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Comment.Metadata" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)

  module Text =
    type Options =
      | As of string
      | ClassName of string
      | Props of IHTMLProp list
      with interface IHTMLProp

  let text  ( props: Text.Options list ) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Text.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Comment.Text" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)