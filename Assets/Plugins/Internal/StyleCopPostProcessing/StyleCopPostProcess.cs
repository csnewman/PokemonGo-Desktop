// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Error22" file="StyleCopPostProcess.cs">
//   Copyright (c) 2016 Error22 All Rights Reserved. 
//   See License.txt for License Information.
// </copyright>
// <summary>
//   Defines the behavior of the StyleCop Post Process step:
//   When files are added or removed to the unity project, this checks if the files are to be added to the StyleCop Settings
//   file such that internally authored files follow the correct formatting rules.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

using System.IO;
using System.Linq;
using System.Xml;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Defines the behavior of the StyleCop Post Process step:
/// When files are added or removed to the unity project, this checks if the files are to be added to the StyleCop Settings
/// file such that internally authored files follow the correct formatting rules.
/// </summary>
public class StyleCopPostProcess : AssetPostprocessor
{
	#region Static Fields and Constants

	/// <summary>
	/// The stylecop filename.
	/// </summary>
	private const string StylecopFilename = "Settings.StyleCop";

	/// <summary>
	/// The ignored directories.
	/// </summary>
	private static readonly string[] IgnoredDirectories = { "POGOProtos", "SimpleCoroutines" };

	#endregion

	#region  Methods - Private

	/// <summary>
	/// The on post-process all assets.
	/// </summary>
	/// <param name="importedAssets">
	/// The imported assets.
	/// </param>
	/// <param name="deletedAssets">
	/// The deleted assets.
	/// </param>
	/// <param name="movedAssets">
	/// The moved assets.
	/// </param>
	/// <param name="movedFromAssetPaths">
	/// The moved from asset paths.
	/// </param>
	private static void OnPostprocessAllAssets(
		string[] importedAssets,
		string[] deletedAssets,
		string[] movedAssets,
		string[] movedFromAssetPaths)
	{
		AddressSourceCodeChangesForStylecop(importedAssets, deletedAssets);
	}

	/// <summary>
	/// The address source code changes for stylecop.
	/// </summary>
	/// <param name="importedSourceFiles">
	/// The imported source files.
	/// </param>
	/// <param name="deletedSourceFiles">
	/// The deleted source files.
	/// </param>
	private static void AddressSourceCodeChangesForStylecop(string[] importedSourceFiles, string[] deletedSourceFiles)
	{
		if (!importedSourceFiles.Any(s => s.EndsWith(".cs")) && !deletedSourceFiles.Any(s => s.EndsWith(".cs")))
		{
			return;
		}

		var stylecopFilePath = Directory.GetCurrentDirectory() + "\\" + StylecopFilename;

		XmlDocument stylecopSettingsDocument = GetStylecopSettingsXmlDocument(stylecopFilePath);

		string[] incomingSourceFiles = importedSourceFiles.Where(s => s.EndsWith(".cs")).ToArray();
		string[] removedSourceFiles = deletedSourceFiles.Where(s => s.EndsWith(".cs")).ToArray();

		CheckIfStylecopDocumentFormatIsCorrect(ref stylecopSettingsDocument);

		AddSourceFilesToStyleCopSettings(ref stylecopSettingsDocument, incomingSourceFiles);
		RemoveSourceFilesFromStylecopSettings(ref stylecopSettingsDocument, removedSourceFiles);

		stylecopSettingsDocument.Save(stylecopFilePath);
	}

	/// <summary>
	/// The add source files to style cop settings.
	/// </summary>
	/// <param name="xmlDocument">
	/// The xml document.
	/// </param>
	/// <param name="newSourceFiles">
	/// The new source files.
	/// </param>
	private static void AddSourceFilesToStyleCopSettings(ref XmlDocument xmlDocument, string[] newSourceFiles)
	{
		if (xmlDocument.DocumentElement == null)
		{
			return;
		}

		var sourceFileList = xmlDocument.DocumentElement.SelectSingleNode("SourceFileList");
		if (sourceFileList == null)
		{
			return;
		}

		foreach (var file in newSourceFiles)
		{
			var fileInfo = new FileInfo(file);

			if (CheckIfPathContainsIgnoredFolders(file))
			{
				continue;
			}

			if (sourceFileList.SelectSingleNode("SourceFile[text()='" + fileInfo.Name + "']") != null)
			{
				continue;
			}

			var newSourceFileElement = xmlDocument.CreateElement("SourceFile");
			newSourceFileElement.InnerText = fileInfo.Name;
			sourceFileList.AppendChild(newSourceFileElement);
		}
	}

	/// <summary>
	/// The remove source files from stylecop settings.
	/// </summary>
	/// <param name="xmlDocument">
	/// The xml document.
	/// </param>
	/// <param name="removedSourceFiles">
	/// The removed source files.
	/// </param>
	private static void RemoveSourceFilesFromStylecopSettings(ref XmlDocument xmlDocument, string[] removedSourceFiles)
	{
		if (xmlDocument.DocumentElement == null)
		{
			return;
		}

		var sourceFileList = xmlDocument.DocumentElement.SelectSingleNode("SourceFileList");
		if (sourceFileList == null)
		{
			return;
		}

		foreach (var file in removedSourceFiles)
		{
			var fileInfo = new FileInfo(file);
			var nodeToRemove = sourceFileList.SelectSingleNode("SourceFile[text()='" + fileInfo.Name + "']");
			if (nodeToRemove == null)
			{
				continue;
			}

			sourceFileList.RemoveChild(nodeToRemove);
		}
	}

	/// <summary>
	/// The get stylecop settings xml document.
	/// </summary>
	/// <param name="settingsFilePath">
	/// The settings file path.
	/// </param>
	/// <returns>
	/// The <see cref="XmlDocument"/>.
	/// </returns>
	private static XmlDocument GetStylecopSettingsXmlDocument(string settingsFilePath)
	{
		var xmlDocument = new XmlDocument();
		xmlDocument.Load(settingsFilePath);
		return xmlDocument;
	}

	/// <summary>
	/// The check if stylecop document format is correct.
	/// </summary>
	/// <param name="xmlDocument">
	/// The xml document.
	/// </param>
	/// <returns>
	/// The <see cref="bool"/>.
	/// </returns>
	private static bool CheckIfStylecopDocumentFormatIsCorrect(ref XmlDocument xmlDocument)
	{
		if (xmlDocument.DocumentElement == null ||
		    xmlDocument.DocumentElement.SelectSingleNode(
			    "SourceFileList/Settings/GlobalSettings/BooleanProperty[@Name='RulesEnabledByDefault']") == null)
		{
			Debug.LogWarning(
				"The Project's StyleCop settings file is missing the expected custom SourceFileList settings. Fix the Settings.StyleCop file before continuing!");
			return false;
		}

		return true;
	}

	/// <summary>
	/// The check if path contains ignored folders.
	/// </summary>
	/// <param name="filePath">
	/// The file path.
	/// </param>
	/// <returns>
	/// The <see cref="bool"/>.
	/// </returns>
	private static bool CheckIfPathContainsIgnoredFolders(string filePath)
	{
		return IgnoredDirectories.Aggregate(false, (current, directory) => current | filePath.Contains(directory));
	}

	#endregion
}