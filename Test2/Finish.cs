using Godot;
using System;

public class Finish : StaticBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export]Vector2 NextPos;
    [Export]NodePath p;
    Player player;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        player=GetNode<Player>(p);
    }
    public void MovePlayer(){
        player.start=NextPos;
        player.Position=NextPos;
        player.keys=0;
        player.mana=0;
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
