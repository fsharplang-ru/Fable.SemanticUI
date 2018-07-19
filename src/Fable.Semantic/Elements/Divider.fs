namespace Semantic.Elements

namespace Semantic.Elements.ObjectApi

open Fable.Helpers
[<RequireQualifiedAccess>]
module Divider =
  type DividerOptions = {
      ``as`` : string
      ///Additional classes.
      className : string
      ///Divider can clear the content above it.
      clearing : bool
      ///Divider can be fitted without any space above or below it.
      fitted : bool
      ///Divider can divide content without creating a dividing line.
      hiden : bool
      ///Divider can segment content horizontally.
      horizontal : bool
      ///Divider can have its colours inverted.
      inverted : bool
      ///Divider can provide greater margins to divide sections of content.
      section : bool
      ///Divider can segment content vertically.
      vertical : bool
  }
  let divider (props : DividerOptions) =
     React.ofImport "Divider" "semantic-ui-react" props 
 