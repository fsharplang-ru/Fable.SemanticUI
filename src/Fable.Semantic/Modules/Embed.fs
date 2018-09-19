namespace Semantic.Modules.Api

open Fable.Import.React
open Fable.Helpers.React.Props
open Fable.Core
[<RequireQualifiedAccess>]
module Embed =
  [<StringEnum>]
  type AspectRatio = | [<CompiledName "4:3">]N4_3 | [<CompiledName "16:9">]N16_9 | [<CompiledName "21:9">]N21_9
  [<StringEnum>] 
  type Source = | Youtube | Vimeo
  type Options = 
  | Active of bool
  | As of string
  | AspectRatio of AspectRatio
  | AutoPlay of bool
  | BrandedUI of bool
  | ClassName of string
  | Color of string
  | DefaultActive of bool
  | Hd of bool
  | Icon of Semantic.Elements.Icons.IIcon
  | Id of string
  | Iframe of obj ///TODO
  | OnClick of (SyntheticEvent -> obj -> unit)
  | Placeholder of string
  | Source of Source
  | Url of string
  | Props of IHTMLProp list
  | Custom of (string * obj)
  with interface IHTMLProp

  let embed (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Embed" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  