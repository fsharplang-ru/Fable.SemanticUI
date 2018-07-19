namespace Semantic.Elements.ObjectApi
open Fable.Helpers
open Semantic.Utils
type DividerOptions = {
      ``as`` : string
      ///Additional classes.
      className : string
      ///Divider can clear the content above it.
      clearing : bool
      ///Divider can be fitted without any space above or below it.
      fitted : bool
      ///Divider can divide content without creating a dividing line.
      hidden : bool
      ///Divider can segment content horizontally.
      horizontal : bool
      ///Divider can have its colours inverted.
      inverted : bool
      ///Divider can provide greater margins to divide sections of content.
      section : bool
      ///Divider can segment content vertically.
      vertical : bool
  }

[<RequireQualifiedAccess>]
module Divider =

  let dft = {
      ``as`` = typedNull<string>
      ///Additional classes.
      className = typedNull<string>
      ///Divider can clear the content above it.
      clearing = typedNull<bool>
      ///Divider can be fitted without any space above or below it.
      fitted = typedNull<bool>
      ///Divider can divide content without creating a dividing line.
      hidden = typedNull<bool>
      ///Divider can segment content horizontally.
      horizontal = typedNull<bool>
      ///Divider can have its colours inverted.
      inverted = typedNull<bool>
      ///Divider can provide greater margins to divide sections of content.
      section = typedNull<bool>
      ///Divider can segment content vertically.
      vertical = typedNull<bool>
  }

  let divider (props : DividerOptions) =
     React.ofImport "Divider" "semantic-ui-react" props 

namespace Semantic.Elements.ListApi

[<RequireQualifiedAccess>]
module Divider =
  type DeviderOptions =
      | As of string
       ///Additional classes.
      | ClassName of string
       ///Divider can clear the content above it.
      | Clearing of bool
      ///Divider can be fitted without any space above or below it.
      | Fitted of bool
      ///Divider can divide content without creating a dividing line.
      | Hidden of bool
      ///Divider can segment content horizontally.
      | Horizontal of bool
      ///Divider can have its colours inverted.
      | Inverted of bool
      ///Divider can provide greater margins to divide sections of content.
      | Section of bool
      ///Divider can segment content vertically.
      | Vertical of bool
  let private parseDeviderOptions (r : Semantic.Elements.ObjectApi.DividerOptions) opts =
     match opts with
     | As s -> {r with ``as`` = s }
     | ClassName s -> { r with className = s }
     | Clearing b -> {r with clearing = b} 
     | Fitted b -> { r with fitted = b }
     | Hidden b -> {r with hidden = b}
     | Horizontal b -> { r with horizontal = b }
     | Inverted b -> { r with inverted = b }
     | Section b -> { r with section = b }
     | Vertical b -> {r with vertical = b }

  let divider ( props : DeviderOptions list) =
        Semantic.Elements.ObjectApi.Divider.divider ( List.fold parseDeviderOptions Semantic.Elements.ObjectApi.Divider.dft  props  ) 

