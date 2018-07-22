namespace Semantic.Elements.Api
open Fable.Core
open Fable.Helpers.React.Props

[<RequireQualifiedAccess>]
module Loader =
  [<StringEnum>]
  type Inline = | Centered  
  type Options = 
  | Active of bool
  | As of string
  | ClassName of string
  | Disbled of bool
  | Indetermincate of bool
  | [<CompiledName "inline">]IsInline of bool 
  | Inline of Inline
  | Inverted of bool
  | Size of Semantic.Sizes
  | Props of IHTMLProp list
  with interface IHTMLProp

  let loader (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Loader" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  