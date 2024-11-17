using Godot;
using System;

public partial class AddBlock : Button
{
	[Export]
	MainTextEdit mainTextEdit;
	PackedScene block = (PackedScene)ResourceLoader.Load("res://assets/notepad/blocks/RichTextBox/rich_text_label_editable.tscn");

	[Export]
	Control lastBlock;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void _on_button_button_up()
	{
		GD.Print("Yo");
		Node instance = block.Instantiate();
		if(instance is EditText editText)
		{
			lastBlock.AddSibling(editText);
			editText.mainTextEditObject = mainTextEdit;
			editText.UseObject();
			lastBlock = editText;
		}
	}
}
