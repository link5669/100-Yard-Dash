using Godot;
using System;

public partial class AnimatedSprite2d : AnimatedSprite2D {
	double cooldown = 0.0;
	public override void _Ready() {
	}

	public override void _Process(double delta) {
		cooldown -= delta;
		if (cooldown <= 0.0) {
		if (Input.IsActionPressed("jump_one")) {
			this.SpeedScale = 1.0f;
			this.Play("jump");
			cooldown = 0.2;
		}
		if (Input.IsActionPressed("jump_two")) {
			this.SpeedScale = 0.5f;
			this.Play("jump");
			cooldown = 0.2;
		}}
	}
}
