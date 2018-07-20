namespace Semantic.Elements.Api

open Fable.Core
open Fable.Helpers.React.Props
open Fable.Import.React
[<RequireQualifiedAccessAttribute>]
module Label =
  module Detail = 
    type Options = 
    | As of string 
    | ClassName of string
    | Props of IHTMLProp list
    with interface IHTMLProp

  [<StringEnum>]
  type Attached = 
  | Top
  | Bottom
  | [<CompiledName "top right">]TopRight
  | [<CompiledName "top left">]TopLeft
  | [<CompiledName "bottom right">]BottomRight
  | [<CompiledName "bottom left">]BottomLeft

  [<StringEnum>]
  type Corner = | Left | Right

  type Options = 
  | Active of bool
  | As of string
  | Attached of Attached 
  | Basic of bool
  | Circular of bool
  | ClassName of string
  | Color of Semantic.Collor
  | Corner of Corner
  | Detail of Detail.Options list
  | Empty of ReactElement
  | Floating of bool
  | Horizontal of bool
  | Icon of Semantic.Elements.Icons.IIcon
  | [<CompiledName "image">]IsImage of bool
  | Image of ReactElement //TODO check
  
