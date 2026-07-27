using Godot;
using System;

public partial class Player : Area2D {
	public Vector2 ScreenSize; 

	public override void _Ready() {
		ScreenSize = GetViewportRect().Size;
		this.Position = new Vector2(128,64 + 128);
	}

	public override void _Process(double delta) {
		
	}
}
