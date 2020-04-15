using Godot;
using System;
using System.Collections.Generic;
public class Hologram : Node2D
{
	Player player;
	int  amount;
	public override void _Ready(){
		player=GetNode<Player>("../Player");
	}
	public override void _Process(float delta){
amount=player.amount;
		
		
		if(player.positions.Count>0){
		Vector2 Target;

		Target.x=player.positions[amount].x;
		Target.y=player.positions[amount].y;
		Position=Target;
		}
	   
		
	}
}
