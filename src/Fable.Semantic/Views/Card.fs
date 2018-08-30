namespace Semantic.Views.Api
open Fable.Core
open Fable.Helpers.React.Props
open Semantic
open Fable.Import.React

[<RequireQualifiedAccess>]
module Card =
  [<StringEnum>]
  type TextAlign = | Left | Right | Center
  type Options =
  | As of string
  | Centered of bool
  | ClassName of string
  | Color of Semantic.Color
  | Fluid of bool
  | Href of string
  | Link of bool
  | OnClick of (SyntheticEvent -> obj -> unit)
  | Raised of bool
  | Props of IHTMLProp list
  with interface IHTMLProp

  let card (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Card" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
  
  module Content =
      

      type Options =
      | As of string
      | ClassName of string
      | Extra of bool
      | TextAlign of TextAlign
      | Props of IHTMLProp list
      with interface IHTMLProp
  let content (props: Content.Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                  | Content.Props x -> s @ x 
                                                  | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "Card.Content" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Description  =
      type Options =
      | As of string
      | ClassName of string
      | TextAlign of TextAlign
      | Props of IHTMLProp list
      with interface IHTMLProp
  let description  (props: Description.Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                  | Description.Props x -> s @ x 
                                                  | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "Card.Description" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Group   =
      type Options =
      | As of string
      | Centered of bool
      | ClassName of string
      | Doubling of bool
      | ItemsPerRow of Semantic.Widths
      | Stackable of bool
      | TextAlign of TextAlign
      | Props of IHTMLProp list
      with interface IHTMLProp
  let group   (props: Group.Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                  | Group.Props x -> s @ x 
                                                  | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "Card.Group" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Header  =
      type Options =
      | As of string
      | ClassName of string
      | TextAlign of TextAlign
      | Props of IHTMLProp list
      with interface IHTMLProp
  let header  (props: Header.Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                  | Header.Props x -> s @ x 
                                                  | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "Card.Header" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Meta  =
      type Options =
      | As of string
      | ClassName of string
      | TextAlign of TextAlign
      | Props of IHTMLProp list
      with interface IHTMLProp
  let meta  (props: Meta.Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                  | Meta.Props x -> s @ x 
                                                  | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "Card.Meta" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  