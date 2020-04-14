using Godot;
using System;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;
public class Movement : KinematicBody2D
{
	[Export] public int Speed = 200;

	Vector2 velocity = new Vector2();
	//[Export]Vector2[] positions= new Vector2[0];
	public List<Vector2> positions = new List<Vector2>();
	int timer;
	
	public void GetInput()
	{
		velocity = new Vector2();

		if (Input.IsActionPressed("Move right"))
			velocity.x += 1;

		if (Input.IsActionPressed("Move left"))
			velocity.x -= 1;

		if (Input.IsActionPressed("Move Down"))
			velocity.y += 1;

		if (Input.IsActionPressed("Move Up"))
			velocity.y -= 1;

		velocity = velocity.Normalized() * Speed;
	}
	
	public override void _PhysicsProcess(float delta)
	{
		GetInput();
		velocity = MoveAndSlide(velocity);
		if(timer<60){
timer++;	
		}else {
			timer=0;
			RecordPosition();
		}
		
	}
	void RecordPosition(){
		positions.Add(Position);
		if( positions.Count==100){
			            GetTree().ReloadCurrentScene();
		}
			
	}
}
