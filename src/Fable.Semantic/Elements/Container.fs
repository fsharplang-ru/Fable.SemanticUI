namespace Semantic.Elements.Api


open Fable.Helpers.React.Props
open Fable.Core
[<RequireQualifiedAccess>]
module Container =
   type ContentOptions = 
    /// An element type to render as.
   | As of string
   /// Additional classes.
   | ClassName of string
   /// Container has no maximum width.
   | Fluid of bool
   /// Align container text.
   | TextAlign of Semantic.TextAlignments
   //// Reduce maximum width to more naturally accommodate text.
   | Text of bool
   ///Other React props
   | Props of IHTMLProp list
   with interface IHTMLProp


   let container (props: ContentOptions list ) = 
       let htmlProps = props |> List.fold (fun s x -> match x with | Props p ->  s @ p | a -> (a :> IHTMLProp) ::s ) []
       Fable.Helpers.React.ofImport "Container" "semantic-ui-react" ( Fable.Core.JsInterop.keyValueList CaseRules.LowerFirst htmlProps )
