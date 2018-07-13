namespace Semantic

// open Fable.Import.React
open Fable.Helpers.React
open Fable.Core
open Fable.Core.JsInterop
// open Fable

// [<Pojo>]
module Button = 
  type AnimatedOptions =
    | Fade
    | Vertical
    | True
    
  type Option =
    | [<CompiledName("active")>]IsActive
    | [<CompiledName("primary")>]IsPrimary
    // | [<CompiledName("animated")>] IsAnimated
    | Animated of AnimatedOptions
    | Posiion of SemanticFloats

  let inline button (props: Option list) children = 
       ofImport "Button" "semantic-ui-react" ( keyValueList CaseRules.LowerFirst props ) children