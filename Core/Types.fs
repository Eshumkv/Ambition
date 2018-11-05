namespace Ambition.Core

open Microsoft.Xna.Framework
open System
open Microsoft.Xna.Framework.Input
open Microsoft.Xna.Framework.Graphics


type Entity = Guid // TODO

type World = Entity list 

type DrawSystemFunction = GameTime -> SpriteBatch -> unit
type UpdateSystemFunction = GameTime -> World 

type System = 
    | DrawSystem of DrawSystemFunction
    | UpdateSystem of UpdateSystemFunction

type GameInput = KeyboardState * GamePadState

type ExternalWorld = GameTime * GameInput 

type InitializationFunction = Game -> World 

type GameState = InitializationFunction * UpdateFunction * System list
and UpdateResult = 
    | Continue of World 
    | ChangeState of GameState 
    | Exit 
and UpdateFunction = ExternalWorld -> World -> UpdateResult 



type PossibleGameState = 
    | Intro
    | MainMenu 