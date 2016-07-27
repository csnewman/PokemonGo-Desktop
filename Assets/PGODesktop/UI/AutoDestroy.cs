// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Error22" file="AutoDestroy.cs">
//   Copyright (c) 2016 Error22 All Rights Reserved. 
//   See License.txt for License Information.
// </copyright>
// <summary>
//   The auto destroy.
// </summary>
//  
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;
using UnityEngine;

/// <summary>
/// The auto destroy.
/// </summary>
public class AutoDestroy : MonoBehaviour
{
	#region  Fields

	/// <summary>
	/// The life.
	/// </summary>
	[SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate",
		Justification = "Reviewed. Suppression is OK here.")] public float Life;

	/// <summary>
	/// The _created.
	/// </summary>
	private float _created;

	#endregion

	#region  Methods - Public

	/// <summary>
	/// The reset time.
	/// </summary>
	public void ResetTime()
	{
		this._created = Time.time;
	}

	#endregion

	#region  Methods - Private

	/// <summary>
	/// The on enable.
	/// </summary>
	private void OnEnable()
	{
		this._created = Time.time;
	}

	/// <summary>
	/// The update.
	/// </summary>
	private void Update()
	{
		if (Time.time - this._created > this.Life)
		{
			this.gameObject.SetActive(false);
		}
	}

	#endregion
}