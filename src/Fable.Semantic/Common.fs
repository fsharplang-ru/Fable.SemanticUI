namespace Semantic
open Fable.Core
// open Fable.Helpers.React
type ICollor = 
  interface
  end

[<StringEnum>]
type Floats = | Left | Right
[<StringEnum>]
type TextAlignments = | Left | Center | Right | Justified
[<StringEnum>]
type VerticalAlignments = | Top | Middle | Bottom
[<StringEnum>]
type Sizes =   | Mini | Tiny | Small | Medium | Large | Big | Huge | Massive
type Widths = | One | Two | Three | Four | Five | Six | Seven | Eight | Nine | Ten | Eleven | Twelve | Therteen | Fourteen | Fifteen | Sixteen
type Collor = 
      |Red |Orange |Yellow |Olive |Ggreen |Teal |Blue |Violet|Purple |Pink |Brown |Grey |Black
      with interface ICollor
