open Fable.Import.React
namespace Semantic.Modules.Api

open Fable.Import.React
open Fable.Helpers.React.Props
open Fable.Core
open Fable
[<RequireQualifiedAccess>]
module Accordion =
  type Options =
  | ClassName of string
  | Fluid of bool
  | Inverted of bool
  | Styled of bool
  | Props of IHTMLProp list
  with interface IHTMLProp

  let accordion (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Accordion" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
  module SubAccordion =
    type Options =
    | ActiveIndex of int
    | [<CompiledName "activeIndex">] ActiveIndexes of int array
    | As of string
    | ClassName of string
    | DefaultActiveIndex of int
    | [<CompiledName "defaultActiveIndex">] DefaultActiveIndexes of int array
    | Exclusive of bool
    | OnTitleClick of (SyntheticEvent -> obj -> unit)
    | Props of IHTMLProp list
    with interface IHTMLProp 

  let subAccordion (props: SubAccordion.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | SubAccordion.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Accordion.Accordion" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
  
  module Content =
    type Options =
    | Active of bool
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp

  let сontent (props: Content.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Content.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Accordion.Content" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Panel =
    type Options =
    | Active of bool
    | [<CompiledName "index">] IndexNumber of int
    | [<CompiledName "index">] IndexString of string
    | OnTileClick of (SyntheticEvent -> obj -> unit)
    | Props of IHTMLProp list
    with interface IHTMLProp

  let panel (props: Panel.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Panel.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Accordion.Panel" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

  module Title =
    type Options =
    | Active of bool
    | As of string
    | ClassName of string
    | [<CompiledName "index">] IndexNumber of int
    | [<CompiledName "index">] IndexString of string
    | OnClick of (SyntheticEvent -> obj -> unit)
    | Props of IHTMLProp list
    with interface IHTMLProp

  let title (props: Title.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Title.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Accordion.Title" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  