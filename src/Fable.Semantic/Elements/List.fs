namespace Semantic.Elements.Api
open Fable.Core
open Fable.Import.React
open Fable.Helpers.React.Props
open Semantic

[<RequireQualifiedAccess>]
module List =
   [<StringEnum>]
   type Floated = | Left | Right
   [<StringEnum>]
   type Relaxed = | Very
   module Item =
     type Options =
     | As of string
     | Active of bool
     | ClassName of string
     | Disabled of bool
     | OnClick of (SyntheticEvent * obj -> unit)
     | Value of string
     | Props of IHTMLProp list
     with interface IHTMLProp
   module Content =
     type Options = 
     | As of string
     | ClassName of string
     | Floated of Floated
     | VerticalAlign of VerticalAlignments
     | Props of IHTMLProp list
     with interface IHTMLProp
   module Description =
     type Options =
     | As of string
     | ClassName of string
     | Props of IHTMLProp list
     with interface IHTMLProp  
   module Header = 
     type Options =
     | As of string
     | ClassName of string
     | Props of IHTMLProp list
     with interface IHTMLProp
   module Icon =
     type Options = 
     | ClassName of string
     | VerticalAlign of VerticalAlignments
     | Props of IHTMLProp list
     with interface IHTMLProp

   module SubList =
     type Options =
     | As of string
     | ClassName of string
     | Props of IHTMLProp list
     with interface IHTMLProp

   type Options =
   | Animated of bool
   | As of string
   | Bulleted of string
   | Celled of bool
   | ClassName of string
   | Content of obj ///TODO
   | Divided of bool
   | Floated of Floated 
   | Horizontal of bool
   | Inverted of bool
   | Items of Item.Options
   | Link of bool
   | OnItemClick of (SyntheticEvent * obj -> unit)
   | Ordered of bool
   | IsRelaxed of bool
   | Relaxed of Relaxed
   | Selection of bool
   | Size of Semantic.Sizes
   | VerticalAligin of Semantic.VerticalAlignments
   | Props of IHTMLProp list
   with interface IHTMLProp

   let list (props : Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "List" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
   let subList (props : Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "List.List" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
   
   let item (props : Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "List.Item" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
   
   let icon (props : Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "List.Icon" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
   let header (props : Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "List.Header" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
   
   let description (props : Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "List.Description" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  
   let content (props : Options list) = 
      let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
      Fable.Helpers.React.ofImport "List.Content" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  