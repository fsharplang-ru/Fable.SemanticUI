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
type Floats = | Left | Right
[<StringEnum>]
type TextAlignments = | Left | Center | Right | Justified
[<StringEnum>]
type VerticalAlignments = | Top | Middle | Bottom
[<StringEnum>]
type Sizes =   | Mini | Tiny | Small | Medium | Large | Big | Huge | Massive
type Widths = | One | Two | Three | Four | Five | Six | Seven | Eight | Nine | Ten | Eleven | Twelve | Therteen | Fourteen | Fifteen | Sixteen
[<StringEnum>]
type Color = 
      |Red |Orange |Yellow |Olive |Ggreen |Teal |Blue |Violet|Purple |Pink |Brown |Grey |Black
      with interface IColor
