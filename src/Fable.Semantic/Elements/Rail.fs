namespace Semantic.Elements.Api
open Fable.Core
open Fable.Helpers.React.Props


[<RequireQualifiedAccess>]
module Rail = 
  [<StringEnum>]
  type Close = | Very

  type Options =
   | As of string
   | Attached of bool
   | ClassName of string
   | Close of Close
   | [<CompiledName "close">]IsClose of bool
   | Dividing of bool
   | Internal of bool
   | Position of Semantic.Floats
   | Size of Semantic.Sizes
   | Props of IHTMLProp list
   with interface IHTMLProp

  let rail (props : Options list) =
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Rail" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)  