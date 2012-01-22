using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using Terraria;

namespace RollDice
{
	[APIVersion(1, 11)]
	public class RollDice : TerrariaPlugin
	{
		public override Version Version
		{
			get { return new Version(1, 0); }
		}

		public override string Name
		{
			get { return "Dice Roll"; }
		}

		public override string Author
		{
			get { return "nicatronTg"; }
		}

		public override string Description
		{
			get { return "Roll the magical dice of Random"; }
		}

		public RollDice(Main game) : base(game)
		{
		}

		public override void Initialize()
		{
			TShockAPI.Commands.ChatCommands.Add(new Command("roll", Roll, "roll"));
		}

		public void Roll(CommandArgs args)
		{
			Random r = new Random();
			TShockAPI.TShock.Utils.Broadcast(args.Player.Name + " rolls a " + r.Next(0, 100), Color.Yellow);
		}
	}
}
