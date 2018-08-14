namespace Semantic.Modules.Api


open Fable.Import.React
open Fable.Helpers.React.Props
open Fable.Core
[<RequireQualifiedAccess>]
module Sticky =
  type Options =
  | Active of bool
  | As of string
  | BottomOffset of int
  | ClassName of string
  | Context of obj
  | Offset of int
  | OnBottom of ( SyntheticEvent -> obj -> unit)
  | OnSick of (SyntheticEvent -> obj -> unit)
  | OnTop of (SyntheticEvent -> obj -> unit)
  | OnUnstick of (SyntheticEvent -> obj -> unit)
  | Pushing of bool
  | ScrollContext of obj
  | Props of IHTMLProp list
  with interface IHTMLProp

  let sticky (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Sticky" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)