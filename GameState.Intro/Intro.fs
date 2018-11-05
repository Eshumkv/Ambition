module Ambition.GameState.Intro
open Ambition.Core

let init game = []
    
let update ext world = 
    Continue(world)

let systems = []

let GameState: GameState = (init, update, systems)

