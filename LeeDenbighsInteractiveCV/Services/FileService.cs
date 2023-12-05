using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeeDenbighsInteractiveCV.Services
{
    public class FileService
    {
        /// <summary>
        /// Reads text from a file given its relative path.
        /// </summary>
        /// <param name="relativeStringPath">The relative path of the file.</param>
        /// <returns>The content of the file as a string, or an error message if an exception occurs.</returns>
        public string ReadTextFromFile(string relativeStringPath)
        {
			try
			{
                // Combine the base directory of the current application domain with the relative path to get the full file path
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeStringPath);
                // Read all text from the file and return it
                return File.ReadAllText(filePath);
			}
			catch (Exception ex)
			{
                // If an exception occurs during file reading, return an error message
                return $"Error loading file: {ex.Message}";
			}
        }
    }
}
