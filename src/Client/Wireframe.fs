module Wireframe 

open Fable.Core
open Semantic.Elements.Api
open Fable.Helpers.React

let wireframe () = 
   div [] [
       Segment.segment [] [
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/centered-paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/short-paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/media-paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/centered-paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/centered-paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/short-paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/media-paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/centered-paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/centered-paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/short-paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/media-paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/paragraph.png" ]
           Image.image [ Image.Src "https://react.semantic-ui.com/images/wireframe/centered-paragraph.png" ]
       ]
   ]