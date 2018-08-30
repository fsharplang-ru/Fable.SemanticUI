namespace Semantic.Views.Api

open Fable.Helpers.React.Props
open Fable.Core
[<RequireQualifiedAccess>]
module Advertisement = 
  [<StringEnum>]
  type Units =
    | [< CompiledName "medium rectangle" >]MediumRectangle
    | [< CompiledName "large rectangle" >]LargeRectangle
    | [< CompiledName "vertical rectangle" >]VerticalRectangle
    | [< CompiledName "small rectangle" >]SmallRectangle
    | [< CompiledName "mobile banner" >]MobileBanner
    | [< CompiledName "banner" >]Banner
    | [< CompiledName "vertical banner" >]VerticalBanner
    | [< CompiledName "top banner" >]TopBanner
    | [< CompiledName "half banner" >]HalfBanner
    | [< CompiledName "button" >]Button
    | [< CompiledName "square button" >]SquareButton
    | [< CompiledName "small button" >]SmallButton
    | [< CompiledName "skyscraper" >]Skyscraper
    | [< CompiledName "wide skyscraper" >]WideSkyscraper
    | [< CompiledName "leaderboard" >]Leaderboard
    | [< CompiledName "large leaderboard" >]LargeLeaderboard
    | [< CompiledName "mobile leaderboard" >]MobileLeaderboard
    | [< CompiledName "billboard" >]Billboard
    | [< CompiledName "panorama" >]Panorama
    | [< CompiledName "netboard" >]Netboard
    | [< CompiledName "half page" >]HalfPage
    | [< CompiledName "square" >]Square
    | [< CompiledName "small square" >]SmallSquare

  type Options =
  | As of string
  | Centered of bool
  | ClassName of string
  | Test of string
  | [< CompiledName "test" >] IsTest of bool
  | Unit of Units
  | Props of IHTMLProp list
  with interface IHTMLProp

  let advertisement (props: Options list) = 
    let p = props |> List.fold ( fun s x -> match x with 
                                                | Props x -> s @ x 
                                                | a -> (a :> IHTMLProp ) :: s  ) []
    Fable.Helpers.React.ofImport "Advertisement" "semantic-ui-react" (JsInterop.keyValueList CaseRules.LowerFirst p)