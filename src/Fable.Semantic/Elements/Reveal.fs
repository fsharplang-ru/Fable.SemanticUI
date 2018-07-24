namespace Semantic.Elements.Api
open Fable.Core
open System.Runtime.CompilerServices
open Fable.Helpers.React.Props
[<RequireQualifiedAccess>]
module Reveal = 
   [<StringEnum>]
   type Animated =  
   | Fade 
   | [<CompiledName "small fade">] SmallFade 
   | Move 
   | [<CompiledName "move right">] MoveRight 
   | [<CompiledName "move up">] MoveUp 
   | [<CompiledName "move down">] MoveDown 
   | Rotate 
   | [<CompiledName "rotate left">] RotateLeft

   type Options =
   | Active of bool
   | Animated of Animated
   | As of string
   | ClassName of string
   | Disabled of bool
   | Instant of bool
   | Props of IHTMLProp list
   with interface IHTMLProp

   let reveal (props: Options list) =
         let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
         Fable.Helpers.React.ofImport "Reveal" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  

   module Content = 
     type Options =
     | As of string
     | ClassName of string
     | Hidden of bool
     | Visible of bool
     | Props of IHTMLProp list
     with interface IHTMLProp 
   let content (props : Content.Options  list) = 
         let p = props |> List.fold ( fun s x -> match x with 
                                                | Content.Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
         Fable.Helpers.React.ofImport "Reveal.Content" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  