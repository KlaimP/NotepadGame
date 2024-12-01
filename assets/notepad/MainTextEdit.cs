using Godot;
using System;

public partial class MainTextEdit : TextEdit
{
	[Export]
	public RichTextLabel editLabel;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}
	public void Use(RichTextLabel sender)
	{
		this.Text = sender.Text;
		editLabel = sender;
		DisplayServer.VirtualKeyboardShow(sender.Text);
		this.GrabFocus();
		OS.DelayMsec(300);
		GD.Print(this.Size.Y);
		int keyboardSize = DisplayServer.VirtualKeyboardGetHeight();
		this.Position = new Vector2(30, DisplayServer.ScreenGetSize().Y - keyboardSize - this.Size.Y);
		this.Position = new Vector2(30, DisplayServer.ScreenGetSize().Y - keyboardSize - this.Size.Y);
		GD.Print(this.Size.Y);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	public void _on_text_changed()
	{
		if (editLabel == null)
		{
			GD.Print("Editable label not found");
			return;
		}
		editLabel.Text = this.Text;
		int keyboardSize = DisplayServer.VirtualKeyboardGetHeight();
		this.Position = new Vector2(30, DisplayServer.ScreenGetSize().Y - keyboardSize - this.Size.Y);
		this.Position = new Vector2(30, DisplayServer.ScreenGetSize().Y - keyboardSize - this.Size.Y);
	}
}
