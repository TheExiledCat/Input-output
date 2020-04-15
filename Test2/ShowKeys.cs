using Godot;
using System;

public class ShowKeys : Label
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Process(float delta)
    {
        Text="Keys: "+GetNode<Player>("../../../Player").keys.ToString()+"  Energy: "+GetNode<Player>("../../../Player").mana.ToString()+"  Time: "+ (100-1-GetNode<Player>("../../../Player").positions.Count).ToString();
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
