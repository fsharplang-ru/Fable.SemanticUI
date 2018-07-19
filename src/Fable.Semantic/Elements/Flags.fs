namespace Semantic.Elements.Flags


open Fable.Core

[<StringEnum>]
type Flag =
    | Ad
    | Andorra
    | Ae
    | [<CompiledName("united arab emirates")>]UnitedArabEmirates
    | Uae
    | Af
    | Afghanistan
    | Ag
    | Antigua
    | Ai
    | Anguilla
    | Al
    | Albania
    | Am
    | Armenia
    | An
    |  [<CompiledName("netherlands antilles")>]NetherlandsAntilles
    | Ao
    | Angola
    | Ar
    | Argentina
    | As
    | [<CompiledName("american samoa")>]AmericanSamoa
    | At
    | Austria
    | Au
    | Australia
    | Aw
    | Aruba
    | Ax
    | [<CompiledName("aland islands")>]AlandIslands
    | Az
    | Azerbaijan
    | Ba
    | Bosnia
    | Bb
    | Barbados
    | Bd
    | Bangladesh
    | Be
    | Belgium
    | Bf
    | [<CompiledName("burkina faso")>]BurkinaFaso
    | Bg
    | Bulgaria
    | Bh
    | Bahrain
    | Bi
    | Burundi
    | Bj
    | Benin
    | Bm
    | Bermuda
    | Bn
    | Brunei
    | Bo
    | Bolivia
    | Br
    | Brazil
    | Bs
    | Bahamas
    | Bt
    | Bhutan
    | Bv
    | [<CompiledName("bouvet island")>]BouvetIsland
    | Bw
    | Botswana
    | By
    | Belarus
    | Bz
    | Belize
    | Ca
    | Canada
    | Cc
    | [<CompiledName("cocos islands")>]CocosIslands
    | Cd
    | Congo
    | Cf
    | [<CompiledName("central african republic")>]CentralAfricanRepublic
    | Cg
    | [<CompiledName("сongo brazzaville")>]CongoBrazzaville
    | Ch
    | Switzerland
    | Ci
    | [<CompiledName("сote divoire")>]CoteВivoire
    | Ck
    | [<CompiledName("cook islands")>]CookIslands
    | Cl
    | Chile
    | Cm
    | Cameroon
    | Cn
    | China
    | Co
    | Colombia
    | Cr
    | [<CompiledName("costa rica")>]CostaRica
    | Cs
    | Cu
    | Cuba
    | Cv
    | [<CompiledName("cape verde")>]CapeVerde
    | Cx
    | [<CompiledName("christmas island")>]ChristmasIsland
    | Cy
    | Cyprus
    | Cz
    | [<CompiledName("czech republic")>]CzechRepublic
    | De
    | Germany
    | Dj
    | Djibouti
    | Dk
    | Denmark
    | Dm
    | Dominica
    | Do
    | [<CompiledName("dominican republic")>]DominicanRepublic
    | Dz
    | Algeria
    | Ec
    | Ecuador
    | Ee
    | Estonia
    | Eg
    | Egypt
    | Eh
    | [<CompiledName("western sahara")>]WesternSahara
    | Er
    | Eritrea
    | Es
    | Spain
    | Et
    | Ethiopia
    | Eu
    | [<CompiledName("european union")>]EuropeanUnion
    | Fi
    | Finland
    | Fj
    | Fiji
    | Fk
    | [<CompiledName("falkland islands")>]FalklandIslands
    | Fm
    | Micronesia
    | Fo
    | [<CompiledName("faroe islands")>]FaroeIslands
    | Fr
    | France
    | Ga
    | Gabon
    | Gb
    | [<CompiledName("united kingdom")>]UnitedKingdom
    | Gd
    | Grenada
    | Ge
    | Georgia
    | Gf
    | [<CompiledName("french guiana")>]FrenchGuiana
    | Gh
    | Ghana
    | Gi
    | Gibraltar
    | Gl
    | Greenland
    | Gm
    | Gambia
    | Gn
    | Guinea
    | Gp
    | Guadeloupe
    | Gq
    | [<CompiledName("equatorial guinea")>]EquatorialGuinea
    | Gr
    | Greece
    | Gs
    | [<CompiledName("sandwich islands")>]SandwichIslands
    | Gt
    | Guatemala
    | Gu
    | Guam
    | Gw
    | [<CompiledName "guinea-bissau">] GuineaBissau
    | Gy
    | Guyana
    | Hk
    | [<CompiledName "hong kong">]HongKong
    | Hm
    | [<CompiledName "Heard island">]HeardIsland
    | Hn
    | Honduras
    | Hr
    | Croatia
    | Ht
    | Haiti
    | Hu
    | Hungary
    | Id
    | Indonesia
    | Ie
    | Ireland
    | Il
    | Israel
    | In
    | India
    | Io
    | [<CompiledName "indian ocean territory">]IndianOceanTerritory
    | Iq
    | Iraq
    | Ir
    | Iran
    | Is
    | Iceland
    | It
    | Italy
    | Jm
    | Jamaica
    | Jo
    | Jordan
    | Jp
    | Japan
    | Ke
    | Kenya
    | Kg
    | Kyrgyzstan
    | Kh
    | Cambodia
    | Ki
    | Kiribati
    | Km
    | Comoros
    | Kn
    | [<CompiledName "saint kitts and nevis">]SaintKittsAndNevis
    | Kp
    | [<CompiledName "north korea">]NorthKorea
    | Kr
    | [<CompiledName "south korea">]SouthKorea
    | Kw
    | Kuwait
    | Ky
    | [<CompiledName "cayman islands">]CaymanIslands
    | Kz
    | Kazakhstan
    | La
    | Laos
    | Lb
    | Lebanon
    | Lc
    | [<CompiledName "saint lucia">]SaintLucia
    | Li
    | Liechtenstein
    | Lk
    | [<CompiledName "sri lanka">]SriLanka
    | Lr
    | Liberia
    | Ls
    | Lesotho
    | Lt
    | Lithuania
    | Lu
    | Luxembourg
    | Lv
    | Latvia
    | Ly
    | Libya
    | Ma
    | Morocco
    | Mc
    | Monaco
    | Md
    | Moldova
    | Me
    | Montenegro
    | Mg
    | Madagascar
    | Mh
    | [<CompiledName "Marshall islands">]MarshallIslands
    | Mk
    | Macedonia
    | Ml
    | Mali
    | Mm
    | Myanmar
    | Burma
    | Mn
    | Mongolia
    | Mo
    | Macau
    | Mp
    | [<CompiledName "northern mariana islands">]NorthernMarianaIslands
    | Mq
    | Martinique
    | Mr
    | Mauritania
    | Ms
    | Montserrat
    | Mt
    | Malta
    | Mu
    | Mauritius
    | Mv
    | Maldives
    | Mw
    | Malawi
    | Mx
    | Mexico
    | My
    | Malaysia
    | Mz
    | Mozambique
    | Na
    | Namibia
    | Nc
    | [<CompiledName "new caledonia">]NewCaledonia
    | Ne
    | Niger
    | Nf
    | [<CompiledName "norfolk island">]NorfolkIsland
    | Ng
    | Nigeria
    | Ni
    | Nicaragua
    | Nl
    | Netherlands
    | No
    | Norway
    | Np
    | Nepal
    | Nr
    | Nauru
    | Nu
    | Niue
    | Nz
    | [<CompiledName "new zealand">]NewZealand
    | Om
    | Oman
    | Pa
    | Panama
    | Pe
    | Peru
    | Pf
    | [<CompiledName "french polynesia">]FrenchPolynesia
    | Pg
    | [<CompiledName "new guinea">]NewGuinea
    | Ph
    | Philippines
    | Pk
    | Pakistan
    | Pl
    | Poland
    | Pm
    | [<CompiledName "saint pierre">]SaintPierre
    | Pn
    | [<CompiledName "pitcairn islands">]PitcairnIslands
    | Pr
    | [<CompiledName "puerto rico">]PuertoRico
    | Ps
    | Palestine
    | Pt
    | Portugal
    | Pw
    | Palau
    | Py
    | Paraguay
    | Qa
    | Qatar
    | Re
    | Reunion
    | Ro
    | Romania
    | Rs
    | Serbia
    | Ru
    | Russia
    | Rw
    | Rwanda
    | Sa
    | [<CompiledName "saudi arabia">]SaudiArabia
    | Sb
    | [<CompiledName "solomon islands">]SolomonIslands
    | Sc
    | Seychelles
    | [<CompiledName "gb sct">]GbSct
    | Scotland
    | Sd
    | Sudan
    | Se
    | Sweden
    | Sg
    | Singapore
    | Sh
    | [<CompiledName "saint helena">]SaintHelena
    | Si
    | Slovenia
    | Sj
    | Svalbard
    | [<CompiledName "jan mayen">]JanMayen
    | Sk
    | Slovakia
    | Sl
    | [<CompiledName "sierra leone">]SierraLeone
    | Sm
    | [<CompiledName "san marino">]SanMarino
    | Sn
    | Senegal
    | So
    | Somalia
    | Sr
    | Suriname
    | St
    | [<CompiledName "sao tome">]SaoTome
    | Sv
    | [<CompiledName "el salvador">]ElSalvador
    | Sy
    | Syria
    | Sz
    | Swaziland
    | Tc
    | [<CompiledName "caicos islands">]CaicosIslands
    | Td
    | Chad
    | Tf
    | [<CompiledName "French territories">]FrenchTerritories
    | Tg
    | Togo
    | Th
    | Thailand
    | Tj
    | Tajikistan
    | Tk
    | Tokelau
    | Tl
    | Timorleste
    | Tm
    | Turkmenistan
    | Tn
    | Tunisia
    | To
    | Tonga
    | Tr
    | Turkey
    | Tt
    | Trinidad
    | Tv
    | Tuvalu
    | Tw
    | Taiwan
    | Tz
    | Tanzania
    | Ua
    | Ukraine
    | Ug
    | Uganda
    | Um
    | [<CompiledName "us minor islands">]UsMinorIslands
    | Us
    | America
    | [<CompiledName "united states">]UnitedStates
    | Uy
    | Uruguay
    | Uz
    | Uzbekistan
    | Va
    | [<CompiledName "vatican city">]VaticanCity
    | Vc
    | [<CompiledName "saint vincent">]SaintVincent
    | Ve
    | Venezuela
    | Vg
    | [<CompiledName "british virgin islands">]BritishVirginIslands
    | Vi
    | [<CompiledName "us virgin islands">]UsVirginIslands
    | Vn
    | Vietnam
    | Vu
    | Vanuatu
    | [<CompiledName "gb wls">]GbWls
    | Wales
    | Wf
    | [<CompiledName "wallis and futuna">]WallisAndFutuna
    | Ws
    | Samoa
    | Ye
    | Yemen
    | Yt
    | Mayotte
    | Za
    | [<CompiledName "south africa">]SouthAfrica
    | Zm
    | Zambia
    | Zw
    | Zimbabwe

