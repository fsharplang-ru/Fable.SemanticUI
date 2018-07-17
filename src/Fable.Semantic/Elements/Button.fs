namespace Semantic

// open Fable.Import.React
open Fable.Helpers.React
open Fable.Core
open Fable.Core.JsInterop
// open Fable

// [<Pojo>]
module Button = 
  type AnimatedOptions =
    | (*[<CompiledName("fade")>]*)Fade
    | (*[<CompiledName("vertical")>]*)Vertical
    | True
    
  type Option =
    | (*[<CompiledName("active")>]*)Active
    | (*[<CompiledName("primary")>]*)Primary
    | (*[<CompiledName("animated")>]*)Animated
    // | Position of Floats

  let inline button (props: Option list) children = 
      printf "%A" props
      ofImport "Button" "semantic-ui-react" props children