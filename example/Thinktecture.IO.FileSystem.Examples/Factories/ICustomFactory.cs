namespace Thinktecture.IO.FileSystem.Examples.Factories
{
	public interface ICustomFactory
	{
		IStreamReader CreateReader(IStream stream);

		IFileInfo CreateFileInfo(string path);
	}
}
