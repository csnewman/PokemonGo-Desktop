// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coroutine.cs" company="">
//   
// </copyright>
// <summary>
//   The coroutine.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections;

namespace SimpleCoroutines
{
	/// <summary>
	/// The coroutine.
	/// </summary>
	public class Coroutine
	{
		#region  Fields

		/// <summary>
		/// The _block.
		/// </summary>
		private IEnumerator _block;

		/// <summary>
		/// The _canceled.
		/// </summary>
		private bool _canceled;

		/// <summary>
		/// The _id.
		/// </summary>
		private string _id;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="Coroutine"/> class.
		/// </summary>
		/// <param name="id">
		/// The id.
		/// </param>
		/// <param name="block">
		/// The block.
		/// </param>
		public Coroutine(string id, IEnumerator block)
		{
			this._id = id;
			this._block = block;
			this._canceled = false;
		}

		#endregion

		#region  Methods - Public

		/// <summary>
		/// The cancel.
		/// </summary>
		public void Cancel()
		{
			this._canceled = true;
		}

		/// <summary>
		/// The is canceled.
		/// </summary>
		/// <returns>
		/// The <see cref="bool"/>.
		/// </returns>
		public bool IsCanceled()
		{
			return this._canceled;
		}

		/// <summary>
		/// The set canceled.
		/// </summary>
		/// <param name="can">
		/// The can.
		/// </param>
		public void SetCanceled(bool can)
		{
			this._canceled = can;
		}

		/// <summary>
		/// The get block.
		/// </summary>
		/// <returns>
		/// The <see cref="IEnumerator"/>.
		/// </returns>
		public IEnumerator GetBlock()
		{
			return this._block;
		}

		/// <summary>
		/// The get id.
		/// </summary>
		/// <returns>
		/// The <see cref="string"/>.
		/// </returns>
		public string GetId()
		{
			return this._id;
		}

		#endregion
	}
}