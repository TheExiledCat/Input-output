using Godot;
using System;
using System.IO.Ports;
using System.Threading;

public class Movement : KinematicBody2D
{
	[Export] public int Speed = 200;

	Vector2 velocity = new Vector2();

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
	}
}
