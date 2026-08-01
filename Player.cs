using Godot;
using System;

public partial class Player : Area2D {
	public Vector2 ScreenSize; 
	double cooldown = 0.0;
	public override void _Ready() {
		ScreenSize = GetViewportRect().Size;
		this.Position = new Vector2(128,64 + 128);
		this.Visible = true;
	}

	public override void _Process(double delta) {
		cooldown -= delta;
		if (cooldown <= 0.0) {
			if (Input.IsActionPressed("jump_one")) {
				this.Translate(new Vector2(1.1f * (float)delta, 128));
				cooldown = 0.2;
			}
			if (Input.IsActionPressed("jump_two")) {
				this.Translate(new Vector2(1.1f * (float)delta, 256));
				cooldown = 0.2;
			}
		}
	}
}
