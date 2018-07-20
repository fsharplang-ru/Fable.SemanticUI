namespace Semantic.Elements.Api


open Fable.Helpers.React.Props
open Fable.Import
open Fable.Helpers.React
open Fable.Core

[<RequireQualifiedAccess>]
module Button =
    [<StringEnum>]
    type Animate = | Fade | Vertical  
    [<StringEnum>]
    type Attached = | Left | Right | Top | Bottom
    [<StringEnum>]
    type Color = |Facebook |[<CompiledName("google plus")>]GooglePlus |Instagram |Linkedin |Twitter |Vk |Youtube 
         with interface  Semantic.ICollor
    [<StringEnum>]
    type LabelPostion = Left | Right

    module Content = 
        type Option  =
         | As of string
          /// Additional classes
         | ClassName of string
          ///Initially hidden, visible on hover.
         | Hidden of bool
          ///Initially visible, hidden on hover.
         | Visible of bool
                ///Other React props
          | Props of IHTMLProp list
          with interface IHTMLProp
    
    module Group =

        type  Option =
              ///An element type to render as f.e. 'div', 'a', etc.
            | As of string
             ///Groups can be attached to other content.
            | Attached of Attached
            ///Groups is less pronounced.
            | Basic of bool
            //Additional classes.
            | ClassName of string
            ///Groups can have different colors
            | Color of Semantic.Collor
            ///Groups can reduce its padding to fit into tighter spaces.
            | Compact of bool      
            ///Groups can be aligned to the left or right of its container.
            | Floated of Semantic.Floats  
            ///Groups can take the width of its container.
            | Fluid of bool  
            ///  ?? TODO check if this needed
            | [<CompiledName "icon">] IsIcon of bool           
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
                   ///Other React props
              | Props of IHTMLProp list
              with interface IHTMLProp
    module Or = 

        type Options = 
          |  As of string
            /// Additional classes
          |  ClassName of string
            ///Or buttons can have their text localized, or adjusted by using the text prop.
          |  Text of string
                 ///Other React props
          | Props of IHTMLProp list
          with interface IHTMLProp
    
    type Options =
      ///A button can show it is currently the active user selection.
      | Active of bool
      ///An element type to render as f.e. 'div', 'a', etc.
      | As  of string
      ///A button can animate to show hidden content. Use this for default animation
      | [<CompiledName "animated">]IsAnimated of bool
      ///A button can animate to show hidden content. Choose animation
      | Animated of Animate 
      ///A button can be attached to other content.
      | Attached of Attached
      ///A basic button is less pronounced.
      | Basic of bool
      | [<CompiledNameAttribute "content">]Text of string
      ///A button can be circular.
      | Circular of bool
      | ClassName of string
      ///A button can have different colors
      | Color of Semantic.ICollor
      ///A button can reduce its padding to fit into tighter spaces.
      | Compact of bool
      ///A button can show it is currently unable to be interacted with.
      | Disabled of bool
      ///A button can be aligned to the left or right of its container.
      | Floated  of Semantic.Floats
      ///	A button can take the width of its container.
      | Fluid of bool 
      ///  ?? TODO check is this need
      | [<CompiledNameAttribute "icon">]IsIcon of bool
      | Icon of Semantic.Elements.Icons.IIcon
      ///A button can be formatted to appear on dark backgrounds.
      | Inverted of bool
      /// A labeled button can format a Label or Icon to appear on the left or right.
      | LabelPosition of LabelPostion
      /// A button can show a loading indicator.
      | Loading of bool 
      ///A button can hint towards a negative consequence.
      | Negative of bool
      ///Called after user's click. 
      /// OnClick ( fun (event, data) -> .. ) 
      /// event - React's original SyntheticEvent.
      /// data - All props.
      | OnClick of  (( React.SyntheticEvent * obj) -> unit)
      ///A button can hint towards a positive consequence.
      | Positive of bool 
      //A button can be formatted to show different levels of emphasis.
      | Primary of bool 
      ///The role of the HTML element. default : 'button'
      | Role of string
      ///A button can be formatted to show different levels of emphasis.
      | Secondary of bool 
      ///A button can have different sizes.
      | Size of Semantic.Sizes
      ///A button can receive focus.
      | TabIndex of int
      ///A button can be formatted to toggle on and off.
      | Toggle of bool
       ///Other React props
      | Props of IHTMLProp list
      with interface IHTMLProp

    type internal IsAnim = | Animated of bool with interface IHTMLProp
    type internal Anim = | Animated of Animate with interface IHTMLProp
    let button (props: Options list)  = 
        // Button.button (List.fold parseButtonOption Button.buttonDft props) 
        let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
        ofImport "Button" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)

    let or' (props: Or.Options list)  =
       let p = props |> List.fold ( fun s x -> match x with 
                                                | Or.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
       ofImport "Button.Or" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p) []
    //    Button. (List.fold parseButtonOrOptions Button.orDft props)
    let group (props: Group.Option list) =
       let p = props |> List.fold ( fun s x -> match x with 
                                                | Group.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
       ofImport "Button.Group" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)
    
    let content (props: Content.Option list) =
       let p = props |> List.fold ( fun s x -> match x with 
                                                | Content.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
       ofImport "Button.Content" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)
