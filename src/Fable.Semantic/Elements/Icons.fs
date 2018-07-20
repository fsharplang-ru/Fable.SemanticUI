namespace Semantic.Elements.Icons
open Fable.Core

type IIcon =
   interface end

[<StringEnum>]
type Icon =
    | [<CompiledName "braille">]Braille
    | [<CompiledName "deaf">]Deaf
    | [<CompiledName "sign language">]SignLanguage
    | [<CompiledName "universal access">]UniversalAccess
    | [<CompiledName "angle double down">]AngleDoubleDown
    | [<CompiledName "angle double left">]AngleDoubleLeft
    | [<CompiledName "angle double right">]AngleDoubleRight
    | [<CompiledName "angle double up">]AngleDoubleUp
    | [<CompiledName "angle down">]AngleDown
    | [<CompiledName "angle left">]AngleLeft
    | [<CompiledName "angle right">]AngleRight
    | [<CompiledName "angle up">]AngleUp
    | [<CompiledName "arrow alternate circle down">]ArrowAlternateCircleDown
    | [<CompiledName "arrow alternate circle down outline">]ArrowAlternateCircleDownOutline
    | [<CompiledName "arrow alternate circle left">]ArrowAlternateCircleLeft
    | [<CompiledName "arrow alternate circle left outline">]ArrowAlternateCircleLeftOutline
    | [<CompiledName "arrow alternate circle right">]ArrowAlternateCircleRight
    | [<CompiledName "arrow alternate circle right outline">]ArrowAlternateCircleRightOutline
    | [<CompiledName "arrow alternate circle up">]ArrowAlternateCircleUp
    | [<CompiledName "arrow alternate circle up outline">]ArrowAlternateCircleUpOutline
    | [<CompiledName "arrow circle down">]ArrowCircleDown
    | [<CompiledName "arrow circle left">]ArrowCircleLeft
    | [<CompiledName "arrow circle right">]ArrowCircleRight
    | [<CompiledName "arrow circle up">]ArrowCircleUp
    | [<CompiledName "arrow down">]ArrowDown
    | [<CompiledName "arrow left">]ArrowLeft
    | [<CompiledName "arrow right">]ArrowRight
    | [<CompiledName "arrow up">]ArrowUp
    | [<CompiledName "arrows alternate">]ArrowsAlternate
    | [<CompiledName "arrows alternate horizontal">]ArrowsAlternateHorizontal
    | [<CompiledName "arrows alternate vertical">]ArrowsAlternateVertical
    | [<CompiledName "caret down">]CaretDown
    | [<CompiledName "caret left">]CaretLeft
    | [<CompiledName "caret right">]CaretRight
    | [<CompiledName "caret square down">]CaretSquareDown
    | [<CompiledName "caret square down outline">]CaretSquareDownOutline
    | [<CompiledName "caret square left">]CaretSquareLeft
    | [<CompiledName "caret square left outline">]CaretSquareLeftOutline
    | [<CompiledName "caret square right">]CaretSquareRight
    | [<CompiledName "caret square right outline">]CaretSquareRightOutline
    | [<CompiledName "caret square up">]CaretSquareUp
    | [<CompiledName "caret square up outline">]CaretSquareUpOutline
    | [<CompiledName "caret up">]CaretUp
    | [<CompiledName "chevron circle down">]ChevronCircleDown
    | [<CompiledName "chevron circle left">]ChevronCircleLeft
    | [<CompiledName "chevron circle right">]ChevronCircleRight
    | [<CompiledName "chevron circle up">]ChevronCircleUp
    | [<CompiledName "chevron down">]ChevronDown
    | [<CompiledName "chevron left">]ChevronLeft
    | [<CompiledName "chevron right">]ChevronRight
    | [<CompiledName "chevron up">]ChevronUp
    | [<CompiledName "level down alternate">]LevelDownAlternate
    | [<CompiledName "level up alternate">]LevelUpAlternate
    | [<CompiledName "long arrow alternate down">]LongArrowAlternateDown
    | [<CompiledName "long arrow alternate left">]LongArrowAlternateLeft
    | [<CompiledName "long arrow alternate right">]LongArrowAlternateRight
    | [<CompiledName "long arrow alternate up">]LongArrowAlternateUp
    | [<CompiledName "mouse pointer">]MousePointer
    | [<CompiledName "retweet">]Retweet
    | [<CompiledName "audio description">]AudioDescription
    | [<CompiledName "backward">]Backward
    | [<CompiledName "closed captioning">]ClosedCaptioning
    | [<CompiledName "closed captioning outline">]ClosedCaptioningOutline
    | [<CompiledName "eject">]Eject
    | [<CompiledName "expand arrows alternate">]ExpandArrowsAlternate
    | [<CompiledName "fast backward">]FastBackward
    | [<CompiledName "fast forward">]FastForward
    | [<CompiledName "forward">]Forward
    | [<CompiledName "pause">]Pause
    | [<CompiledName "pause circle">]PauseCircle
    | [<CompiledName "pause circle outline">]PauseCircleOutline
    | [<CompiledName "play circle">]PlayCircle
    | [<CompiledName "play circle outline">]PlayCircleOutline
    | [<CompiledName "podcast">]Podcast
    | [<CompiledName "random">]Random
    | [<CompiledName "step backward">]StepBackward
    | [<CompiledName "step forward">]StepForward
    | [<CompiledName "stop">]Stop
    | [<CompiledName "stop circle">]StopCircle
    | [<CompiledName "stop circle outline">]StopCircleOutline
    | [<CompiledName "video">]Video
    | [<CompiledName "volume down">]VolumeDown
    | [<CompiledName "volume off">]VolumeOff
    | [<CompiledName "volume up">]VolumeUp
    | [<CompiledName "chart area">]ChartArea
    | [<CompiledName "chart bar">]ChartBar
    | [<CompiledName "chart bar outline">]ChartBarOutline
    | [<CompiledName "chart line">]ChartLine
    | [<CompiledName "chart pie">]ChartPie
    | [<CompiledName "copyright">]Copyright
    | [<CompiledName "copyright outline">]CopyrightOutline
    | [<CompiledName "percent">]Percent
    | [<CompiledName "registered">]Registered
    | [<CompiledName "registered outline">]RegisteredOutline
    | [<CompiledName "trademark">]Trademark
    | [<CompiledName "chess">]Chess
    | [<CompiledName "chess bishop">]ChessBishop
    | [<CompiledName "chess board">]ChessBoard
    | [<CompiledName "chess king">]ChessKing
    | [<CompiledName "chess knight">]ChessKnight
    | [<CompiledName "chess pawn">]ChessPawn
    | [<CompiledName "chess queen">]ChessQueen
    | [<CompiledName "chess rook">]ChessRook
    | [<CompiledName "square full">]SquareFull
    | [<CompiledName "code">]Code
    | [<CompiledName "code branch">]CodeBranch
    | [<CompiledName "window close">]WindowClose
    | [<CompiledName "window close outline">]WindowCloseOutline
    | [<CompiledName "window maximize">]WindowMaximize
    | [<CompiledName "window maximize outline">]WindowMaximizeOutline
    | [<CompiledName "window minimize">]WindowMinimize
    | [<CompiledName "window minimize outline">]WindowMinimizeOutline
    | [<CompiledName "window restore">]WindowRestore
    | [<CompiledName "window restore outline">]WindowRestoreOutline
    | [<CompiledName "american sign language interpreting">]AmericanSignLanguageInterpreting
    | [<CompiledName "assistive listening systems">]AssistiveListeningSystems
    | [<CompiledName "at">]At
    | [<CompiledName "comment alternate">]CommentAlternate
    | [<CompiledName "comment alternate outline">]CommentAlternateOutline
    | [<CompiledName "comments">]Comments
    | [<CompiledName "comments outline">]CommentsOutline
    | [<CompiledName "envelope square">]EnvelopeSquare
    | [<CompiledName "dollar sign">]DollarSign
    | [<CompiledName "euro sign">]EuroSign
    | [<CompiledName "lira sign">]LiraSign
    | [<CompiledName "pound sign">]PoundSign
    | [<CompiledName "ruble sign">]RubleSign
    | [<CompiledName "rupee sign">]RupeeSign
    | [<CompiledName "shekel sign">]ShekelSign
    | [<CompiledName "won sign">]WonSign
    | [<CompiledName "yen sign">]YenSign
    | [<CompiledName "clock">]Clock
    | [<CompiledName "clock outline">]ClockOutline
    | [<CompiledName "hourglass end">]HourglassEnd
    | [<CompiledName "hourglass half">]HourglassHalf
    | [<CompiledName "hourglass start">]HourglassStart
    | [<CompiledName "object group">]ObjectGroup
    | [<CompiledName "object group outline">]ObjectGroupOutline
    | [<CompiledName "object ungroup">]ObjectUngroup
    | [<CompiledName "object ungroup outline">]ObjectUngroupOutline
    | [<CompiledName "align center">]AlignCenter
    | [<CompiledName "align justify">]AlignJustify
    | [<CompiledName "align left">]AlignLeft
    | [<CompiledName "align right">]AlignRight
    | [<CompiledName "bold">]Bold
    | [<CompiledName "font">]Font
    | [<CompiledName "heading">]Heading
    | [<CompiledName "indent">]Indent
    | [<CompiledName "italic">]Italic
    | [<CompiledName "list">]List
    | [<CompiledName "list alternate">]ListAlternate
    | [<CompiledName "list alternate outline">]ListAlternateOutline
    | [<CompiledName "list ol">]ListOl
    | [<CompiledName "list ul">]ListUl
    | [<CompiledName "outdent">]Outdent
     | [<CompiledName "strikethrough">]Strikethrough
    | [<CompiledName "subscript">]Subscript
    | [<CompiledName "superscript">]Superscript
     | [<CompiledName "table">]Table
    | [<CompiledName "tasks">]Tasks
    | [<CompiledName "text height">]TextHeight
    | [<CompiledName "text width">]TextWidth
    | [<CompiledName "th">]Th
    | [<CompiledName "th large">]ThLarge
    | [<CompiledName "th list">]ThList
    | [<CompiledName "underline">]Underline
    | [<CompiledName "unlink">]Unlink
    | [<CompiledName "file archive">]FileArchive
    | [<CompiledName "file archive outline">]FileArchiveOutline
    | [<CompiledName "file audio">]FileAudio
    | [<CompiledName "file audio outline">]FileAudioOutline
    | [<CompiledName "file code">]FileCode
    | [<CompiledName "file code outline">]FileCodeOutline
    | [<CompiledName "file excel">]FileExcel
    | [<CompiledName "file excel outline">]FileExcelOutline
    | [<CompiledName "file pdf">]FilePdf
    | [<CompiledName "file pdf outline">]FilePdfOutline
    | [<CompiledName "file powerpoint">]FilePowerpoint
    | [<CompiledName "file powerpoint outline">]FilePowerpointOutline
    | [<CompiledName "file video">]FileVideo
    | [<CompiledName "file video outline">]FileVideoOutline
    | [<CompiledName "file word">]FileWord
    | [<CompiledName "file word outline">]FileWordOutline
    | [<CompiledName "genderless">]Genderless
    | [<CompiledName "mars">]Mars
    | [<CompiledName "mars double">]MarsDouble
    | [<CompiledName "mars stroke">]MarsStroke
    | [<CompiledName "mars stroke horizontal">]MarsStrokeHorizontal
    | [<CompiledName "mars stroke vertical">]MarsStrokeVertical
    | [<CompiledName "mercury">]Mercury
    | [<CompiledName "neuter">]Neuter
    | [<CompiledName "transgender">]Transgender
    | [<CompiledName "transgender alternate">]TransgenderAlternate
    | [<CompiledName "venus">]Venus
    | [<CompiledName "venus double">]VenusDouble
    | [<CompiledName "venus mars">]VenusMars
    | [<CompiledName "hand lizard">]HandLizard
    | [<CompiledName "hand lizard outline">]HandLizardOutline
    | [<CompiledName "hand paper">]HandPaper
    | [<CompiledName "hand paper outline">]HandPaperOutline
    | [<CompiledName "hand peace">]HandPeace
    | [<CompiledName "hand peace outline">]HandPeaceOutline
    | [<CompiledName "hand point down">]HandPointDown
    | [<CompiledName "hand point down outline">]HandPointDownOutline
    | [<CompiledName "hand point left">]HandPointLeft
    | [<CompiledName "hand point left outline">]HandPointLeftOutline
    | [<CompiledName "hand point right">]HandPointRight
    | [<CompiledName "hand point right outline">]HandPointRightOutline
    | [<CompiledName "hand point up">]HandPointUp
    | [<CompiledName "hand point up outline">]HandPointUpOutline
    | [<CompiledName "hand pointer">]HandPointer
    | [<CompiledName "hand pointer outline">]HandPointerOutline
    | [<CompiledName "hand rock">]HandRock
    | [<CompiledName "hand rock outline">]HandRockOutline
    | [<CompiledName "hand scissors">]HandScissors
    | [<CompiledName "hand scissors outline">]HandScissorsOutline
    | [<CompiledName "hand spock">]HandSpock
    | [<CompiledName "hand spock outline">]HandSpockOutline
    | [<CompiledName "adjust">]Adjust
    | [<CompiledName "bolt">]Bolt
    | [<CompiledName "compress">]Compress
    | [<CompiledName "expand">]Expand
    | [<CompiledName "file image">]FileImage
    | [<CompiledName "file image outline">]FileImageOutline
    | [<CompiledName "barcode">]Barcode
    | [<CompiledName "bars">]Bars
    | [<CompiledName "check">]Check
    | [<CompiledName "check circle">]CheckCircle
    | [<CompiledName "check circle outline">]CheckCircleOutline
    | [<CompiledName "check square">]CheckSquare
    | [<CompiledName "check square outline">]CheckSquareOutline
    | [<CompiledName "clone">]Clone
    | [<CompiledName "clone outline">]CloneOutline
    | [<CompiledName "database">]Database
    | [<CompiledName "dot circle">]DotCircle
    | [<CompiledName "dot circle outline">]DotCircleOutline
    | [<CompiledName "download">]Download
    | [<CompiledName "ellipsis horizontal">]EllipsisHorizontal
    | [<CompiledName "ellipsis vertical">]EllipsisVertical
    | [<CompiledName "external alternate">]ExternalAlternate
    | [<CompiledName "external square alternate">]ExternalSquareAlternate
    | [<CompiledName "filter">]Filter
    | [<CompiledName "hashtag">]Hashtag
    | [<CompiledName "history">]History
    | [<CompiledName "i cursor">]ICursor
    | [<CompiledName "language">]Language
    | [<CompiledName "microphone slash">]MicrophoneSlash
    | [<CompiledName "qrcode">]Qrcode
    | [<CompiledName "redo">]Redo
    | [<CompiledName "redo alternate">]RedoAlternate
    | [<CompiledName "reply">]Reply
    | [<CompiledName "reply all">]ReplyAll
    | [<CompiledName "rss">]Rss
    | [<CompiledName "rss square">]RssSquare
    | [<CompiledName "share">]Share
    | [<CompiledName "share alternate">]ShareAlternate
    | [<CompiledName "share alternate square">]ShareAlternateSquare
    | [<CompiledName "share square">]ShareSquare
    | [<CompiledName "share square outline">]ShareSquareOutline
    | [<CompiledName "signal">]Signal
    | [<CompiledName "sitemap">]Sitemap
    | [<CompiledName "sliders horizontal">]SlidersHorizontal
    | [<CompiledName "sort">]Sort
    | [<CompiledName "sort alphabet down">]SortAlphabetDown
    | [<CompiledName "sort alphabet up">]SortAlphabetUp
    | [<CompiledName "sort amount down">]SortAmountDown
    | [<CompiledName "sort amount up">]SortAmountUp
    | [<CompiledName "sort down">]SortDown
    | [<CompiledName "sort numeric down">]SortNumericDown
    | [<CompiledName "sort numeric up">]SortNumericUp
    | [<CompiledName "sort up">]SortUp
    | [<CompiledName "star half">]StarHalf
    | [<CompiledName "star half outline">]StarHalfOutline
    | [<CompiledName "sync alternate">]SyncAlternate
    | [<CompiledName "times">]Times
    | [<CompiledName "times circle">]TimesCircle
    | [<CompiledName "times circle outline">]TimesCircleOutline
    | [<CompiledName "undo">]Undo
    | [<CompiledName "undo alternate">]UndoAlternate
    | [<CompiledName "upload">]Upload
    | [<CompiledName "box">]Box
    | [<CompiledName "boxes">]Boxes
    | [<CompiledName "clipboard check">]ClipboardCheck
    | [<CompiledName "clipboard list">]ClipboardList
    | [<CompiledName "dolly">]Dolly
    | [<CompiledName "dolly flatbed">]DollyFlatbed
    | [<CompiledName "pallet">]Pallet
    | [<CompiledName "shipping fast">]ShippingFast
    | [<CompiledName "location arrow">]LocationArrow
    | [<CompiledName "low vision">]LowVision
    | [<CompiledName "music">]Music
    | [<CompiledName "phone square">]PhoneSquare
    | [<CompiledName "phone volume">]PhoneVolume
    | [<CompiledName "recycle">]Recycle
    | [<CompiledName "search minus">]SearchMinus
    | [<CompiledName "search plus">]SearchPlus
    | [<CompiledName "tty">]Tty
    | [<CompiledName "wifi">]Wifi
    | [<CompiledName "band aid">]BandAid
    | [<CompiledName "dna">]Dna
    | [<CompiledName "hospital symbol">]HospitalSymbol
    | [<CompiledName "pills">]Pills
    | [<CompiledName "stethoscope">]Stethoscope
    | [<CompiledName "syringe">]Syringe
    | [<CompiledName "weight">]Weight
    | [<CompiledName "anchor">]Anchor
    | [<CompiledName "balance scale">]BalanceScale
    | [<CompiledName "bath">]Bath
    | [<CompiledName "beer">]Beer
    | [<CompiledName "binoculars">]Binoculars
    | [<CompiledName "birthday cake">]BirthdayCake
    | [<CompiledName "bomb">]Bomb
    | [<CompiledName "briefcase">]Briefcase
    | [<CompiledName "bug">]Bug
    | [<CompiledName "building">]Building
    | [<CompiledName "building outline">]BuildingOutline
    | [<CompiledName "bullseye">]Bullseye
    | [<CompiledName "calculator">]Calculator
    | [<CompiledName "clipboard">]Clipboard
    | [<CompiledName "clipboard outline">]ClipboardOutline
    | [<CompiledName "coffee">]Coffee
    | [<CompiledName "copy">]Copy
    | [<CompiledName "copy outline">]CopyOutline
    | [<CompiledName "cube">]Cube
    | [<CompiledName "cubes">]Cubes
    | [<CompiledName "cut">]Cut
    | [<CompiledName "eye dropper">]EyeDropper
    | [<CompiledName "fax">]Fax
    | [<CompiledName "film">]Film
    | [<CompiledName "fire">]Fire
    | [<CompiledName "fire extinguisher">]FireExtinguisher
    | [<CompiledName "flag">]Flag
    | [<CompiledName "flag outline">]FlagOutline
    | [<CompiledName "flag checkered">]FlagCheckered
    | [<CompiledName "flask">]Flask
    | [<CompiledName "gamepad">]Gamepad
    | [<CompiledName "gavel">]Gavel
    | [<CompiledName "glass martini">]GlassMartini
    | [<CompiledName "globe">]Globe
    | [<CompiledName "graduation cap">]GraduationCap
    | [<CompiledName "hdd">]Hdd
    | [<CompiledName "hdd outline">]HddOutline
    | [<CompiledName "headphones">]Headphones
    | [<CompiledName "home">]Home
    | [<CompiledName "hospital">]Hospital
    | [<CompiledName "hospital outline">]HospitalOutline
    | [<CompiledName "hourglass">]Hourglass
    | [<CompiledName "hourglass outline">]HourglassOutline
    | [<CompiledName "image">]Image
    | [<CompiledName "image outline">]ImageOutline
    | [<CompiledName "images">]Images
    | [<CompiledName "images outline">]ImagesOutline
    | [<CompiledName "industry">]Industry
    | [<CompiledName "laptop">]Laptop
    | [<CompiledName "leaf">]Leaf
    | [<CompiledName "lemon">]Lemon
    | [<CompiledName "lemon outline">]LemonOutline
    | [<CompiledName "lightbulb">]Lightbulb
    | [<CompiledName "lightbulb outline">]LightbulbOutline
    | [<CompiledName "magic">]Magic
    | [<CompiledName "magnet">]Magnet
    | [<CompiledName "map">]Map
    | [<CompiledName "map outline">]MapOutline
    | [<CompiledName "map marker alternate">]MapMarkerAlternate
    | [<CompiledName "map pin">]MapPin
    | [<CompiledName "map signs">]MapSigns
    | [<CompiledName "medkit">]Medkit
    | [<CompiledName "microchip">]Microchip
    | [<CompiledName "microphone">]Microphone
    | [<CompiledName "mobile">]Mobile
    | [<CompiledName "mobile alternate">]MobileAlternate
    | [<CompiledName "money bill alternate">]MoneyBillAlternate
    | [<CompiledName "money bill alternate outline">]MoneyBillAlternateOutline
    | [<CompiledName "moon">]Moon
    | [<CompiledName "moon outline">]MoonOutline
    | [<CompiledName "paint brush">]PaintBrush
    | [<CompiledName "paste">]Paste
    | [<CompiledName "paw">]Paw
    | [<CompiledName "phone">]Phone
    | [<CompiledName "plug">]Plug
    | [<CompiledName "print">]Print
    | [<CompiledName "puzzle piece">]PuzzlePiece
    | [<CompiledName "road">]Road
    | [<CompiledName "save">]Save
    | [<CompiledName "save outline">]SaveOutline
    | [<CompiledName "search">]Search
    | [<CompiledName "shower">]Shower
    | [<CompiledName "stopwatch">]Stopwatch
    | [<CompiledName "suitcase">]Suitcase
    | [<CompiledName "tablet">]Tablet
    | [<CompiledName "tablet alternate">]TabletAlternate
    | [<CompiledName "tachometer alternate">]TachometerAlternate
    | [<CompiledName "ticket alternate">]TicketAlternate
    | [<CompiledName "trash">]Trash
    | [<CompiledName "trash alternate">]TrashAlternate
    | [<CompiledName "trash alternate outline">]TrashAlternateOutline
    | [<CompiledName "tree">]Tree
    | [<CompiledName "tv">]Tv
    | [<CompiledName "umbrella">]Umbrella
    | [<CompiledName "university">]University
    | [<CompiledName "utensil spoon">]UtensilSpoon
    | [<CompiledName "utensils">]Utensils
    | [<CompiledName "wrench">]Wrench
    | [<CompiledName "bullhorn">]Bullhorn
    | [<CompiledName "camera">]Camera
    | [<CompiledName "camera retro">]CameraRetro
    | [<CompiledName "credit card">]CreditCard
    | [<CompiledName "credit card outline">]CreditCardOutline
    | [<CompiledName "gem">]Gem
    | [<CompiledName "gem outline">]GemOutline
    | [<CompiledName "gift">]Gift
    | [<CompiledName "handshake">]Handshake
    | [<CompiledName "handshake outline">]HandshakeOutline
    | [<CompiledName "key">]Key
    | [<CompiledName "shopping bag">]ShoppingBag
    | [<CompiledName "shopping basket">]ShoppingBasket
    | [<CompiledName "tag">]Tag
    | [<CompiledName "trophy">]Trophy
    | [<CompiledName "circle">]Circle
    | [<CompiledName "circle outline">]CircleOutline
    | [<CompiledName "cloud">]Cloud
    | [<CompiledName "comment">]Comment
    | [<CompiledName "comment outline">]CommentOutline
    | [<CompiledName "heart">]Heart
    | [<CompiledName "heart outline">]HeartOutline
    | [<CompiledName "map marker">]MapMarker
    | [<CompiledName "play">]Play
    | [<CompiledName "square">]Square
    | [<CompiledName "square outline">]SquareOutline
    | [<CompiledName "star">]Star
    | [<CompiledName "star outline">]StarOutline
    | [<CompiledName "asterisk">]Asterisk
    | [<CompiledName "certificate">]Certificate
    | [<CompiledName "circle notch">]CircleNotch
    | [<CompiledName "cog">]Cog
    | [<CompiledName "compass">]Compass
    | [<CompiledName "compass outline">]CompassOutline
    | [<CompiledName "crosshairs">]Crosshairs
    | [<CompiledName "life ring">]LifeRing
    | [<CompiledName "life ring outline">]LifeRingOutline
    | [<CompiledName "snowflake">]Snowflake
    | [<CompiledName "snowflake outline">]SnowflakeOutline
    | [<CompiledName "spinner">]Spinner
    | [<CompiledName "sun">]Sun
    | [<CompiledName "sun outline">]SunOutline
    | [<CompiledName "sync">]Sync
    | [<CompiledName "baseball ball">]BaseballBall
    | [<CompiledName "basketball ball">]BasketballBall
    | [<CompiledName "bowling ball">]BowlingBall
    | [<CompiledName "football ball">]FootballBall
    | [<CompiledName "futbol">]Futbol
    | [<CompiledName "futbol outline">]FutbolOutline
    | [<CompiledName "golf ball">]GolfBall
    | [<CompiledName "hockey puck">]HockeyPuck
    | [<CompiledName "quidditch">]Quidditch
    | [<CompiledName "table tennis">]TableTennis
    | [<CompiledName "volleyball ball">]VolleyballBall
    | [<CompiledName "ban">]Ban
    | [<CompiledName "battery empty">]BatteryEmpty
    | [<CompiledName "battery full">]BatteryFull
    | [<CompiledName "battery half">]BatteryHalf
    | [<CompiledName "battery quarter">]BatteryQuarter
    | [<CompiledName "battery three quarters">]BatteryThreeQuarters
    | [<CompiledName "bell">]Bell
    | [<CompiledName "bell outline">]BellOutline
    | [<CompiledName "bell slash">]BellSlash
    | [<CompiledName "bell slash outline">]BellSlashOutline
    | [<CompiledName "calendar">]Calendar
    | [<CompiledName "calendar outline">]CalendarOutline
    | [<CompiledName "calendar alternate">]CalendarAlternate
    | [<CompiledName "calendar alternate outline">]CalendarAlternateOutline
    | [<CompiledName "calendar check">]CalendarCheck
    | [<CompiledName "calendar check outline">]CalendarCheckOutline
    | [<CompiledName "calendar minus">]CalendarMinus
    | [<CompiledName "calendar minus outline">]CalendarMinusOutline
    | [<CompiledName "calendar plus">]CalendarPlus
    | [<CompiledName "calendar plus outline">]CalendarPlusOutline
    | [<CompiledName "calendar times">]CalendarTimes
    | [<CompiledName "calendar times outline">]CalendarTimesOutline
    | [<CompiledName "cart arrow down">]CartArrowDown
    | [<CompiledName "cart plus">]CartPlus
    | [<CompiledName "exclamation">]Exclamation
    | [<CompiledName "exclamation circle">]ExclamationCircle
    | [<CompiledName "exclamation triangle">]ExclamationTriangle
    | [<CompiledName "eye">]Eye
    | [<CompiledName "eye slash">]EyeSlash
    | [<CompiledName "eye slash outline">]EyeSlashOutline
    | [<CompiledName "info">]Info
    | [<CompiledName "info circle">]InfoCircle
    | [<CompiledName "lock">]Lock
    | [<CompiledName "lock open">]LockOpen
    | [<CompiledName "minus">]Minus
    | [<CompiledName "minus circle">]MinusCircle
    | [<CompiledName "minus square">]MinusSquare
    | [<CompiledName "minus square outline">]MinusSquareOutline
    | [<CompiledName "plus">]Plus
    | [<CompiledName "plus circle">]PlusCircle
    | [<CompiledName "plus square">]PlusSquare
    | [<CompiledName "plus square outline">]PlusSquareOutline
    | [<CompiledName "question">]Question
    | [<CompiledName "question circle">]QuestionCircle
    | [<CompiledName "question circle outline">]QuestionCircleOutline
    | [<CompiledName "shield alternate">]ShieldAlternate
    | [<CompiledName "sign in alternate">]SignInAlternate
    | [<CompiledName "sign out alternate">]SignOutAlternate
    | [<CompiledName "thermometer empty">]ThermometerEmpty
    | [<CompiledName "thermometer full">]ThermometerFull
    | [<CompiledName "thermometer half">]ThermometerHalf
    | [<CompiledName "thermometer quarter">]ThermometerQuarter
    | [<CompiledName "thermometer three quarters">]ThermometerThreeQuarters
    | [<CompiledName "thumbs down">]ThumbsDown
    | [<CompiledName "thumbs down outline">]ThumbsDownOutline
    | [<CompiledName "thumbs up">]ThumbsUp
    | [<CompiledName "thumbs up outline">]ThumbsUpOutline
    | [<CompiledName "toggle off">]ToggleOff
    | [<CompiledName "toggle on">]ToggleOn
    | [<CompiledName "unlock">]Unlock
    | [<CompiledName "unlock alternate">]UnlockAlternate
    | [<CompiledName "address book">]AddressBook
    | [<CompiledName "address book outline">]AddressBookOutline
    | [<CompiledName "address card">]AddressCard
    | [<CompiledName "address card outline">]AddressCardOutline
    | [<CompiledName "bed">]Bed
    | [<CompiledName "blind">]Blind
    | [<CompiledName "child">]Child
    | [<CompiledName "female">]Female
    | [<CompiledName "frown">]Frown
    | [<CompiledName "frown outline">]FrownOutline
    | [<CompiledName "id badge">]IdBadge
    | [<CompiledName "id badge outline">]IdBadgeOutline
    | [<CompiledName "id card">]IdCard
    | [<CompiledName "id card outline">]IdCardOutline
    | [<CompiledName "male">]Male
    | [<CompiledName "meh">]Meh
    | [<CompiledName "meh outline">]MehOutline
    | [<CompiledName "power off">]PowerOff
    | [<CompiledName "smile">]Smile
    | [<CompiledName "smile outline">]SmileOutline
    | [<CompiledName "street view">]StreetView
    | [<CompiledName "user">]User
    | [<CompiledName "user outline">]UserOutline
    | [<CompiledName "user circle">]UserCircle
    | [<CompiledName "user circle outline">]UserCircleOutline
    | [<CompiledName "user md">]UserMd
    | [<CompiledName "user plus">]UserPlus
    | [<CompiledName "user secret">]UserSecret
    | [<CompiledName "user times">]UserTimes
    | [<CompiledName "users">]Users
    | [<CompiledName "ambulance">]Ambulance
    | [<CompiledName "bicycle">]Bicycle
    | [<CompiledName "bus">]Bus
    | [<CompiledName "car">]Car
    | [<CompiledName "fighter jet">]FighterJet
    | [<CompiledName "motorcycle">]Motorcycle
    | [<CompiledName "plane">]Plane
    | [<CompiledName "rocket">]Rocket
    | [<CompiledName "ship">]Ship
    | [<CompiledName "shopping cart">]ShoppingCart
    | [<CompiledName "space shuttle">]SpaceShuttle
    | [<CompiledName "subway">]Subway
    | [<CompiledName "taxi">]Taxi
    | [<CompiledName "train">]Train
    | [<CompiledName "truck">]Truck
    | [<CompiledName "wheelchair">]Wheelchair
    | [<CompiledName "archive">]Archive
    | [<CompiledName "book">]Book
    | [<CompiledName "bookmark">]Bookmark
    | [<CompiledName "bookmark outline">]BookmarkOutline
    | [<CompiledName "edit">]Edit
    | [<CompiledName "edit outline">]EditOutline
    | [<CompiledName "envelope">]Envelope
    | [<CompiledName "envelope outline">]EnvelopeOutline
    | [<CompiledName "envelope open">]EnvelopeOpen
    | [<CompiledName "envelope open outline">]EnvelopeOpenOutline
    | [<CompiledName "eraser">]Eraser
    | [<CompiledName "file">]File
    | [<CompiledName "file outline">]FileOutline
    | [<CompiledName "file alternate">]FileAlternate
    | [<CompiledName "file alternate outline">]FileAlternateOutline
    | [<CompiledName "folder">]Folder
    | [<CompiledName "folder outline">]FolderOutline
    | [<CompiledName "folder open">]FolderOpen
    | [<CompiledName "folder open outline">]FolderOpenOutline
    | [<CompiledName "keyboard">]Keyboard
    | [<CompiledName "keyboard outline">]KeyboardOutline
    | [<CompiledName "newspaper">]Newspaper
    | [<CompiledName "newspaper outline">]NewspaperOutline
    | [<CompiledName "paper plane">]PaperPlane
    | [<CompiledName "paper plane outline">]PaperPlaneOutline
    | [<CompiledName "paperclip">]Paperclip
    | [<CompiledName "paragraph">]Paragraph
    | [<CompiledName "pen square">]PenSquare
    | [<CompiledName "pencil alternate">]PencilAlternate
    | [<CompiledName "quote left">]QuoteLeft
    | [<CompiledName "quote right">]QuoteRight
    | [<CompiledName "sticky note">]StickyNote
    | [<CompiledName "sticky note outline">]StickyNoteOutline
    | [<CompiledName "thumbtack">]Thumbtack
    | [<CompiledName "500px">]N500px
    | [<CompiledName "accessible">]Accessible
    | [<CompiledName "accusoft">]Accusoft
    | [<CompiledName "adn">]Adn
    | [<CompiledName "adversal">]Adversal
    | [<CompiledName "affiliatetheme">]Affiliatetheme
    | [<CompiledName "algolia">]Algolia
    | [<CompiledName "amazon">]Amazon
    | [<CompiledName "amazon pay">]AmazonPay
    | [<CompiledName "amilia">]Amilia
    | [<CompiledName "android">]Android
    | [<CompiledName "angellist">]Angellist
    | [<CompiledName "angrycreative">]Angrycreative
    | [<CompiledName "angular">]Angular
    | [<CompiledName "app store">]AppStore
    | [<CompiledName "app store ios">]AppStoreIos
    | [<CompiledName "apper">]Apper
    | [<CompiledName "apple">]Apple
    | [<CompiledName "apple pay">]ApplePay
    | [<CompiledName "asymmetrik">]Asymmetrik
    | [<CompiledName "audible">]Audible
    | [<CompiledName "autoprefixer">]Autoprefixer
    | [<CompiledName "avianex">]Avianex
    | [<CompiledName "aviato">]Aviato
    | [<CompiledName "aws">]Aws
    | [<CompiledName "bandcamp">]Bandcamp
    | [<CompiledName "behance">]Behance
    | [<CompiledName "behance square">]BehanceSquare
    | [<CompiledName "bimobject">]Bimobject
    | [<CompiledName "bitbucket">]Bitbucket
    | [<CompiledName "bitcoin">]Bitcoin
    | [<CompiledName "bity">]Bity
    | [<CompiledName "black tie">]BlackTie
    | [<CompiledName "blackberry">]Blackberry
    | [<CompiledName "blogger">]Blogger
    | [<CompiledName "blogger b">]BloggerB
    | [<CompiledName "bluetooth">]Bluetooth
    | [<CompiledName "bluetooth b">]BluetoothB
    | [<CompiledName "btc">]Btc
    | [<CompiledName "buromobelexperte">]Buromobelexperte
    | [<CompiledName "buysellads">]Buysellads
    | [<CompiledName "centercode">]Centercode
    | [<CompiledName "chrome">]Chrome
    | [<CompiledName "cloudscale">]Cloudscale
    | [<CompiledName "cloudsmith">]Cloudsmith
    | [<CompiledName "cloudversify">]Cloudversify
    | [<CompiledName "codepen">]Codepen
    | [<CompiledName "codiepie">]Codiepie
    | [<CompiledName "connectdevelop">]Connectdevelop
    | [<CompiledName "contao">]Contao
    | [<CompiledName "cpanel">]Cpanel
    | [<CompiledName "creative commons">]CreativeCommons
    | [<CompiledName "css3">]Css3
    | [<CompiledName "css3 alternate">]Css3Alternate
    | [<CompiledName "cuttlefish">]Cuttlefish
    | [<CompiledName "d and">]DAnd
    | [<CompiledName "dashcube">]Dashcube
    | [<CompiledName "delicious">]Delicious
    | [<CompiledName "deploydog">]Deploydog
    | [<CompiledName "deskpro">]Deskpro
    | [<CompiledName "deviantart">]Deviantart
    | [<CompiledName "digg">]Digg
    | [<CompiledName "digital ocean">]DigitalOcean
    | [<CompiledName "discord">]Discord
    | [<CompiledName "discourse">]Discourse
    | [<CompiledName "dochub">]Dochub
    | [<CompiledName "docker">]Docker
    | [<CompiledName "draft2digital">]Draft2digital
    | [<CompiledName "dribbble">]Dribbble
    | [<CompiledName "dribbble square">]DribbbleSquare
    | [<CompiledName "dropbox">]Dropbox
    | [<CompiledName "drupal">]Drupal
    | [<CompiledName "dyalog">]Dyalog
    | [<CompiledName "earlybirds">]Earlybirds
    | [<CompiledName "edge">]Edge
    | [<CompiledName "elementor">]Elementor
    | [<CompiledName "ember">]Ember
    | [<CompiledName "empire">]Empire
    | [<CompiledName "envira">]Envira
    | [<CompiledName "erlang">]Erlang
    | [<CompiledName "ethereum">]Ethereum
    | [<CompiledName "etsy">]Etsy
    | [<CompiledName "expeditedssl">]Expeditedssl
    | [<CompiledName "facebook">]Facebook
    | [<CompiledName "facebook f">]FacebookF
    | [<CompiledName "facebook messenger">]FacebookMessenger
    | [<CompiledName "facebook square">]FacebookSquare
    | [<CompiledName "firefox">]Firefox
    | [<CompiledName "first order">]FirstOrder
    | [<CompiledName "firstdraft">]Firstdraft
    | [<CompiledName "flickr">]Flickr
    | [<CompiledName "flipboard">]Flipboard
    | [<CompiledName "fly">]Fly
    | [<CompiledName "font awesome">]FontAwesome
    | [<CompiledName "font awesome alternate">]FontAwesomeAlternate
    | [<CompiledName "font awesome flag">]FontAwesomeFlag
    | [<CompiledName "fonticons">]Fonticons
    | [<CompiledName "fonticons fi">]FonticonsFi
    | [<CompiledName "fort awesome">]FortAwesome
    | [<CompiledName "fort awesome alternate">]FortAwesomeAlternate
    | [<CompiledName "forumbee">]Forumbee
    | [<CompiledName "foursquare">]Foursquare
    | [<CompiledName "free code camp">]FreeCodeCamp
    | [<CompiledName "freebsd">]Freebsd
    | [<CompiledName "get pocket">]GetPocket
    | [<CompiledName "gg">]Gg
    | [<CompiledName "gg circle">]GgCircle
    | [<CompiledName "git">]Git
    | [<CompiledName "git square">]GitSquare
    | [<CompiledName "github">]Github
    | [<CompiledName "github alternate">]GithubAlternate
    | [<CompiledName "github square">]GithubSquare
    | [<CompiledName "gitkraken">]Gitkraken
    | [<CompiledName "gitlab">]Gitlab
    | [<CompiledName "gitter">]Gitter
    | [<CompiledName "glide">]Glide
    | [<CompiledName "glide g">]GlideG
    | [<CompiledName "gofore">]Gofore
    | [<CompiledName "goodreads">]Goodreads
    | [<CompiledName "goodreads g">]GoodreadsG
    | [<CompiledName "google">]Google
    | [<CompiledName "google drive">]GoogleDrive
    | [<CompiledName "google play">]GooglePlay
    | [<CompiledName "google plus">]GooglePlus
    | [<CompiledName "google plus g">]GooglePlusG
    | [<CompiledName "google plus square">]GooglePlusSquare
    | [<CompiledName "google wallet">]GoogleWallet
    | [<CompiledName "gratipay">]Gratipay
    | [<CompiledName "grav">]Grav
    | [<CompiledName "gripfire">]Gripfire
    | [<CompiledName "grunt">]Grunt
    | [<CompiledName "gulp">]Gulp
    | [<CompiledName "hacker news">]HackerNews
    | [<CompiledName "hacker news square">]HackerNewsSquare
    | [<CompiledName "hips">]Hips
    | [<CompiledName "hire a helper">]HireAHelper
    | [<CompiledName "hooli">]Hooli
    | [<CompiledName "hotjar">]Hotjar
    | [<CompiledName "houzz">]Houzz
    | [<CompiledName "html5">]Html5
    | [<CompiledName "hubspot">]Hubspot
    | [<CompiledName "imdb">]Imdb
    | [<CompiledName "instagram">]Instagram
    | [<CompiledName "internet explorer">]InternetExplorer
    | [<CompiledName "ioxhost">]Ioxhost
    | [<CompiledName "itunes">]Itunes
    | [<CompiledName "itunes note">]ItunesNote
    | [<CompiledName "jenkins">]Jenkins
    | [<CompiledName "joget">]Joget
    | [<CompiledName "joomla">]Joomla
    | [<CompiledName "js">]Js
    | [<CompiledName "js square">]JsSquare
    | [<CompiledName "jsfiddle">]Jsfiddle
    | [<CompiledName "keycdn">]Keycdn
    | [<CompiledName "kickstarter">]Kickstarter
    | [<CompiledName "kickstarter k">]KickstarterK
    | [<CompiledName "korvue">]Korvue
    | [<CompiledName "laravel">]Laravel
    | [<CompiledName "lastfm">]Lastfm
    | [<CompiledName "lastfm square">]LastfmSquare
    | [<CompiledName "leanpub">]Leanpub
    | [<CompiledName "less">]Less
    | [<CompiledName "linechat">]Linechat
    | [<CompiledName "linkedin">]Linkedin
    | [<CompiledName "linkedin in">]LinkedinIn
    | [<CompiledName "linode">]Linode
    | [<CompiledName "linux">]Linux
    | [<CompiledName "lyft">]Lyft
    | [<CompiledName "magento">]Magento
    | [<CompiledName "maxcdn">]Maxcdn
    | [<CompiledName "medapps">]Medapps
    | [<CompiledName "medium">]Medium
    | [<CompiledName "medium m">]MediumM
    | [<CompiledName "medrt">]Medrt
    | [<CompiledName "meetup">]Meetup
    | [<CompiledName "microsoft">]Microsoft
    | [<CompiledName "mix">]Mix
    | [<CompiledName "mixcloud">]Mixcloud
    | [<CompiledName "mizuni">]Mizuni
    | [<CompiledName "modx">]Modx
    | [<CompiledName "monero">]Monero
    | [<CompiledName "napster">]Napster
    | [<CompiledName "nintendo switch">]NintendoSwitch
    | [<CompiledName "node">]Node
    | [<CompiledName "node js">]NodeJs
    | [<CompiledName "npm">]Npm
    | [<CompiledName "ns8">]Ns8
    | [<CompiledName "nutritionix">]Nutritionix
    | [<CompiledName "odnoklassniki">]Odnoklassniki
    | [<CompiledName "odnoklassniki square">]OdnoklassnikiSquare
    | [<CompiledName "opencart">]Opencart
    | [<CompiledName "openid">]Openid
    | [<CompiledName "opera">]Opera
    | [<CompiledName "osi">]Osi
    | [<CompiledName "page4">]Page4
    | [<CompiledName "pagelines">]Pagelines
    | [<CompiledName "palfed">]Palfed
    | [<CompiledName "patreon">]Patreon
    | [<CompiledName "paypal">]Paypal
    | [<CompiledName "periscope">]Periscope
    | [<CompiledName "phabricator">]Phabricator
    | [<CompiledName "phoenix framework">]PhoenixFramework
    | [<CompiledName "php">]Php
    | [<CompiledName "pied piper">]PiedPiper
    | [<CompiledName "pied piper alternate">]PiedPiperAlternate
    | [<CompiledName "pied piper pp">]PiedPiperPp
    | [<CompiledName "pinterest">]Pinterest
    | [<CompiledName "pinterest p">]PinterestP
    | [<CompiledName "pinterest square">]PinterestSquare
    | [<CompiledName "playstation">]Playstation
    | [<CompiledName "product hunt">]ProductHunt
    | [<CompiledName "pushed">]Pushed
    | [<CompiledName "python">]Python
    | [<CompiledName "qq">]Qq
    | [<CompiledName "quinscape">]Quinscape
    | [<CompiledName "quora">]Quora
    | [<CompiledName "ravelry">]Ravelry
    | [<CompiledName "react">]React
    | [<CompiledName "rebel">]Rebel
    | [<CompiledName "redriver">]Redriver
    | [<CompiledName "reddit">]Reddit
    | [<CompiledName "reddit alien">]RedditAlien
    | [<CompiledName "reddit square">]RedditSquare
    | [<CompiledName "rendact">]Rendact
    | [<CompiledName "renren">]Renren
    | [<CompiledName "replyd">]Replyd
    | [<CompiledName "resolving">]Resolving
    | [<CompiledName "rocketchat">]Rocketchat
    | [<CompiledName "rockrms">]Rockrms
    | [<CompiledName "safari">]Safari
    | [<CompiledName "sass">]Sass
    | [<CompiledName "schlix">]Schlix
    | [<CompiledName "scribd">]Scribd
    | [<CompiledName "searchengin">]Searchengin
    | [<CompiledName "sellcast">]Sellcast
    | [<CompiledName "sellsy">]Sellsy
    | [<CompiledName "servicestack">]Servicestack
    | [<CompiledName "shirtsinbulk">]Shirtsinbulk
    | [<CompiledName "simplybuilt">]Simplybuilt
    | [<CompiledName "sistrix">]Sistrix
    | [<CompiledName "skyatlas">]Skyatlas
    | [<CompiledName "skype">]Skype
    | [<CompiledName "slack">]Slack
    | [<CompiledName "slack hash">]SlackHash
    | [<CompiledName "slideshare">]Slideshare
    | [<CompiledName "snapchat">]Snapchat
    | [<CompiledName "snapchat ghost">]SnapchatGhost
    | [<CompiledName "snapchat square">]SnapchatSquare
    | [<CompiledName "soundcloud">]Soundcloud
    | [<CompiledName "speakap">]Speakap
    | [<CompiledName "spotify">]Spotify
    | [<CompiledName "stack exchange">]StackExchange
    | [<CompiledName "stack overflow">]StackOverflow
    | [<CompiledName "staylinked">]Staylinked
    | [<CompiledName "steam">]Steam
    | [<CompiledName "steam square">]SteamSquare
    | [<CompiledName "steam symbol">]SteamSymbol
    | [<CompiledName "sticker mule">]StickerMule
    | [<CompiledName "strava">]Strava
    | [<CompiledName "stripe">]Stripe
    | [<CompiledName "stripe s">]StripeS
    | [<CompiledName "studiovinari">]Studiovinari
    | [<CompiledName "stumbleupon">]Stumbleupon
    | [<CompiledName "stumbleupon circle">]StumbleuponCircle
    | [<CompiledName "superpowers">]Superpowers
    | [<CompiledName "supple">]Supple
    | [<CompiledName "telegram">]Telegram
    | [<CompiledName "telegram plane">]TelegramPlane
    | [<CompiledName "tencent weibo">]TencentWeibo
    | [<CompiledName "themeisle">]Themeisle
    | [<CompiledName "trello">]Trello
    | [<CompiledName "tripadvisor">]Tripadvisor
    | [<CompiledName "tumblr">]Tumblr
    | [<CompiledName "tumblr square">]TumblrSquare
    | [<CompiledName "twitch">]Twitch
    | [<CompiledName "twitter">]Twitter
    | [<CompiledName "twitter square">]TwitterSquare
    | [<CompiledName "typo3">]Typo3
    | [<CompiledName "uber">]Uber
    | [<CompiledName "uikit">]Uikit
    | [<CompiledName "uniregistry">]Uniregistry
    | [<CompiledName "untappd">]Untappd
    | [<CompiledName "usb">]Usb
    | [<CompiledName "ussunnah">]Ussunnah
    | [<CompiledName "vaadin">]Vaadin
    | [<CompiledName "viacoin">]Viacoin
    | [<CompiledName "viadeo">]Viadeo
    | [<CompiledName "viadeo square">]ViadeoSquare
    | [<CompiledName "viber">]Viber
    | [<CompiledName "vimeo">]Vimeo
    | [<CompiledName "vimeo square">]VimeoSquare
    | [<CompiledName "vimeo v">]VimeoV
    | [<CompiledName "vine">]Vine
    | [<CompiledName "vk">]Vk
    | [<CompiledName "vnv">]Vnv
    | [<CompiledName "vuejs">]Vuejs
    | [<CompiledName "weibo">]Weibo
    | [<CompiledName "weixin">]Weixin
    | [<CompiledName "whatsapp">]Whatsapp
    | [<CompiledName "whatsapp square">]WhatsappSquare
    | [<CompiledName "whmcs">]Whmcs
    | [<CompiledName "wikipedia w">]WikipediaW
    | [<CompiledName "windows">]Windows
    | [<CompiledName "wordpress">]Wordpress
    | [<CompiledName "wordpress simple">]WordpressSimple
    | [<CompiledName "wpbeginner">]Wpbeginner
    | [<CompiledName "wpexplorer">]Wpexplorer
    | [<CompiledName "wpforms">]Wpforms
    | [<CompiledName "xbox">]Xbox
    | [<CompiledName "xing">]Xing
    | [<CompiledName "xing square">]XingSquare
    | [<CompiledName "y combinator">]YCombinator
    | [<CompiledName "yahoo">]Yahoo
    | [<CompiledName "yandex">]Yandex
    | [<CompiledName "yandex international">]YandexInternational
    | [<CompiledName "yelp">]Yelp
    | [<CompiledName "yoast">]Yoast
    | [<CompiledName "youtube">]Youtube
    | [<CompiledName "youtube square">]YoutubeSquare
    | [<CompiledName "chess rock">]ChessRock
    | [<CompiledName "ordered list">]OrderedList
    | [<CompiledName "unordered list">]UnorderedList
    | [<CompiledName "user doctor">]UserDoctor
    | [<CompiledName "shield">]Shield
    | [<CompiledName "puzzle">]Puzzle
    | [<CompiledName "cc amazon pay">]CcAmazonPay
    | [<CompiledName "cc diners club">]CcDinersClub
    | [<CompiledName "cc discover">]CcDiscover
    | [<CompiledName "cc jcb">]CcJcb
    | [<CompiledName "cc mastercard">]CcMastercard
    | [<CompiledName "cc paypal">]CcPaypal
    | [<CompiledName "cc stripe">]CcStripe
    | [<CompiledName "cc visa">]CcVisa
    | [<CompiledName "add circle">]AddCircle
    | [<CompiledName "add square">]AddSquare
    | [<CompiledName "add to calendar">]AddToCalendar
    | [<CompiledName "add to cart">]AddToCart
    | [<CompiledName "add user">]AddUser
    | [<CompiledName "add">]Add
    | [<CompiledName "alarm mute">]AlarmMute
    | [<CompiledName "alarm">]Alarm
    | [<CompiledName "ald">]Ald
    | [<CompiledName "als">]Als
    | [<CompiledName "cc amex">]CcAmex
    | [<CompiledName "announcement">]Announcement
    | [<CompiledName "area chart">]AreaChart
    | [<CompiledName "area graph">]AreaGraph
    | [<CompiledName "arrow down cart">]ArrowDownCart
    | [<CompiledName "asexual">]Asexual
    | [<CompiledName "asl interpreting">]AslInterpreting
    | [<CompiledName "asl">]Asl
    | [<CompiledName "assistive listening devices">]AssistiveListeningDevices
    | [<CompiledName "attach">]Attach
    | [<CompiledName "attention">]Attention
    | [<CompiledName "balance">]Balance
    | [<CompiledName "bar">]Bar
    | [<CompiledName "bathtub">]Bathtub
    | [<CompiledName "battery four">]BatteryFour
    | [<CompiledName "battery high">]BatteryHigh
    | [<CompiledName "battery low">]BatteryLow
    | [<CompiledName "battery one">]BatteryOne
    | [<CompiledName "battery three">]BatteryThree
    | [<CompiledName "battery two">]BatteryTwo
    | [<CompiledName "battery zero">]BatteryZero
    | [<CompiledName "birthday">]Birthday
    | [<CompiledName "block layout">]BlockLayout
    | [<CompiledName "bluetooth alternative">]BluetoothAlternative
    | [<CompiledName "broken chain">]BrokenChain
    | [<CompiledName "browser">]Browser
    | [<CompiledName "call square">]CallSquare
    | [<CompiledName "call">]Call
    | [<CompiledName "cancel">]Cancel
    | [<CompiledName "cart">]Cart
    | [<CompiledName "cc">]Cc
    | [<CompiledName "chain">]Chain
    | [<CompiledName "chat">]Chat
    | [<CompiledName "checked calendar">]CheckedCalendar
    | [<CompiledName "checkmark">]Checkmark
    | [<CompiledName "circle notched">]CircleNotched
    | [<CompiledName "close">]Close
    | [<CompiledName "cny">]Cny
    | [<CompiledName "cocktail">]Cocktail
    | [<CompiledName "commenting">]Commenting
    | [<CompiledName "computer">]Computer
    | [<CompiledName "configure">]Configure
    | [<CompiledName "content">]Content
    | [<CompiledName "deafness">]Deafness
    | [<CompiledName "delete calendar">]DeleteCalendar
    | [<CompiledName "delete">]Delete
    | [<CompiledName "detective">]Detective
    | [<CompiledName "discussions">]Discussions
    | [<CompiledName "doctor">]Doctor
    | [<CompiledName "dollar">]Dollar
    | [<CompiledName "dont">]Dont
    | [<CompiledName "drivers license">]DriversLicense
    | [<CompiledName "dropdown">]Dropdown
    | [<CompiledName "emergency">]Emergency
    | [<CompiledName "envira gallery">]EnviraGallery
    | [<CompiledName "erase">]Erase
    | [<CompiledName "eur">]Eur
    | [<CompiledName "euro">]Euro
    | [<CompiledName "eyedropper">]Eyedropper
    | [<CompiledName "factory">]Factory
    | [<CompiledName "favorite">]Favorite
    | [<CompiledName "feed">]Feed
    | [<CompiledName "female homosexual">]FemaleHomosexual
    | [<CompiledName "file text">]FileText
    | [<CompiledName "file text outline">]FileTextOutline
    | [<CompiledName "find">]Find
    | [<CompiledName "first aid">]FirstAid
    | [<CompiledName "fork">]Fork
    | [<CompiledName "game">]Game
    | [<CompiledName "gay">]Gay
    | [<CompiledName "gbp">]Gbp
    | [<CompiledName "google plus circle">]GooglePlusCircle
    | [<CompiledName "google plus official">]GooglePlusOfficial
    | [<CompiledName "grab">]Grab
    | [<CompiledName "graduation">]Graduation
    | [<CompiledName "grid layout">]GridLayout
    | [<CompiledName "group">]Group
    | [<CompiledName "h">]H
    | [<CompiledName "hand victory">]HandVictory
    | [<CompiledName "handicap">]Handicap
    | [<CompiledName "hard of hearing">]HardOfHearing
    | [<CompiledName "header">]Header
    | [<CompiledName "help circle">]HelpCircle
    | [<CompiledName "help">]Help
    | [<CompiledName "heterosexual">]Heterosexual
    | [<CompiledName "hide">]Hide
    | [<CompiledName "hotel">]Hotel
    | [<CompiledName "hourglass four">]HourglassFour
    | [<CompiledName "hourglass full">]HourglassFull
    | [<CompiledName "hourglass one">]HourglassOne
    | [<CompiledName "hourglass three">]HourglassThree
    | [<CompiledName "hourglass two">]HourglassTwo
    | [<CompiledName "idea">]Idea
    | [<CompiledName "ils">]Ils
    | [<CompiledName "in cart">]InCart
    | [<CompiledName "inr">]Inr
    | [<CompiledName "intergender">]Intergender
    | [<CompiledName "intersex">]Intersex
    | [<CompiledName "jpy">]Jpy
    | [<CompiledName "krw">]Krw
    | [<CompiledName "lab">]Lab
    | [<CompiledName "law">]Law
    | [<CompiledName "legal">]Legal
    | [<CompiledName "lesbian">]Lesbian
    | [<CompiledName "lightning">]Lightning
    | [<CompiledName "like">]Like
    | [<CompiledName "line graph">]LineGraph
    | [<CompiledName "linkedin square">]LinkedinSquare
    | [<CompiledName "linkify">]Linkify
    | [<CompiledName "lira">]Lira
    | [<CompiledName "list layout">]ListLayout
    | [<CompiledName "magnify">]Magnify
    | [<CompiledName "mail forward">]MailForward
    | [<CompiledName "mail square">]MailSquare
    | [<CompiledName "mail">]Mail
    | [<CompiledName "male homosexual">]MaleHomosexual
    | [<CompiledName "man">]Man
    | [<CompiledName "marker">]Marker
    | [<CompiledName "mars alternate">]MarsAlternate
    | [<CompiledName "mars horizontal">]MarsHorizontal
    | [<CompiledName "mars vertical">]MarsVertical
    | [<CompiledName "microsoft edge">]MicrosoftEdge
    | [<CompiledName "military">]Military
    | [<CompiledName "ms edge">]MsEdge
    | [<CompiledName "mute">]Mute
    | [<CompiledName "new pied piper">]NewPiedPiper
    | [<CompiledName "non binary transgender">]NonBinaryTransgender
    | [<CompiledName "numbered list">]NumberedList
    | [<CompiledName "optinmonster">]Optinmonster
    | [<CompiledName "options">]Options
    | [<CompiledName "other gender horizontal">]OtherGenderHorizontal
    | [<CompiledName "other gender vertical">]OtherGenderVertical
    | [<CompiledName "other gender">]OtherGender
    | [<CompiledName "payment">]Payment
    | [<CompiledName "paypal card">]PaypalCard
    | [<CompiledName "pencil square">]PencilSquare
    | [<CompiledName "photo">]Photo
    | [<CompiledName "picture">]Picture
    | [<CompiledName "pie chart">]PieChart
    | [<CompiledName "pie graph">]PieGraph
    | [<CompiledName "pied piper hat">]PiedPiperHat
    | [<CompiledName "pin">]Pin
    | [<CompiledName "plus cart">]PlusCart
    | [<CompiledName "point">]Point
    | [<CompiledName "pointing down">]PointingDown
    | [<CompiledName "pointing left">]PointingLeft
    | [<CompiledName "pointing right">]PointingRight
    | [<CompiledName "pointing up">]PointingUp
    | [<CompiledName "pound">]Pound
    | [<CompiledName "power cord">]PowerCord
    | [<CompiledName "power">]Power
    | [<CompiledName "privacy">]Privacy
    | [<CompiledName "r circle">]RCircle
    | [<CompiledName "rain">]Rain
    | [<CompiledName "record">]Record
    | [<CompiledName "refresh">]Refresh
    | [<CompiledName "remove circle">]RemoveCircle
    | [<CompiledName "remove from calendar">]RemoveFromCalendar
    | [<CompiledName "remove user">]RemoveUser
    | [<CompiledName "remove">]Remove
    | [<CompiledName "repeat">]Repeat
    | [<CompiledName "rmb">]Rmb
    | [<CompiledName "rouble">]Rouble
    | [<CompiledName "rub">]Rub
    | [<CompiledName "ruble">]Ruble
    | [<CompiledName "rupee">]Rupee
    | [<CompiledName "s15">]S15
    | [<CompiledName "selected radio">]SelectedRadio
    | [<CompiledName "send">]Send
    | [<CompiledName "setting">]Setting
    | [<CompiledName "settings">]Settings
    | [<CompiledName "shekel">]Shekel
    | [<CompiledName "sheqel">]Sheqel
    | [<CompiledName "shipping">]Shipping
    | [<CompiledName "shop">]Shop
    | [<CompiledName "shuffle">]Shuffle
    | [<CompiledName "shutdown">]Shutdown
    | [<CompiledName "sidebar">]Sidebar
    | [<CompiledName "signing">]Signing
    | [<CompiledName "signup">]Signup
    | [<CompiledName "sliders">]Sliders
    | [<CompiledName "soccer">]Soccer
    | [<CompiledName "sort alphabet ascending">]SortAlphabetAscending
    | [<CompiledName "sort alphabet descending">]SortAlphabetDescending
    | [<CompiledName "sort ascending">]SortAscending
    | [<CompiledName "sort content ascending">]SortContentAscending
    | [<CompiledName "sort content descending">]SortContentDescending
    | [<CompiledName "sort descending">]SortDescending
    | [<CompiledName "sort numeric ascending">]SortNumericAscending
    | [<CompiledName "sort numeric descending">]SortNumericDescending
    | [<CompiledName "sound">]Sound
    | [<CompiledName "spy">]Spy
    | [<CompiledName "stripe card">]StripeCard
    | [<CompiledName "student">]Student
    | [<CompiledName "talk">]Talk
    | [<CompiledName "target">]Target
    | [<CompiledName "teletype">]Teletype
    | [<CompiledName "television">]Television
    | [<CompiledName "text cursor">]TextCursor
    | [<CompiledName "text telephone">]TextTelephone
    | [<CompiledName "theme">]Theme
    | [<CompiledName "thermometer">]Thermometer
    | [<CompiledName "thumb tack">]ThumbTack
    | [<CompiledName "time">]Time
    | [<CompiledName "tm">]Tm
    | [<CompiledName "toggle down">]ToggleDown
    | [<CompiledName "toggle left">]ToggleLeft
    | [<CompiledName "toggle right">]ToggleRight
    | [<CompiledName "toggle up">]ToggleUp
    | [<CompiledName "translate">]Translate
    | [<CompiledName "travel">]Travel
    | [<CompiledName "treatment">]Treatment
    | [<CompiledName "triangle down">]TriangleDown
    | [<CompiledName "triangle left">]TriangleLeft
    | [<CompiledName "triangle right">]TriangleRight
    | [<CompiledName "triangle up">]TriangleUp
    | [<CompiledName "try">]Try
    | [<CompiledName "unhide">]Unhide
    | [<CompiledName "unlinkify">]Unlinkify
    | [<CompiledName "unmute">]Unmute
    | [<CompiledName "usd">]Usd
    | [<CompiledName "user cancel">]UserCancel
    | [<CompiledName "user close">]UserClose
    | [<CompiledName "user delete">]UserDelete
    | [<CompiledName "user x">]UserX
    | [<CompiledName "vcard">]Vcard
    | [<CompiledName "video camera">]VideoCamera
    | [<CompiledName "video play">]VideoPlay
    | [<CompiledName "volume control phone">]VolumeControlPhone
    | [<CompiledName "wait">]Wait
    | [<CompiledName "warning circle">]WarningCircle
    | [<CompiledName "warning sign">]WarningSign
    | [<CompiledName "warning">]Warning
    | [<CompiledName "wi-fi">]WiFi
    | [<CompiledName "winner">]Winner
    | [<CompiledName "wizard">]Wizard
    | [<CompiledName "woman">]Woman
    | [<CompiledName "won">]Won
    | [<CompiledName "wordpress beginner">]WordpressBeginner
    | [<CompiledName "wordpress forms">]WordpressForms
    | [<CompiledName "world">]World
    | [<CompiledName "write square">]WriteSquare
    | [<CompiledName "x">]X
    | [<CompiledName "yen">]Yen
    | [<CompiledName "zip">]Zip
    | [<CompiledName "zoom in">]ZoomIn
    | [<CompiledName "zoom out">]ZoomOut
    | [<CompiledName "zoom">]Zoom
    | [<CompiledName "bitbucket square">]BitbucketSquare
    | [<CompiledName "checkmark box">]CheckmarkBox
    | [<CompiledName "circle thin">]CircleThin
    | [<CompiledName "cloud download">]CloudDownload
    | [<CompiledName "cloud upload">]CloudUpload
    | [<CompiledName "compose">]Compose
    | [<CompiledName "conversation">]Conversation
    | [<CompiledName "credit card alternative">]CreditCardAlternative
    | [<CompiledName "currency">]Currency
    | [<CompiledName "dashboard">]Dashboard
    | [<CompiledName "diamond">]Diamond
    | [<CompiledName "disk">]Disk
    | [<CompiledName "exchange">]Exchange
    | [<CompiledName "external share">]ExternalShare
    | [<CompiledName "external square">]ExternalSquare
    | [<CompiledName "external">]External
    | [<CompiledName "facebook official">]FacebookOfficial
    | [<CompiledName "food">]Food
    | [<CompiledName "hourglass zero">]HourglassZero
    | [<CompiledName "level down">]LevelDown
    | [<CompiledName "level up">]LevelUp
    | [<CompiledName "log out">]LogOut
    | [<CompiledName "meanpath">]Meanpath
    | [<CompiledName "money">]Money
    | [<CompiledName "move">]Move
    | [<CompiledName "pencil">]Pencil
    | [<CompiledName "protect">]Protect
    | [<CompiledName "radio">]Radio
    | [<CompiledName "remove bookmark">]RemoveBookmark
    | [<CompiledName "resize horizontal">]ResizeHorizontal
    | [<CompiledName "resize vertical">]ResizeVertical
    | [<CompiledName "sign in">]SignIn
    | [<CompiledName "sign out">]SignOut
    | [<CompiledName "spoon">]Spoon
    | [<CompiledName "star half empty">]StarHalfEmpty
    | [<CompiledName "star half full">]StarHalfFull
    | [<CompiledName "ticket">]Ticket
    | [<CompiledName "times rectangle">]TimesRectangle
    | [<CompiledName "write">]Write
    | [<CompiledName "youtube play">]YoutubePlay
    with interface IIcon

[<Erase>]
type CustomIcon  =
    | CustomIcon of string
    with interface IIcon