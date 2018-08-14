namespace Semantic.Behaviors.Api

open Fable.Core
open Fable.Helpers.React.Props
[<RequireQualifiedAccess>]
module Visibility =
  [<StringEnum>]
  type Direction =
  | [<CompiledName "down">] Down
  | [<CompiledName "up">] Up
  type Calculations = {
      bottomPassed : bool
      bottomVisible : bool
      direction : Direction
      fits : bool
      height : int
      passing : bool
      percentagePassed : float
      pixelsPassed : float
      offScreen : bool
      onScreen : bool
      topPassed : bool
      topVisible : bool
      width : int
  }
  type VisibilytyData = {
      calculations : Calculations
  }
  [<StringEnum>]
  type UpdateOn = | [<CompiledName "events">] Events 
                  | [<CompiledName "repaint">] Repaint

  type Options =
  | As of string
  | Context of obj
  | Continuous of bool
  | FireOnMount of bool
  | Offset of int
  | [<CompiledName "offset">] OffsetArr of int array
  | OnBottomPassed of (obj -> VisibilytyData  -> unit)
  | OnBottomPassedReverse of (obj -> VisibilytyData  -> unit)
  | OnBottomVisible  of (obj -> VisibilytyData  -> unit)
  | OnBottomVisibleReverse  of (obj -> VisibilytyData  -> unit)
  | OnPassed  of (obj -> VisibilytyData  -> unit)
  | OnPassing  of (obj -> VisibilytyData  -> unit)
  | OnPassingReverse  of (obj -> VisibilytyData  -> unit)
  | OnOffScreen  of (obj -> VisibilytyData  -> unit)
  | OnOnScreen  of (obj -> VisibilytyData  -> unit)
  | OnTopPassed  of (obj -> VisibilytyData  -> unit)
  | OnTopPassedReverse  of (obj -> VisibilytyData  -> unit)
  | OnTopVisible  of (obj -> VisibilytyData  -> unit)
  | OnTopVisibleReverse  of (obj -> VisibilytyData  -> unit)
  | OnUpdate  of (obj -> VisibilytyData  -> unit)
  | UpdateOn of UpdateOn
  | Props of IHTMLProp list
  with interface IHTMLProp
  
  let visibility (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Visibility" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)