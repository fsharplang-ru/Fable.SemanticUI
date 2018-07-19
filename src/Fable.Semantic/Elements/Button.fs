namespace Semantic.Elements

open Fable.Helpers.React
open Fable.Core
open Fable.Helpers.React.Props
open Semantic.Utils

  [<StringEnum>]
  type ButtonAnimatedOptions = | Fade | Vertical  
  [<StringEnum>]
  type ButtonAttachedOptions = | Left | Right | Top | Bottom
  [<StringEnum>]
  type ButtonCollor = 
    |Red |Orange |Yellow |Olive |Ggreen |Teal |Blue |Violet|Purple |Pink |Brown |Grey |Black |Facebook |[<CompiledName("google plus")>]GooglePlus |Instagram |Linkedin |Twitter |Vk |Youtube 
  [<StringEnum>]
  type ButtonLabelPostion = Left | Right
namespace Semantic.Elements.ObjectApi

open Semantic.Elements
open Fable.Helpers.React
open Fable.Core
open Semantic.Utils

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

      let contentDft : ButtonContentOptions = {
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
      let groupDft : ButonGroupOptions =  {
                                    
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
        //   Fable.Import.JS.console.trace prps
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
open Semantic.Elements
// open Semantic.Elements.ObjectApi


[<RequireQualifiedAccess>]
module Button =

    type ButtonContentOptions  =
     | As of string
      /// Additional classes
     | ClassName of string
      ///Initially hidden, visible on hover.
     | Hidden of bool
      ///Initially visible, hidden on hover.
     | Visible of bool
    
    let private parseButtonConentOptions (r : Semantic.Elements.ObjectApi.ButtonContentOptions) opts = 
       match opts with
       | As s -> { r with ``as`` = s }
       | ClassName s -> { r with className = s}
       | Hidden b -> { r with hidden = b }
       | Visible b -> { r with visible = b  }


    type  ButonGroupOptions =
          ///An element type to render as f.e. 'div', 'a', etc.
        | As of string
         ///Groups can be attached to other content.
        | Attached of ButtonAttachedOptions
        ///Groups is less pronounced.
        | Basic of bool
        //Additional classes.
        | ClassName of string
        ///Groups can have different colors
        | Color of ButtonCollor
        ///Groups can reduce its padding to fit into tighter spaces.
        | Compact of bool      
        ///Groups can be aligned to the left or right of its container.
        | Floated of Semantic.Floats  
        ///Groups can take the width of its container.
        | Fluid of bool  
        ///  ?? TODO check if this needed
        | Icon of bool           
        ///Groups can be formatted to appear on dark backgrounds.
        | Inverted of bool          
        ///Groups can hint towards a negative consequence.
        | Negative of bool
        ///Groups can hint towards a positive consequence.
        | Positive of bool   
        ///Groups can be formatted to show different levels of emphasis.
        | Primary  of bool
        ///Groups can be formatted to show different levels of emphasis.
        | Secondary of bool
        ///Groups can have different sizes.
        | Size of Semantic.Sizes
        ///Groups can be formatted to toggle on and off.
        | Toggle of bool   
        ///Groups can be formatted to appear vertically.
        | Vertical of bool     
        ///Groups can have their widths divided evenly.
        | Widths of Semantic.Widths
    let private parseButtonGroupOption (r : Semantic.Elements.ObjectApi.ButonGroupOptions) opts =
        match opts with
        | As o -> { r with ``as`` = o } 
        | Attached o -> { r with attached = o } 
        | Basic o -> { r with basic = o  } 
        | ClassName o -> { r with className = o } 
        | Color o -> { r with color = o } 
        | Compact o -> { r with compact = o }       
        | Floated o -> { r with floated = o }   
        | Fluid o -> { r with fluid = o }   
        | Icon o -> { r with icon = o }            
        | Inverted o -> { r with inverted = o }           
        | Negative o -> { r with negative = o  } 
        | Positive o -> { r with positive = o }    
        | Primary  o -> { r with primary = o } 
        | Secondary o -> { r with secondary = o } 
        | Size o -> { r with size = o } 
        | Toggle o -> { r with toggle = o }    
        | Vertical o -> { r with vertical = o }      
        | Widths o -> { r with widths = o  }  


    type ButtonOrOptions = 
      |  As of string
        /// Additional classes
      |  ClassName of string
        ///Or buttons can have their text localized, or adjusted by using the text prop.
      |  Text of string
    
    let private parseButtonOrOptions (r: Semantic.Elements.ObjectApi.ButtonOrOptions) opt  =
      match opt with 
      | As s -> { r with ``as`` = s }
      | ClassName s -> { r with className = s }
      | Text s -> { r with text = s }

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
    let private parseButtonOption r opt = 
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
        Button.button (List.fold parseButtonOption Button.buttonDft props) 
    let buttonAsDim (props : ButtonOption list) = 
        Button.buttonAsDim (List.fold parseButtonOption Button.buttonDft props)
    let buttonAsLink (props : ButtonOption list) = 
        Button.buttonAsLink (List.fold parseButtonOption Button.buttonDft props)
    let AsCustom str (props : ButtonOption list) = 
        Button.buttonAs str (List.fold parseButtonOption Button.buttonDft props)

    let Or (props: ButtonOrOptions list)  =
       Button.Or (List.fold parseButtonOrOptions Button.orDft props)
    let group (props: ButonGroupOptions list) =
       Button.group (List.fold parseButtonGroupOption Button.groupDft props)
    
    let content (props: ButtonContentOptions list) =
       Button.content (List.fold parseButtonConentOptions Button.contentDft props)
