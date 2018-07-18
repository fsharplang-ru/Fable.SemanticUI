namespace Semantic.Elements.ObjectApi

open Fable.Core
open Fable.Helpers
open Semantic
type [<Pojo>] ContentOptions = {
    /// An element type to render as.
   ``as`` : string
   /// Additional classes.
   className : string
   /// Container has no maximum width.
   fluid : bool
   /// Align container text.
   textAlign : Semantic.TextAlignments
   //// Reduce maximum width to more naturally accommodate text.
   text : bool
}
[<RequireQualifiedAccess>]
module Container =
   let dft : ContentOptions = {
       ``as`` = Utils.typedNull<string>
       className = Utils.typedNull<string>
       fluid = Utils.typedNull<bool>
       textAlign = Utils.typedNull<Semantic.TextAlignments>
       text = Utils.typedNull<bool>
   } 
   let container (props: ContentOptions ) = 
       React.ofImport "Container" "semantic-ui-react" props 

namespace Semantic.Elements.ListApi

open Semantic.Elements.ObjectApi
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

   let private parseContainerOptions (r : Semantic.Elements.ObjectApi.ContentOptions) opts = 
      match opts with 
      | As s -> { r with ``as`` = s }
      | ClassName s -> { r with className = s } 
      | Fluid s -> { r with fluid = s}
      | TextAlign s -> {r with textAlign=  s}
      | Text t -> { r with text = t }
    

   let container (props: ContentOptions list ) = 
       Semantic.Elements.ObjectApi.Container.container ( List.fold parseContainerOptions Container.dft props)
