namespace Semantic.Elements.Api

open Fable.Helpers.React.Props
open System.Drawing
[<RequireQualifiedAccessAttribute>]
module Icon = 
  open Fable.Core
  module Group = 
    type Options =
      | As of string
      | ClassName of string
      | Size of Semantic.Sizes
      | Props of IHTMLProp list
      with interface IHTMLProp

  [<StringEnum>]
  type Rotated =
    | Clockwise 
    | Counteclockwise
  type Options =
     ///An element type to render as. Default <i>
   | As of string
   ///Formatted to appear bordered.
   | Bordered of bool
   ///Icon can formatted to appear circular.
   | Circular of bool
   ///Additional classes.
   | ClassName of string
   ///Color of the icon.
   | Color of Semantic.Collor
   ///Icons can display a smaller corner icon.
   | Coner of bool
   /// Show that icon is inactive
   | Disabled of bool
   ///Fitted, without space left or right of Icon.
   | Fitted of bool
   /// Fomatted to have its color inverted for contrasts
   | Inverted of bool
   ///Icon can be formatted as a link
   | Link of bool
   /// Icon can be used as a simple loader
   | Loading of bool
   ///Name of the icon
   | Name of Semantic.Elements.Icons.IIcon
   ///Icon can rotated
   | Roteted of bool
   ///Size of icon
   | Size of Semantic.Sizes
   ///Other react props
   | Props of IHTMLProp list
   with interface IHTMLProp
  let icon (props: Options list) =
        let p = props |> List.fold ( fun s q -> match q with 
                                                    | Options.Props x -> s @ x 
                                                    | a -> (a :> IHTMLProp ) :: s  ) [] 
        Fable.Helpers.React.ofImport "Icon" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p) []

  let group (props: Group.Options list) =
        let p = props |> List.fold ( fun s q -> match q with 
                                                    | Group.Props x -> s @ x 
                                                    | a -> (a :> IHTMLProp ) :: s  ) [] 
        Fable.Helpers.React.ofImport "Icon.Group" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)
      

