namespace Game

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics

type AmbitionGame() as self = 
    inherit Game()

    let graphics: GraphicsDeviceManager = new GraphicsDeviceManager(self)

    [<DefaultValue>]
    val mutable spritebatch: SpriteBatch

    do 
        self.Content.RootDirectory <- "Content"

    member this.X = "F#"

    override self.Initialize() = 
        base.Initialize()

    override self.LoadContent() =
        self.spritebatch <- new SpriteBatch(self.GraphicsDevice)
        base.LoadContent()

    override self.UnloadContent() = 
        base.UnloadContent() 

    override self.Update(time: GameTime) = 
        base.Update time 
    
    override self.Draw(time: GameTime) = 
        base.GraphicsDevice.Clear Color.DeepSkyBlue
        base.Draw time 
