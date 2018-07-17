
namespace Semantic

// open Fable.Import.React
open Fable.Helpers.React
open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React.Props
open Fable.Import

// open Fable
type ButtonAnimatedOptions = | Fade | Vertical | True
  [<StringEnum>]
  type ButtonAttachedOptions = | Left | Right | Top | Bottom
  [<StringEnum>]
  type ButtonCollor = 
    |Red |Orange |Yellow |Olive |Ggreen |Teal |Blue |Violet|Purple |Pink |Brown |Grey |Black |Facebook |[<CompiledName("google plus")>]GooglePlus |Instagram |Linkedin |Twitter |Vk |Youtube 
  [<StringEnum>]
  type ButtonLabelPostion = Left | Right

// [<Pojo>]
[<RequireQualifiedAccess>]
module Button = 
  type [<Pojo>] OptionObj = {
    active : bool 
    circular : bool
  }
  type Option =
    ///A button can show it is currently the active user selection.
    | Active
    ///An element type to render as f.e. 'div', 'a', etc.
    | As of string
    ///A button can animate to show hidden content.
    | Animated of ButtonAnimatedOptions 
    ///A button can be attached to other content.
    | Attached of ButtonAttachedOptions
    ///A basic button is less pronounced.
    | Basic
    ///A button can be circular.
    | Circular
    ///A button can have different colors
    | Color of ButtonCollor
    ///A button can reduce its padding to fit into tighter spaces.
    | Compact
    ///A button can show it is currently unable to be interacted with.
    | Disabled
    ///A button can be aligned to the left or right of its container.
    | Floated of Semantic.Floats
    ///	A button can take the width of its container.
    | Fluid 
    ///  ?? TODO check is this need
    | Icon
    ///A button can be formatted to appear on dark backgrounds.
    | Inverted
    /// A labeled button can format a Label or Icon to appear on the left or right.
    | LabelPosition of ButtonLabelPostion
    /// A button can show a loading indicator.
    | Loading 
    ///A button can hint towards a negative consequence.
    | Negative
    ///Called after user's click. 
    /// OnClick ( fun (event, data) -> .. ) 
    /// event - React's original SyntheticEvent.
    /// data - All props.
    | OnClick of  (( React.SyntheticEvent * obj ) -> unit)
    ///A button can hint towards a positive consequence.
    | Poitive 
    //A button can be formatted to show different levels of emphasis.
    | Primary 
    ///The role of the HTML element. default : 'button'
    | Role of string
    ///A button can be formatted to show different levels of emphasis.
    | Secondary 
    ///A button can have different sizes.
    | Size of Semantic.Sizes
    ///A button can receive focus.
    | TabIndex of int
    ///A button can be formatted to toggle on and off.
    | Toggle
    ///Custom props
    | Props of IHTMLProp list

    
    
  let button (props: Option list) children = 
      ofImport "Button" "semantic-ui-react" (keyValueList CaseRules.LowerFirst props) children
  let button' (props:  OptionObj ) =
       ofImport "Button" "semantic-ui-react" props