module Ambition.GameState

open Ambition.Core
open Ambition.GameState
open System.Collections.Generic

let GameStates: Dictionary<PossibleGameState, GameState> = 
    let dict = new Dictionary<PossibleGameState, GameState>()
    dict.[Intro] <- Intro.GameState
    dict 