using Godot;
using System;

public partial class AnimatedSprite2d : AnimatedSprite2D
{
	public override void _Ready() {
	}

	public override void _Process(double delta) {
		if (Input.IsActionPressed("jump_one")) {
			this.Play("jump");
		}
		if (Input.IsActionPressed("jump_two")) {
			
		}
	}
}