namespace Semantic.Elements.ObjectApi
type FlagOptions = {
      ///An element type to render as. Defaull "<i>"
      ``as`` : string
      className : string
      name : Semantic.Elements.Flags.Flag
  }
open Fable.Helpers
[<RequireQualifiedAccess>]
module Flag =
  
  let dft = {
      name = Semantic.Utils.typedNull<Semantic.Elements.Flags.Flag>
      ``as`` = Semantic.Utils.typedNull<string>
      className = Semantic.Utils.typedNull<string>
  }

  let flag (props: FlagOptions) =
     React.ofImport "Flag" "semantic-ui-react" (Fable.Core.JsInterop.toPlainJsObj props) []

namespace Semantic.Elements.ListApi
open Fable.Core

[<RequireQualifiedAccess>]
module Flag =
  type FlagOptions = 
  | As of string
  | ClassName of string
  | Name of Semantic.Elements.Flags.Flag
  
  let private parseFlagOption (r:Semantic.Elements.ObjectApi.FlagOptions) opt =
    match opt with
    | As s -> { r with ``as`` = s }
    | ClassName s -> { r with className = s}
    | Name n -> {r with name = n }

  let flag (props : FlagOptions list ) =
    Semantic.Elements.ObjectApi.Flag.flag (List.fold parseFlagOption Semantic.Elements.ObjectApi.Flag.dft props) 