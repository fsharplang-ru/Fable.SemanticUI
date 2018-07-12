module SemanticUI

// open Fable.Import.React
open Fable.Helpers.React
open Fable.Core
open Fable.Core.JsInterop
// open Fable

// [<Pojo>]
module Button = 
  type Option =
    | Primary
//   [<PojoAttribute>]
//   type  Option = {
//       Primary : bool
//   }
  let inline button (props: Option list) children = 
       ofImport "Button" "semantic-ui-react" ( keyValueList CaseRules.LowerFirst props ) children