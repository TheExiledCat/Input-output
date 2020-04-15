using Godot;
using System;

public class Restart : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Process(float delta)
	{
		if(Input.IsActionPressed("Restart")){
			GetNode<Import>("../../Node2D").running=false;
			GD.Print(GetNode<Import>("../../Node2D").running);			GetTree().ReloadCurrentScene();
			GD.Print("reloading");
		}
	}


}
