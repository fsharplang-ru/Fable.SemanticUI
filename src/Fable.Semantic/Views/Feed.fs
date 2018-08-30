namespace Semantic.Views.Api

open Fable
open Fable.Core
open Fable.Helpers.React.Props
[<RequireQualifiedAccess>]
module Feed =
  [<StringEnum>]
  type Size = | Small | Large
  type Options =
  | As of string
  | ClassName of string
  | Size of Size
  | Props of IHTMLProp list
  with interface IHTMLProp
  let feed (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Feed" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
  
  module Content =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  let content (props: Content.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Content.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Feed.Content" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Date =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  let date (props: Date.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Date.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Feed.Date" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Event =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  let event (props: Event.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Event.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Feed.Event" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Extra =
    type Options =
    | As of string
    | ClassName of string
    | Text of bool
    | Images of bool
    | Props of IHTMLProp list
    with interface IHTMLProp
  let extra (props: Extra.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Extra.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Feed.Extra" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

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
    Fable.Helpers.React.ofImport "Feed.Label" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Like =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  let like (props: Like.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Like.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Feed.Like" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Meta =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  let meta (props: Meta.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Meta.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Feed.Meta" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Summary =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  let summary (props: Summary.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Summary.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Feed.Summary" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module User =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  let user (props: User.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | User.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Feed.User" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  