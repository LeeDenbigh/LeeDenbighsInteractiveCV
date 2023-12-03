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
        public string ReadTextFromFile(string relativeStringPath)
        {
			try
			{
				//var assembly = Assembly.GetExecutingAssembly();
				//var resourcePath = relativeStringPath.Replace("/", ".");
				//var fullPath = $"{assembly.GetName().Name}.{resourcePath}";

				//using (Stream stream = assembly.GetManifestResourceStream(fullPath))
				//	using(StreamReader reader = new StreamReader(stream))
				//{
				//	return reader.ReadToEnd();
				//}

				string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeStringPath);
				return File.ReadAllText(filePath);
			}
			catch (Exception ex)
			{
				return $"Error loading file: {ex.Message}";
			}
        }
    }
}
