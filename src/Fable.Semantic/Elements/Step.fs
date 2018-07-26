namespace rec Semantic.Elements.Api
open Fable.Core
open Fable.Import.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable
open System.Text.RegularExpressions
[<RequireQualifiedAccess>]
module Step =
    [<StringEnum>]
    type Attached = | Top | Bottom
    [<StringEnum>]
    type Stackable = Tablet

    type Options = 
    | Active of bool
    | As of string
    | ClassName of string
    | Completed of bool
    | [<CompiledName "content">] ContentEl of ReactElement
    // | Description of Description.Options list
    | Dsiabled of bool
    | Href of string
    | Icon of Semantic.Elements.Icons.IIcon
    | Link of bool
    | OnClick of (SyntheticEvent * obj -> unit)
    | Ordered of bool
    // | Title of Title.Options list
    | Props of IHTMLProp list
    with interface IHTMLProp

    type internal TitlePlaceholder =
    | Title of obj
    with interface IHTMLProp
    type internal DescriptionPlaceholder =
    | Description of obj
    with interface IHTMLProp
    let step (props: Options list) =
      let p = props |> List.fold ( fun s x -> match x with 
                                                  | Props x -> s @ x 
                                                  // | Options.Description x ->((let q = JsInterop.keyValueList CaseRules.LowerFirst x
                                                  //                             DescriptionPlaceholder.Description q) :> IHTMLProp) :: s
                                                  // | Options.Title x ->((let q = JsInterop.keyValueList CaseRules.LowerFirst x
                                                  //                       TitlePlaceholder.Title q) :> IHTMLProp) :: s
                                                  | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "Step" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
   
    module Content =
      type Options =
      | As of string
      | ClassName of string
      | [<CompiledName "content">] ContentEl of ReactElement
      | Description of Description.Options list
      | Props of IHTMLProp list
      with interface IHTMLProp
    
    let content (props: Content.Options list) =
          let p = props |> List.fold ( fun s x -> match x with 
                                                  | Content.Props x -> s @ x 
                                                  | a -> (a :> IHTMLProp ) :: s  ) []
          Fable.Helpers.React.ofImport "Step.Content" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
    
    module Description =
      type Options =
      | As of string
      | ClassName of string
      | [<CompiledName "content">] ContentEl of ReactElement
      | Props of IHTMLProp list
      with interface IHTMLProp
    
    let description (props: Description.Options list) =
          let p = props |> List.fold ( fun s x -> match x with 
                                                  | Description.Props x -> s @ x 
                                                  | a -> (a :> IHTMLProp ) :: s  ) []
          Fable.Helpers.React.ofImport "Step.Description" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
    
    module Group =

      type Options =
      | As of string
      | Attached of Attached
      | ClassName of string
      | [<CompiledName "content">] ContentEl of ReactElement
      | Fluid of bool
      // | Items of list<list<Step.Options>>
      | Ordered of bool
      | Size of Semantic.Sizes
      | Stackable of Stackable
      | Unstackable of bool
      | Vertical of bool
      | Width of Semantic.Widths
      | Props of IHTMLProp list
      with interface IHTMLProp

      type internal ItemsPlaceholder<'a> =
      | Items of 'a list
      with interface IHTMLProp
    let group (props : Group.Options list) =
          let zipList (l: Step.Options list list)  =
              [ for x in l do
                    yield JsInterop.keyValueList CaseRules.LowerFirst x ]
          let p = props |> List.fold ( fun s x -> match x with 
                                                  | Group.Props x -> s @ x 
                                                  // | Group.Items x -> ( Step.Group.ItemsPlaceholder.Items (zipList x) :> IHTMLProp ) :: s
                                                  | a -> (a :> IHTMLProp ) :: s  ) []


          Fable.Helpers.React.ofImport "Step.Group" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
    
    module Title =
      type Options =
      | As of string
      | ClassName of string
      | [<CompiledName "content">] ContentEl of ReactElement
      | Props of IHTMLProp list
      with interface IHTMLProp

    let title (props: Title.Options list) =
          let p = props |> List.fold ( fun s x -> match x with 
                                                  | Title.Props x -> s @ x 
                                                  | a -> (a :> IHTMLProp ) :: s  ) []
          Fable.Helpers.React.ofImport "Step.Title" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  