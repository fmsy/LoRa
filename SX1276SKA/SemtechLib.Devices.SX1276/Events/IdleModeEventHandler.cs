﻿using System;
using System.Runtime.InteropServices;

namespace SemtechLib.Devices.SX1276.Events
{
	[ComVisible(true)]
	[Serializable]
	public delegate void IdleModeEventHandler(object sender, IdleModeEventArg e);
}
