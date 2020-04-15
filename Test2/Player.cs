using Godot;
using System;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;
public class Player : KinematicBody2D
{
	[Export] public int Speed = 200;

	Vector2 velocity = new Vector2();
	//[Export]Vector2[] positions= new Vector2[0];
	public List<Vector2> positions = new List<Vector2>();
	int timer;
	public Vector2 start;
	public int keys=0;
	public int amount;
	public int mana=0;
	public override void _Ready(){
start=Position;

	}
	public void GetInput()
	{
		velocity = new Vector2();
		if(Input.IsActionPressed("Teleport")&&mana>0){
			Teleport();
		}
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
	void Teleport(){
		Position = GetNode<Hologram>("../Hologram").Position;
		mana--;
	}
	public override void _PhysicsProcess(float delta)
	{
		
		amount= (int)Mathf.Ceil((float)((positions.Count-1)*GetNode<Import>("../../Node2D").number/100)); 
		GetInput();
		KinematicCollision2D col =MoveAndCollide(velocity*delta);
		if(col!=null){//check for collision
			 if(col.Collider.HasMethod("Appear")){
						keys++;
						col.Collider.Call("Dissapear");
			 }
			if(col.Collider.HasMethod("Activate")){
				col.Collider.Call("Activate");
			}
			if(col.Collider.HasMethod("Open")&&keys>0){
				col.Collider.Call("Open");
				keys--;
			}
			if(col.Collider.HasMethod("GiveMana")){
				col.Collider.Call("GiveMana");
			}
			if(col.Collider.HasMethod("MovePlayer")){
				col.Collider.Call("MovePlayer");
			}
		}
		
		//if(MoveAndCollide(velocity*delta).Collider.GetScript().GetClass()=="Key")
			
		
		if(timer<60){
timer++;	
		}else {
			timer=0;
			RecordPosition();
		}
		
	}
	void RecordPosition(){
		
		
			positions.Add(Position);
		
		
		if(positions.Count>100)
		GetNode<Restart>("../Restart").retry();
		GD.Print(positions.Count);
	}
}
