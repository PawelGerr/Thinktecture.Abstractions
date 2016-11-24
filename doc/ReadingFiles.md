[Back to overview](../Readme.md)

# Reading Files

Like with .NET classes from System.IO.* there are multiple options how you can open a file.

> The examples are split into **simple** and **recommended** parts. With the **recommended** part I'm trying to show you approaches that I would take in a real-world project. Alas, you can't generalize what is the best approach because they are project-specific.

## Using IFile (simple)

Use one of the following methods of `IFile` to open a file.

```
public void static Main(string[] args)
{
	IFile file = new FileAdapter();

	var myClass = new MyClass(file);
	myClass.ReadFile_With_OpenText();
}

...

public class MyClass
{
	private const string _EXAMPLE_FILE_PATH = "ReadingFiles/Example.txt";

	private readonly IFile _file;

	public MyClass(IFile file)
	{
		_file = file;
	}

	public void ReadFile_With_OpenText()
	{
		using (IStreamReader reader = _file.OpenText(_EXAMPLE_FILE_PATH))
		{
			string content = reader.ReadToEnd();
			...
		}
	}

	public void ReadFile_With_OpenRead()
	{
		using (IFileStream stream = _file.OpenRead(_EXAMPLE_FILE_PATH))
		using (IStreamReader reader = new StreamReaderAdapter(stream))
		{
			string content = reader.ReadToEnd();
			...
		}
	}

	public void ReadFile_With_Open()
	{
		using (IFileStream stream = _file.Open(_EXAMPLE_FILE_PATH, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (IStreamReader reader = new StreamReaderAdapter(stream))
		{
			string content = reader.ReadToEnd();
			...
		}
	}
}
```

## Using IFileInfo (simple)

Create an instance of `IFileInfo` and use one of the following methods to open a file.

```
public static void Main(string[] args)
{
	var myClass = new MyClass();
	myClass.ReadFile_With_OpenText();
}

...

public class MyClass
{
	private const string _EXAMPLE_FILE_PATH = "ReadingFiles/Example.txt";

	public void ReadFile_With_OpenText()
	{
		IFileInfo fileInfo = new FileInfoAdapter(_EXAMPLE_FILE_PATH);

		using (IStreamReader reader = fileInfo.OpenText())
		{
			string content = reader.ReadToEnd();
			...
		}
	}

	public void ReadFile_With_OpenRead()
	{
		IFileInfo fileInfo = new FileInfoAdapter(_EXAMPLE_FILE_PATH);

		using (IFileStream stream = fileInfo.OpenRead())
		using (IStreamReader reader = new StreamReaderAdapter(stream))
		{
			string content = reader.ReadToEnd();
			...
		}
	}

	public void ReadFile_With_Open()
	{
		IFileInfo fileInfo = new FileInfoAdapter(_EXAMPLE_FILE_PATH);

		using (IFileStream stream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.Read))
		using (IStreamReader reader = new StreamReaderAdapter(stream))
		{
			string content = reader.ReadToEnd();
			...
		}
	}
}
```

## Recommendations

### Don't use constructors directly

Consider creating a project-specific factory that will be responsible for instantiating `IStreamReader` and `IFileInfo`.

```

public interface ICustomFactory
{
	IStreamReader CreateReader(IStream stream);
	IFileInfo CreateFileInfo(string path);
}

public class CustomFactory : ICustomFactory
{
	public IStreamReader CreateReader(IStream stream)
	{
		return new StreamReaderAdapter(stream);
	}

	public IFileInfo CreateFileInfo(string path)
	{
		return new FileInfoAdapter(path);
	}
}

...

public class MyClass
{
	private const string _EXAMPLE_FILE_PATH = "ReadingFiles/Example.txt";

	private readonly IFile _file;
	private readonly ICustomFactory _factory;

	public MyClass(IFile file, ICustomFactory factory)
	{
		_file = file;
		_factory = factory;
	}

	public void ReadFile_With_Open()
	{
		using (IFileStream stream = _file.Open(_EXAMPLE_FILE_PATH, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (IStreamReader reader = _factory.CreateReader(stream))
		{
			string content = reader.ReadToEnd();
			...
		}
	}
}
```

### Consider using higher-level abstractions
Image there is a use case that requires the content of a text file. In this case you should consider to make your own abstraction on top of **Thinktecture.Abstractions** that provides a higher-level abstration.
Let's compare both approaches:

#### Low-Level API

We use `IFile` directly.

```
public void ProcessFile()
{
	using (IFileStream stream = _file.Open(_EXAMPLE_FILE_PATH, FileMode.Open, FileAccess.Read, FileShare.Read))
	using (IStreamReader reader = _factory.CreateReader(stream))
	{
		string content = reader.ReadToEnd();
		// do something with content
	}
}
```

#### Higher-Level Abstraction

At first we implement the higher level-abstraction.

```
public interface IFileSystem 
{
	string GetContent(string path);
}

public class FileSystem : IFileSystem
{
	private readonly IFile _file;

	public ViaFile(IFile file)
	{
		_file = file;
	}

	public string GetContent(string path)
	{
		using (IFileStream stream = _file.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (IStreamReader reader = new StreamReaderAdapter(stream))
		{
			return reader.ReadToEnd();
		}
	}
}
```

Now we can use `IFileSystem` for fetching the file content. 
There are at least two benefits when using this approach. First, it is easier to use. Second, it is easier to test because we don't have to create mocks for `IFile`, `IFileStream` and `IStreamReader` but for `IFileSystem` only.

```
public class MyClass
{
	private const string _EXAMPLE_FILE_PATH = "ReadingFiles/Example.txt";

	private readonly IFileSystem _fileSystem;

	public ViaFile(IFileSystem fileSystem)
	{
		_fileSystem = fileSystem;
	}

	public void ReadFile_With_Open()
	{
		string content = _fileSystem.GetContent(_EXAMPLE_FILE_PATH);
		// do something with content
	}
}
```

In this simple example there is no real need for using `IFile` internally but if have to return something different than a `string`, like `IFileInfo`, than it should be an abstraction.

### Use dependency injection

The dependency graph in a real-world application can get very big and complex. 
For that reason, the instantiation of components like `IFile` should be done by a dependency injection container like [Autofac](https://autofac.org).

```
var builder = new ContainerBuilder();
build.RegisterType<FileAdapter>.As<IFile>().SingleInstance();
build.RegisterType<CustomFactory>.As<ICustomFactory>().SingleInstance();
build.RegisterType<ViaFile>.AsSelf();

var container = builder.Build();

...

var viaFile = container.Resolve<ViaFile>();
viaFile.ReadFile_With_Open();
```
