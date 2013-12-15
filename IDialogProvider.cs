using System;

namespace Plugin
{
	/// <summary>
	/// An interface for file dialog services.
	/// Allows the 'Main Window' to handle the file dialogs for the view-model.
	/// </summary>
	public interface IDialogProvider
	{
		/// <summary>
		/// Display an error message dialog box.
		/// </summary>
		void ErrorMessage(string msg);
	}
}
