using Godot;
using Godot.Collections;
using System;
using System.IO.Ports;
using System.Threading;

public class Import : Node2D
{
   static SerialPort _serialPort;
private Array<Vector2> PlayerPosition = new Array<Vector2>();
private int time;
private Vector2 Temp;

	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() 
	{		
			 _serialPort = new SerialPort();
			_serialPort.PortName = "COM6";//Set your board COM
			_serialPort.BaudRate = 9600;
			_serialPort.Open();
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
 {
	  string a = _serialPort.ReadExisting();
			
				GD.Print(a);
				
				if(time <= 3){
					Temp = GetNode<KinematicBody2D>("Player").Position;
					PlayerPosition.Add(Temp);
					time++;
				}
				else{
					time = 0;
				}
				
	  }
}
