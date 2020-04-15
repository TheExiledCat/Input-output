using Godot;
using System;
using System.Collections.Generic;
public class Restart : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	
	// Called when the node enters the scene tree for the first time.

	public override void _Process(float delta)
	{
		if(Input.IsActionPressed("Restart")){
			retry();
		}
	}
	public void retry(){
Player p=GetNode<Player>("../Player");
			p.Position=p.start;
			p.keys=0;
			GD.Print("reloading");
	}

}
