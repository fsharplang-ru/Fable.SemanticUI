namespace Semantic.Collections.Api

open Fable.Core
open Fable.Helpers.React.Props
open Semantic
open Fable

[<RequireQualifiedAccess>]
module Table =
  [<StringEnum>]
  type TableSizes = | Small | Large
  [<StringEnum>]
  type TableTextAlign = | Left | Center | Right
  type Options =
  | As of string
  | Attached of Attached
  | [<CompiledName "basic">] IsBasic of bool
  | Basic of  Semantic.Relaxed
  | Celled of bool
  | ClassName of string
  | Collapsing of bool
  | Color of Semantic.Color
  | Columns of Semantic.Widths
  | Compact of Semantic.Relaxed
  | [<CompiledName "compact">] IsCompact of bool
  | Definition of bool
  | Fixed of bool
  | Inverted of bool
  | Padded of Semantic.Relaxed
  | [<CompiledName "padded">] IsPadded of bool
//   | RenderBodyRow of data :'a -> index: int -> // TODO do we need it?
  | Selectable of bool
  | SingleLine of bool
  | Size of TableSizes
  | Sortable of bool
  | Stackable of bool
  | Striped of bool
  | Structured of bool
  | TextAlign of TableTextAlign
  | Unstackable of bool
  | VerticalAlign of Semantic.VerticalAlignments
  | Props of IHTMLProp list
  with interface IHTMLProp

  let table (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Table" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)
  
  module Body =
    type Options =
    | As of string
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  let body (props: Body.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Body.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Table.Body" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)
  
  module Cell =
    type Options =
    | Active of bool
    | As of string
    | ClassName of string
    | Collapsing of bool
    | Disabled of bool
    | Error of bool
    | Icon of Semantic.Elements.Icons.IIcon
    | Negative of bool
    | Positive of bool
    | Selectable of bool
    | SingleLine of bool
    | TextAlign of TableTextAlign
    | VerticalAlign of Semantic.VerticalAlignments
    | Warning of bool
    | Width of Semantic.Widths
    | Props of IHTMLProp list
    with interface IHTMLProp 

  let cell (props: Cell.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Cell.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Table.Cell" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)
  
  module Footer = 
    type Options =
    | As of string
    | Props of IHTMLProp list
    with interface IHTMLProp
  
  let footer (props: Footer.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Footer.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Table.Footer" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)
 
  module Header =
   type Options =
   | As of string
   | ClassName of string
   | FullWidth of bool
   | Props of IHTMLProp list
   with interface IHTMLProp

  let header (props: Header.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Header.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Table.Header" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)
  
  module HeaderCell = 
   [<StringEnum>]
   type Sorted = | Ascending | Descending
   type Options =
   | As of string
   | ClassName of string
   | Sorted of Sorted
   | Props of IHTMLProp list
   with interface IHTMLProp

  let headerCell (props: HeaderCell.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | HeaderCell.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Table.HeaderCell" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)
  
  module Row =
    type Options =
    | Active of bool
    | As of string
    | CellAs of string
    | ClassName of string
    | Disabled of string
    | Error of string
    | Negative of bool
    | Positive of bool
    | TextAlign of TableTextAlign
    | VerticalAlign of Semantic.VerticalAlignments
    | Warning of bool
    | Props of IHTMLProp list
    with interface IHTMLProp

  let row (props: Row.Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Row.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Table.Row" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)