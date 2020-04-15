using Godot;
using Godot.Collections;
using System;
using System.IO.Ports;
using System.Threading;

public class Import : Node2D
{
	public bool running=false;
	

	
   static SerialPort _serialPort;

	public int  number;// dit wordt de %



	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() 
	{		if(running){
 			_serialPort = new SerialPort();
		
			_serialPort.PortName = "COM6";//Set your board COM
			_serialPort.BaudRate = 9600;
			_serialPort.Open();
			
			
	}
		
	}

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
 {
	 if(running){
		 
	  int a = _serialPort.ReadByte();
			
				GD.Print(a);
			  number= a;
		//	}	
				
				
	  }

	
}
}
