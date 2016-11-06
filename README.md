Interfaces for commonly used .NET types like `File`, `Directory`, `Stream`, `Path`, `Math`, `Environment`, etc. for better testability.

* The interfaces have the same API like the .NET types
* .NET Core support

## Usage
Just use the interface like `IFIle` instead of `File`.

```
public class MyClass
{
	private readonly IFile _file;
	
	public MyClass(IFile file)
	{
		_file = file;
	}

	public void MyMethod(string filePath)
	{
		...
		bool exists = _file.Exists(filePath);
		...
	}
}
```

### Usage of static types

The projects containing the interfaces provide adapters (wrappers) that are using the static .NET classes internally.

```
IFile file = new FileAdapter();
```

### Usage of non-static types
Either use the adapters like with *static types* or use the extension methods in namespace `Thinktecture`.

```
FileInfo fileInfo = ...;

IFileInfo fileInfoInterface = fileInfo.ToInterface();
```

If you need back the .NET type i.e. to call a method that does not support the abstrations just call `ToImplementation()`

```
IFileInfo fileInfoInterface = ...

FileInfo fileInfo = fileInfoInterface.ToImplementation();
```

## Projects
The projects are mirroring the .NET assemblies, i.e. if the class `Stream` is in `System.IO.dll` then the interface `IStream` will be in `Thinktecture.IO.Abstractions.dll`.

### Thinktecture.IO.Abstractions
Provides interfaces for types in `System.IO`: `Stream`, `MemoryStream`, `BinaryReader`, `BinaryWriter`, `StreamReader`, `StreamWriter`, `StringReader`, `StringWriter`, `TextReader`, `TextWriter`

**Nuget**: `Install-Package Thinktecture.IO.Abstractions`

### Thinktecture.IO.FileSystem.Abstractions
Provides interfaces for types in `System.IO.FileSystem`: `Directory`, `File`, `FileSystemInfo`, `DirectoryInfo`, `FileInfo`, `FileStream`, `SafeFileHandle`.

**Nuget**: `Install-Package Thinktecture.IO.FileSystem.Abstractions`

### Thinktecture.Runtime.Extensions.Abstractions
Provides interfaces for type in `System.Runtime.Extensions`: `Path`, `BitConverter`, `Convert`, `Environment`, `Math`, `Random`, `UriBuilder`, `Stopwatch`, `WebUtility`

**Nuget**: `Install-Package Thinktecture.Runtime.Extensions.Abstractions`

### Thinktecture.Runtime.Handles.Abstractions
Provides interfaces for types in `System.Runtime.Handles`: `SafeHandle`, `CriticalHandle`, `SafeWaitHandle`

**Nuget**: `Install-Package Thinktecture.Runtime.Handles.Abstractions`