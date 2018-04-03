﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using BizHawk.Common;
using BizHawk.Emulation.Common;

namespace BizHawk.Emulation.Cores.Nintendo.GBHawk
{
	/// <summary>
	/// Represents a GB add on
	/// </summary>
	public interface IPort
	{
		byte Read(IController c);

		ushort ReadAccX(IController c);

		ushort ReadAccY(IController c);

		ControllerDefinition Definition { get; }

		void SyncState(Serializer ser);

		int PortNum { get; }
	}

	[DisplayName("Gameboy Controller")]
	public class StandardControls : IPort
	{
		public StandardControls(int portNum)
		{
			PortNum = portNum;
			Definition = new ControllerDefinition
			{
				Name = "Gameboy Controller",
				BoolButtons = BaseDefinition
				.Select(b => "P" + PortNum + " " + b)
				.ToList()
			};
		}

		public int PortNum { get; }

		public ControllerDefinition Definition { get; }

		public byte Read(IController c)
		{
			byte result = 0xFF;

			if (c.IsPressed(Definition.BoolButtons[0]))
			{
				result -= 4;
			}
			if (c.IsPressed(Definition.BoolButtons[1]))
			{
				result -= 8;
			}
			if (c.IsPressed(Definition.BoolButtons[2]))
			{
				result -= 2;
			}
			if (c.IsPressed(Definition.BoolButtons[3]))
			{
				result -= 1;
			}
			if (c.IsPressed(Definition.BoolButtons[4]))
			{
				result -= 128;
			}
			if (c.IsPressed(Definition.BoolButtons[5]))
			{
				result -= 64;
			}
			if (c.IsPressed(Definition.BoolButtons[6]))
			{
				result -= 32;
			}
			if (c.IsPressed(Definition.BoolButtons[7]))
			{
				result -= 16;
			}

			return result;
		}

		public ushort ReadAccX(IController c)
		{
			return 0;
		}

		public ushort ReadAccY(IController c)
		{
			return 0;
		}

		private static readonly string[] BaseDefinition =
		{
			"Up", "Down", "Left", "Right", "Start", "Select", "B", "A", "Power"
		};

		public void SyncState(Serializer ser)
		{
			//nothing
		}
	}

	[DisplayName("Gameboy Controller + Kirby")]
	public class StandardKirby : IPort
	{
		public StandardKirby(int portNum)
		{
			PortNum = portNum;
			Definition = new ControllerDefinition
			{
				Name = "Gameboy Controller + Kirby",
				BoolButtons = BaseDefinition
				.Select(b => "P" + PortNum + " " + b)
				.ToList(),
				FloatControls = { "P" + PortNum + " Tilt X", "P" + PortNum + " Tilt Y" },
				FloatRanges = { new[] { -127.0f, 0, 127.0f }, new[] { -127.0f, 0, 127.0f } }
			};
		}

		public int PortNum { get; }

		public ControllerDefinition Definition { get; }

		public byte Read(IController c)
		{
			byte result = 0xFF;

			if (c.IsPressed(Definition.BoolButtons[0]))
			{
				result -= 4;
			}
			if (c.IsPressed(Definition.BoolButtons[1]))
			{
				result -= 8;
			}
			if (c.IsPressed(Definition.BoolButtons[2]))
			{
				result -= 2;
			}
			if (c.IsPressed(Definition.BoolButtons[3]))
			{
				result -= 1;
			}
			if (c.IsPressed(Definition.BoolButtons[4]))
			{
				result -= 128;
			}
			if (c.IsPressed(Definition.BoolButtons[5]))
			{
				result -= 64;
			}
			if (c.IsPressed(Definition.BoolButtons[6]))
			{
				result -= 32;
			}
			if (c.IsPressed(Definition.BoolButtons[7]))
			{
				result -= 16;
			}

			return result;
		}

		public ushort ReadAccX(IController c)
		{
			return 0;
		}

		public ushort ReadAccY(IController c)
		{
			return 0;
		}

		private static readonly string[] BaseDefinition =
		{
			"Up", "Down", "Left", "Right", "Start", "Select", "B", "A", "Power"
		};

		public void SyncState(Serializer ser)
		{
			//nothing
		}
	}
}