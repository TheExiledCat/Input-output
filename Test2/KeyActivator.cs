using Godot;
using System;

public class KeyActivator : StaticBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export] public NodePath k;
    Key key;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        key=GetNode<Key>(k);
    }
    public void Activate(){
        key.Appear();
        GetNode<Sprite>("Sprite").Visible=false;
        GetNode<CollisionShape2D>("CollisionShape2D").Disabled=true;
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
