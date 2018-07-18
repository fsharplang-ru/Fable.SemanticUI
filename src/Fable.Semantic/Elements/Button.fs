
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
        onClick :  (( Fable.Import.React.SyntheticEvent * ButtonOption ) -> unit)
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
        (*props : IHTMLProp*) } 
    type [<Pojo>] ButtonContentOptions = {
      ``as`` : string
      /// Additional classes
      className : string
      ///Initially hidden, visible on hover.
      hidden : bool
      ///Initially visible, hidden on hover.
      visible : bool
    }
    type [<Pojo>] ButtonOrOptions = {
        ``as`` : string
        /// Additional classes
        className : string
        ///Or buttons can have their text localized, or adjusted by using the text prop.
        text : string
    }
    type [<Pojo>] ButonGroupOptions = {
          ///An element type to render as f.e. 'div', 'a', etc.
        ``as`` : string
         ///A button can be attached to other content.
        attached : ButtonAttachedOptions
        ///A basic button is less pronounced.
        basic : bool
        //Additional classes.
        className : string
        ///A button can have different colors
        color : ButtonCollor
        ///A button can reduce its padding to fit into tighter spaces.
        compact : bool      
        ///A button can be aligned to the left or right of its container.
        floated : Semantic.Floats  
        ///A button can take the width of its container.
        fluid : bool  
        ///  ?? TODO check if this needed
        icon : bool           
        ///A button can be formatted to appear on dark backgrounds.
        inverted : bool          
        ///A button can hint towards a negative consequence.
        negative : bool
        ///A button can hint towards a positive consequence.
        positive : bool   
        //A button can be formatted to show different levels of emphasis.
        primary  : bool
        ///A button can be formatted to show different levels of emphasis.
        secondary : bool
        ///A button can have different sizes.
        size : Semantic.Sizes
        ///A button can be formatted to toggle on and off.
        toggle : bool   
        ///Groups can be formatted to appear vertically.
        vertical : bool         
        widths : Semantic.Widths
    }
    [<RequireQualifiedAccess>]
    module Button = 
      let buttonDft = {
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
                                    // props = []
                                  }

      let contentDft :ButtonContentOptions = {
          ``as`` =  typedNull<string>
          className  =  typedNull<string>
          hidden  =  typedNull<bool>
          visible  =  typedNull<bool>
      }
      let orDft : ButtonOrOptions = {
          ``as`` = typedNull<string>
          text = typedNull<string>
          className = typedNull<string>
      }
      let groupDft :ButonGroupOptions =  {
                                    
                                    attached = typedNull<ButtonAttachedOptions>
                                    toggle = typedNull<bool> // false
                                    size = typedNull<Semantic.Sizes> // Medium
                                    secondary = typedNull<bool> // false
                                    primary = typedNull<bool> // false
                                    positive = typedNull<bool> // false
                                    negative = typedNull<bool> // false
                                    inverted = typedNull<bool> // false
                                    icon = typedNull<bool> // false
                                    fluid = typedNull<bool> 
                                    floated = typedNull<Semantic.Floats>
                                    ``as`` = typedNull<string>
                                    basic = typedNull<bool>
                                    className  = typedNull<string>
                                    color = typedNull<ButtonCollor>
                                    compact = typedNull<bool>
                                    vertical =  typedNull<bool>
                                    widths =  typedNull<Semantic.Widths>
      }
      let button (prps: ButtonOption )  = 
          ofImport "Button" "semantic-ui-react" prps 
      let buttonAsDim (props : ButtonOption) = 
          button { props with ``as`` = "dim" }
      let buttonAsLink (props : ButtonOption) = 
          button { props with ``as`` = "a" } 
      let buttonAs str (props : ButtonOption) =
          button { props with ``as`` = str } 
      let content (props : ButtonContentOptions) = 
          ofImport "Button.Content" "semantic-ui-react" props 
      let Or (props : ButtonOrOptions) = 
          ofImport "Button.Or" "semantic-ui-react" props []
      let group (props : ButonGroupOptions) =
          ofImport "Button.Group" "semantic-ui-react" props 
      
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
      | IsActive of bool
      ///An element type to render as f.e. 'div', 'a', etc.
      | As  of string
      ///A button can animate to show hidden content. Use this for default animation
      | IsAnimated of bool
      ///A button can animate to show hidden content. Choose animation
      | Animated of ButtonAnimatedOptions 
      ///A button can be attached to other content.
      | Attached of ButtonAttachedOptions
      ///A basic button is less pronounced.
      | IsBasic of bool
      ///A button can be circular.
      | IsCircular of bool
      ///A button can have different colors
      | Color of ButtonCollor
      ///A button can reduce its padding to fit into tighter spaces.
      | IsCompact of bool
      ///A button can show it is currently unable to be interacted with.
      | IsDisabled of bool
      ///A button can be aligned to the left or right of its container.
      | Floated  of Semantic.Floats
      ///	A button can take the width of its container.
      | IsFluid of bool 
      ///  ?? TODO check is this need
      | Icon of bool
      ///A button can be formatted to appear on dark backgrounds.
      | IsInverted of bool
      /// A labeled button can format a Label or Icon to appear on the left or right.
      | LabelPosition of ButtonLabelPostion
      /// A button can show a loading indicator.
      | IsLoading of bool 
      ///A button can hint towards a negative consequence.
      | IsNegative of bool
      ///Called after user's click. 
      /// OnClick ( fun (event, data) -> .. ) 
      /// event - React's original SyntheticEvent.
      /// data - All props.
      | OnClick of  (( React.SyntheticEvent * Semantic.Elements.ObjectApi.ButtonOption ) -> unit)
      ///A button can hint towards a positive consequence.
      | IsPositive of bool 
      //A button can be formatted to show different levels of emphasis.
      | IsPrimary of bool 
      ///The role of the HTML element. default : 'button'
      | Role of string
      ///A button can be formatted to show different levels of emphasis.
      | IsSecondary of bool 
      ///A button can have different sizes.
      | Size of Semantic.Sizes
      ///A button can receive focus.
      | TabIndex of int
      ///A button can be formatted to toggle on and off.
      | IsToggle of bool
      ///Custom props
      // | Props of IHTMLProp list
    let private parseOption r opt = 
          match opt with 
          | IsActive b -> { r with active = b  }  
          | As str -> {r with ``as`` = str}
          | IsAnimated b -> {r with animated = U2.Case1 b   }
          | Animated a -> {r with animated = U2.Case2 a }
          | Attached a -> {r with attached = a }
          | IsBasic b -> {r with basic = b }
          | IsCircular b -> {r with circular = b }
          | Color c -> {r with color = c}
          | IsCompact b -> {r with compact = true}
          | IsDisabled b -> {r with disabled = b }
          | Floated f -> {r with floated = f }
          | IsFluid b -> {r with fluid = b  }
          | Icon b -> {r with icon = b }
          | IsInverted b -> {r with inverted = b }
          | LabelPosition lp -> { r with labelPosition = lp}
          | IsLoading b -> {r with loading = b }
          | IsNegative b -> { r with negative = b }
          | OnClick f -> {r with onClick = f}   
          | IsPositive b -> {r with positive = b }
          | IsPrimary b -> { r with primary = b }
          | Role s -> { r with role = s }
          | IsSecondary b -> {r with secondary = b }
          | Size s -> {r with size = s}
          | TabIndex i ->  { r with tabIndex = i}
          | IsToggle b -> {r with toggle = b }
          // | Props p -> { r with props =  r.props. }
    let button (props: ButtonOption list)  = 
        Button.button (List.fold parseOption Button.buttonDft props) 
    let buttonAsDim (props : ButtonOption list) = 
        Button.buttonAsDim (List.fold parseOption Button.buttonDft props)
    let buttonAsLink (props : ButtonOption list) = 
        Button.buttonAsLink (List.fold parseOption Button.buttonDft props)
    let AsCustom str (props : ButtonOption list) = 
        Button.buttonAs str (List.fold parseOption Button.buttonDft props)

    
