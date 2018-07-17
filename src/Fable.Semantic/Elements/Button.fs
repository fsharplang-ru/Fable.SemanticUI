
namespace Semantic.Elements.ObjectApi

open Fable.Helpers.React
open Fable.Core
open Fable.Helpers.React.Props
open Semantic.Utils

  type ButtonAnimatedOptions = | Fade | Vertical  
  [<StringEnum>]
  type ButtonAttachedOptions = | Left | Right | Top | Bottom
  [<StringEnum>]
  type ButtonCollor = 
    |Red |Orange |Yellow |Olive |Ggreen |Teal |Blue |Violet|Purple |Pink |Brown |Grey |Black |Facebook |[<CompiledName("google plus")>]GooglePlus |Instagram |Linkedin |Twitter |Vk |Youtube 
  [<StringEnum>]
  type ButtonLabelPostion = Left | Right
  type [<Pojo>] ButtonOption = 
      {
        ///A button can show it is currently the active user selection.
        active : bool 
        ///An element type to render as f.e. 'div', 'a', etc.
        ``as`` : string
        ///A button can animate to show hidden content.
        animated : U2<bool,ButtonAnimatedOptions>
        ///A button can be attached to other content.
        attached : ButtonAttachedOptions
        ///A basic button is less pronounced.
        basic : bool
        ///A button can be circular.
        circular : bool
        ///Additional classes.
        className : string
        ///A button can have different colors
        color : ButtonCollor
        ///A button can reduce its padding to fit into tighter spaces.
        compact : bool
        ///A button can show it is currently unable to be interacted with.
        disabled : bool
        ///A button can be aligned to the left or right of its container.
        floated : Semantic.Floats
        ///A button can take the width of its container.
        fluid : bool
        ///  ?? TODO check if this needed
        icon : bool
        ///A button can be formatted to appear on dark backgrounds.
        inverted : bool
        /// A labeled button can format a Label or Icon to appear on the left or right.
        labelPosition : ButtonLabelPostion
        /// A button can show a loading indicator.
        loading  : bool
        ///A button can hint towards a negative consequence.
        negative : bool
        ///Called after user's click. 
        /// OnClick ( fun (event, data) -> .. ) 
        /// event - React's original SyntheticEvent.
        /// data - All props.
        onClick :  (( Fable.Import.React.SyntheticEvent * obj ) -> unit)
        ///A button can hint towards a positive consequence.
        positive : bool 
        //A button can be formatted to show different levels of emphasis.
        primary  : bool
        ///The role of the HTML element. default : 'button'
        role : string
        ///A button can be formatted to show different levels of emphasis.
        secondary : bool
        ///A button can have different sizes.
        size : Semantic.Sizes
        ///A button can receive focus.
        tabIndex : int
        ///A button can be formatted to toggle on and off.
        toggle : bool
        ///Custom props (TODO Check) ??
        props : IHTMLProp list } 
        
    [<RequireQualifiedAccess>]
    module Button = 
      let dft = {
                                    active = typedNull<bool> // false
                                    attached = typedNull<ButtonAttachedOptions>
                                    toggle = typedNull<bool> // false
                                    tabIndex = typedNull<int> // -1
                                    size = typedNull<Semantic.Sizes> // Medium
                                    secondary = typedNull<bool> // false
                                    role = "button"
                                    primary = typedNull<bool> // false
                                    positive = typedNull<bool> // false
                                    onClick = typedNull<(( Fable.Import.React.SyntheticEvent * obj ) -> unit)> // fun _ -> ()
                                    negative = typedNull<bool> // false
                                    loading = typedNull<bool> // false
                                    labelPosition = typedNull<ButtonLabelPostion>
                                    inverted = typedNull<bool> // false
                                    icon = typedNull<bool> // false
                                    fluid = typedNull<bool> 
                                    floated = typedNull<Semantic.Floats>
                                    ``as`` = typedNull<string>
                                    animated = typedNull<U2<bool,ButtonAnimatedOptions>>
                                    basic = typedNull<bool>
                                    circular = typedNull<bool>
                                    className  = typedNull<string>
                                    color = typedNull<ButtonCollor>
                                    compact = typedNull<bool>
                                    disabled = typedNull<bool>
                                    props = []
                                  }
      let button (props: ButtonOption )  = 
          ofImport "Button" "semantic-ui-react" (props) 
namespace Semantic.Elements.ListApi

open Semantic.Elements.ObjectApi
open Fable.Helpers.React.Props
open Fable.Import
open Fable.Helpers.React
open Fable.Core


[<RequireQualifiedAccess>]
module Button =
    type ButtonOption =
      ///A button can show it is currently the active user selection.
      | Active
      ///An element type to render as f.e. 'div', 'a', etc.
      | As of string
      ///A button can animate to show hidden content. Use this for default animation
      | IsAnimated 
      ///A button can animate to show hidden content. Choose animation
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
      | Positive 
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
    let button (props: ButtonOption list)  = 
        let parseOption r opt = 
          match opt with 
          | Active -> { r with active = true }  
          | As str -> {r with ``as`` = str}
          | IsAnimated -> {r with animated = U2.Case1 true  }
          | Animated a -> {r with animated = U2.Case2 a }
          | Attached a -> {r with attached = a }
          | Basic -> {r with basic = true}
          | Circular -> {r with circular = true}
          | Color c -> {r with color = c}
          | Compact -> {r with compact = true}
          | Disabled -> {r with disabled = true}
          | Floated f -> {r with floated = f }
          | Fluid -> {r with fluid = true }
          | Icon -> {r with icon = true}
          | Inverted -> {r with inverted = true}
          | LabelPosition lp -> { r with labelPosition = lp}
          | Loading -> {r with loading = false}
          | Negative -> { r with negative = true}
          | OnClick f -> {r with onClick = f}   
          | Positive -> {r with positive = true}
          | Primary -> { r with primary = true}
          | Role s -> { r with role = s }
          | Secondary -> {r with secondary = true}
          | Size s -> {r with size = s}
          | TabIndex i ->  { r with tabIndex = i}
          | Toggle -> {r with toggle = true}
          | Props p -> { r with props = p @ r.props}
        Button.button (List.fold parseOption Button.dft props) 

    
