namespace Semantic.Views.Api
open Fable.Core

open Fable.Helpers.React.Props
[<RequireQualifiedAccess>]
module Item =
  type Options = 
  | As of string
  | ClassName of string
  | Props of IHTMLProp list
  with interface IHTMLProp
  
  let item (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Item" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)    

  module Content =
    type Options =
    | As of string
    | ClassName of string
    | VerticalAlign of Semantic.VerticalAlignments
    | Props of IHTMLProp list
    with interface IHTMLProp
  
  let content (props: Content.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Content.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Item.Content" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)    

  module Description =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  
  let description (props: Description.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Description.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Item.Description" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)    

  module Extra =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  let extra (props: Extra.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Extra.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Item.Extra" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Group =
    type Options =
    | As of string
    | ClassName of string
    | Divided of bool
    | Link of bool
    | [<CompiledName "relaxed">] IsRelaxed of bool
    | Relaxed of Semantic.Relaxed
    | Unstackable of bool
    | Props of IHTMLProp list
    with interface IHTMLProp

  let group (props: Group.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Group.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Item.Group" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p) 


  module Header =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  let header (props: Header.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Header.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Item.Header" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  let image (props: Semantic.Elements.Api.Image.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Semantic.Elements.Api.Image.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Item.Image" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  


  module Metadata =
    type Options = 
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  
  let metadata (props: Metadata.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Metadata.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Item.Metadata" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  