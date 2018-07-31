namespace Semantic.Collections.Api

open Fable.Core
open Fable.Import.React
open Fable.Helpers.React.Props


[<RequireQualifiedAccess>]
module Message =
  type Options =
  | As of string
  | Attached of Semantic.Attached
  | [<CompiledName "attached">] IsAttached of bool
  | ClassName of string
  | Color of Semantic.Color
  | Compact of bool
  | Error of bool
  | Floating of bool
  | [<CompiledName "icon">] IsIcon of bool
  | Icon of Semantic.Elements.Icons.IIcon
  | Info of bool 
  | Negative of bool
  | OnDismiss of (SyntheticEvent -> obj -> unit)
  | Positive of bool
  | Size of Semantic.Sizes
  | Success of bool
  | Visible of bool
  | Warning of bool
  | Props of IHTMLProp list
  with interface IHTMLProp

  let message (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Message" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)
  
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
    Fable.Helpers.React.ofImport "Message.Content" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)

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
    Fable.Helpers.React.ofImport "Message.Header" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)

  module Item =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp

  let item (props: Item.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Item.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Message.Item" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)

  module List =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp

  let list (props: List.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | List.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Message.List" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)