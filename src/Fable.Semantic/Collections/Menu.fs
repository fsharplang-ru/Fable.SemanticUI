namespace Semantic.Collections.Api

open Fable.Core
open Fable.Import.React
open Semantic
open Fable.Helpers.React.Props
open Fable

[<RequireQualifiedAccess>]
module Menu =
  [<StringEnum>]
  type Floated = | Right 
  type Options =
  | ActiveIndex of string
  | [<CompiledName "activeIndex">]ActiveIndexNumber of int
  | As of string
  | Attached of Semantic.Attached 
  | Borderless of bool
  | ClassName of string
  | Color of Semantic.Color
  | Compact of bool
  | DefaultActiveIndex of string
  | [<CompiledName "defaultActiveIndex">]DefaultActiveIndexNumver of int
  | Fixed of bool
  | Floated of Floated
  | [<CompiledName "floated">]IsFloated of bool
  | Icon of Semantic.Elements.Icons.IIcon
  | [<CompiledName "icon">]IsIcon of bool
  | Inverted of bool
  | OnItemClick of (SyntheticEvent * obj -> unit)
  | Pagination of bool
  | Secondary of bool
  | Size of Semantic.Sizes
  | Stackable of bool
  | Tabular of Floated
  | [<CompiledName "tabular">]IsTabular of bool
  | Text of bool
  | Vertical of bool
  | Widths of Semantic.Widths
  | Props of IHTMLProp list
  with interface IHTMLProp

  let menu (props: Options list) =
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Menu" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
  
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
    Fable.Helpers.React.ofImport "Menu.Header" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
 
  module Submenu =
    type Options =
    | As of string
    | ClassName of string
    | Position of Semantic.Floats
    | Props of IHTMLProp list
    with interface IHTMLProp
  
  let submenu (props : Submenu.Options list ) =
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Submenu.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Menu.Menu" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
  
  module Item =
    [<StringEnum>]
    type Fitted = | Horizonaly | Verticaly
    type Options =
    | Active of bool
    | As of string
    | ClassName of string
    | Color of Semantic.Color
    | Disabled of bool
    | Fitted of Fitted
    | Header of bool
    | Icon of Semantic.Elements.Icons.IIcon
    | [<CompiledName "icon">]IsIcon of bool 
    | Index of int
    | Link of bool
    | Name of string
    | OnClick of (SyntheticEvent * obj -> unit)
    | Position of Semantic.Floats
    | Props of IHTMLProp list
    with interface IHTMLProp

  let item (props: Item.Options list ) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Item.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Menu.Item" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p) 