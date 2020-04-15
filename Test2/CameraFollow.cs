using Godot;
using System;

public class CameraFollow : Camera2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	
	public Node2D target;
	[Export] public float x ;//=-650;
	 [Export] public float y ;//= 200;

public override void _Ready(){
	target=GetNode<Movement>("../Player");
}

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
	  Vector2 offset;
	  offset.x=x;
	  offset.y=y;
	  Position=target.Position+offset;
 }
}
