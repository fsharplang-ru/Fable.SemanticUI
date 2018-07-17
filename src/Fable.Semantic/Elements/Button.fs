namespace Semantic

// open Fable.Import.React
open Fable.Helpers.React
open Fable.Core
open Fable.Core.JsInterop
// open Fable

// [<Pojo>]
module Button = 

  [<StringEnum>]
  type AnimatedOptions =
    | (*[<CompiledName("fade")>]*)Fade
    | (*[<CompiledName("vertical")>]*)Vertical
    | True
    
  type Option =
    | Active
    | Primary
    | Animated of AnimatedOptions  // | Position of Floats
  let button (props: Option list) children = 
      ofImport "Button" "semantic-ui-react" (keyValueList CaseRules.LowerFirst props) children