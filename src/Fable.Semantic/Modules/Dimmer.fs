namespace Semantic.Modules.Api

open Fable.Import.React
open Fable.Helpers.React.Props
open Fable.Core
[<RequireQualifiedAccess>]
module Dimmer =
  type Options =
  | Active of bool
  | Page of bool
  | Props of IHTMLProp list
  with interface IHTMLProp

  let dimmer (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Dimmer" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
  
  module Dimmable =
    type Options =
    | As of string
    | Bluring of bool
    | ClassName of string
    | Dimmed of bool
    | Props of IHTMLProp list
    with interface IHTMLProp
  let dimmable (props: Dimmable.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Dimmable.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Dimmer.Dimmable" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
  
  module Inner =
    type Options =
    | Active of bool
    | As of string
    | ClassName of string
    | Disabled of bool
    | Invered of bool
    | OnClick of (SyntheticEvent -> obj -> unit)
    | OnClickOutside of (SyntheticEvent -> obj -> unit)
    | Page of bool
    | Simple of bool 
    | VerticalAlign of Semantic.Attached
    | Props of IHTMLProp list
    with interface IHTMLProp
  let inner (props: Inner.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Inner.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Dimmer.Inner" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  