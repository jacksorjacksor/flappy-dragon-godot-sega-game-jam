// Creation largely based on this:
// https://www.youtube.com/watch?v=Kt1njjNGbSg

using Godot;
using System;

public class PlayerNode : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        // KC: cw
        System.Console.WriteLine();
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
