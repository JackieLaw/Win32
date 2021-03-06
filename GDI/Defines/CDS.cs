﻿using System;

namespace Win32
{
	/// <summary>
	/// Specifies flags for <see cref="O:Win32.DisplayMode.ChangeDisplaySettings">DisplayMode.ChangeDisplaySettings</see> and
	/// <see cref="O:Win32.DisplayMode.ChangeDisplaySettingsEx">DisplayMode.ChangeDisplaySettingsEx</see>.
	/// </summary>
	[Flags]
	public enum CDS : uint
	{
		/// <summary>
		/// The graphics mode for the current screen will be changed dynamically.
		/// </summary>
		NONE=0,

		/// <summary>
		/// The graphics mode for the current screen will be changed dynamically and the graphics mode will be updated in the registry. The mode information is stored in the USER profile.
		/// </summary>
		UPDATEREGISTRY=0x00000001,

		/// <summary>
		/// The system tests if the requested graphics mode could be set.
		/// </summary>
		TEST=0x00000002,

		/// <summary>
		/// The mode is temporary in nature.
		/// If you change to and from another desktop, this mode will not be reset.
		/// </summary>
		FULLSCREEN=0x00000004,

		/// <summary>
		/// The settings will be saved in the global settings area so that they will affect all users on the machine. Otherwise, only the settings for the user are modified. This flag is only valid when specified with the <see cref="UPDATEREGISTRY"/> flag.
		/// </summary>
		GLOBAL=0x00000008,

		/// <summary>
		/// This device will become the primary device.
		/// </summary>
		SET_PRIMARY=0x00000010,

		/// <summary>
		/// When set, the <c>lParam</c> parameter of <see cref="O:Win32.DisplayMode.ChangeDisplaySettingsEx">DisplayMode.ChangeDisplaySettingsEx</see> is a pointer to a <see cref="VideoParameters"/> structure.
		/// </summary>
		VIDEOPARAMETERS=0x00000020,

		/// <summary>
		/// Enables settings changes to unsafe graphics modes.
		/// </summary>
		ENABLE_UNSAFE_MODES=0x00000100,

		/// <summary>
		/// Disables settings changes to unsafe graphics modes.
		/// </summary>
		DISABLE_UNSAFE_MODES=0x00000200,

		/// <summary>
		/// The settings should be changed, even if the requested settings are the same as the current settings.
		/// </summary>
		RESET=0x40000000,

		/// <summary>
		/// The settings should be changed, even if the requested settings are the same as the current settings.
		/// </summary>
		RESET_EX=0x20000000,

		/// <summary>
		/// The settings will be saved in the registry, but will not take effect. This flag is only valid when specified with the <see cref="UPDATEREGISTRY"/> flag.
		/// </summary>
		NORESET=0x10000000,
	}
}
