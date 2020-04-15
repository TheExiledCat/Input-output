using Godot;
using System;

public class Mana : StaticBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public void GiveMana(){
        GetNode<Player>("../Player").mana++;
        GetNode<Sprite>("Sprite").Visible=false;
        GetNode<CollisionShape2D>("CollisionShape2D").Disabled=true;
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
