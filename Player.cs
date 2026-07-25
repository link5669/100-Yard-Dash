using Godot;
using System;

public partial class Player : Area2D {
	[Export]
	public int Speed { get; set; } = 400; 
	public Vector2 ScreenSize; 

	public override void _Ready() {
		ScreenSize = GetViewportRect().Size;
	}

	public override void _Process(double delta) {
		if (Input.IsActionPressed("jump_one")) {
			
		}
		if (Input.IsActionPressed("jump_two")) {
			
		}
	}
}
