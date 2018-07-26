namespace Semantic
open Fable.Core
// open Fable.Helpers.React
type IColor = 
  interface
  end

[<Erase>]
type CutomColr =
  | CustomColor of string
   with interface IColor

[<StringEnum>]
type Relaxed = | Very

[<StringEnum>]
type Attached = | [<CompiledName "top">] Top | [<CompiledName "bottom">] Bottom

[<StringEnum>]
type Floats = | Left | Right
[<StringEnum>]
type TextAlignments = | [<CompiledName "left">]LeftText |[<CompiledName "center">] CenterText |[<CompiledName "right">] RightText | [<CompiledName "Justified">]JustifiedText
[<StringEnum>]
type VerticalAlignments = | [<CompiledName "top">] TopAlign | [<CompiledName "middle">] MiddleAlign | [<CompiledName "bottom">] BottomAlign
[<StringEnum>]
type Sizes =   | Mini | Tiny | Small | Medium | Large | Big | Huge | Massive
[<StringEnum>]
type Widths = 
    | [<CompiledName "1">] N1
    | [<CompiledName "2">] N2
    | [<CompiledName "3">] N3
    | [<CompiledName "4">] N4
    | [<CompiledName "5">] N5
    | [<CompiledName "6">] N6
    | [<CompiledName "7">] N7
    | [<CompiledName "8">] N8
    | [<CompiledName "9">] N9
    | [<CompiledName "10">] N10
    | [<CompiledName "11">] N11
    | [<CompiledName "12">] N12
    | [<CompiledName "13">] N13
    | [<CompiledName "14">] N14
    | [<CompiledName "15">] N15
    | [<CompiledName "16">] N16
    | One
    | Two
    | Three
    | Four
    | Five
    | Six
    | Seven
    | Eight
    | Nine
    | Ten
    | Eleven
    | Twelve
    | Thirteen
    | Fourteen
    | Fifteen
    | Sixteen

[<StringEnum>]
type Color = 
      |Red |Orange |Yellow |Olive |Ggreen |Teal |Blue |Violet|Purple |Pink |Brown |Grey |Black
      with interface IColor

type Visibility = 
   | [<CompiledName "mobile">] Mobile
   | [<CompiledName "computer">] Computer
   | [<CompiledName "tablet">] Tablet
   | [<CompiledName "large screen">]LargeScreen
   | Widescreen

type Reverse =
    | [<CompiledName "computer">] Computer
    | [<CompiledName "computer vertically">] ComputerVerticaly
    | [<CompiledName "mobile">] Mobile
    | [<CompiledName "mobile vertically">] MobileVerticaly
    | [<CompiledName "tablet">] Tablet
    | [<CompiledName "tablet vertically">] TabletVerticaly