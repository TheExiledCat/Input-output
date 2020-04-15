using Godot;
using System;
using System.Collections.Generic;
public class Hologram : Node2D
{
	Movement player;
	int  amount;
	public override void _Ready(){
		player=GetNode<Movement>("../Player");
	}
	public override void _Process(float delta){
amount=(int)Mathf.Ceil((float)((player.positions.Count-1)*GetNode<Import>("../../Node2D").number)); 
		
		
		if(player.positions.Count>0){
		Vector2 Target;

		Target.x=player.positions[amount].x;
		Target.y=player.positions[amount].y;
		Position=Target;
		}
	   
		
	}
}
