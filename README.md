![Build](https://github.com/PawelGerr/Thinktecture.Abstractions/workflows/CI/badge.svg?branch=master)
[![Thinktecture.Abstractions](https://img.shields.io/nuget/v/Thinktecture.Abstractions.svg?maxAge=3600)](https://www.nuget.org/packages/Thinktecture.Abstractions/)

Interfaces for commonly used .NET types like `File`, `Directory`, `Stream`, `Path`, `Math`, `Environment`, etc. to be able to extend or to change the standard behavior and for better testability.

* The interfaces have the same API like the .NET types
* Support of .NET Standard 2.1, .NET Core 3.1 and .NET 5.0

Read my blog "[.NET Abstractions - It's not just about testing!](http://weblogs.thinktecture.com/pawel/2016/11/net-abstractions-its-not-just-about-testing.html)" for more info about the design decisions I made.

## Usage
Just use the interface like `IFile` instead of `File`.

More examples:

* [Reading files](doc/ReadingFiles.md) 
* [Usage of ITask and ITask&lt;T&gt;](https://github.com/PawelGerr/Thinktecture.Abstractions/blob/master/example/Thinktecture.Threading.Tasks.Examples/Program.cs)

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

> **Resharper**: if you are using Resharper then you will see another member `UnsafeConvert()`. This member is for implementers of the interface only and it is not intended to be used directly.

## Projects
The projects are mirroring the .NET assemblies, i.e. if the class `Stream` is in `System.IO.dll` then the interface `IStream` will be in `Thinktecture.IO.Abstractions.dll`.

### Thinktecture.Net.Sockets.Abstractions
Provides interfaces for types in `System.Net.Sockets`: `Socket`, `TcpClient`, `UdpClient`, `TcpListener`, `NetworkStream`, `ISocketAsyncEventArgs`, `LingerOption`, `SendPacketsElement`.

**Nuget**: `Install-Package Thinktecture.Net.Sockets.Abstractions`

### Thinktecture.Net.NetworkInformation.Abstractions
Provides interfaces for types in `System.Net.NetworkInformation`: `NetworkInterface`, `PhysicalAddress`, `IPAddressInformation`, `IPAddressInformationCollection`, `IPInterfaceProperties`, `IPInterfaceStatistics`, `IPv4InterfaceProperties`, `IPv6InterfaceProperties`, `UnicastIPAddressInformation`, `UnicastIPAddressInformationCollection`, `MulticastIPAddressInformation`, `MulticastIPAddressInformationCollection`, `GatewayIPAddressInformation`, `GatewayIPAddressInformationCollection`.

**Nuget**: `Install-Package Thinktecture.Net.NetworkInformation.Abstractions`

### Thinktecture.Net.Http.Abstractions
Provides interfaces for types in `System.Net.Http`: `HttpClient`, `HttpContent`, `HttpRequestMessage`, `HttpResponseMessage`, `HttpHeaders`, `HttpHeaderValueCollection`, `DelegatingHandler`, `HttpClientHandler`, `HttpMessageHandler`, `HttpMessageInvoker`, `MessageProcessingHandler`, `MultipartContent`, `MultipartFormDataContent`, `HttpContentHeaders`, `HttpRequestHeaders`, `HttpResponseHeaders`.

**Nuget**: `Install-Package Thinktecture.Net.Http.Abstractions`

### Thinktecture.Net.Primitives.Abstractions
Provides interfaces for types in `System.Net.Primitives`: `IPAddress`, `IPEndPoint`, `NetworkCredential`, `EndPoint`, `Cookie`, `DnsEndPoint`, `SocketAddress`, `CookieCollection`, `CookieContainer`, `CredentialCache`, `TransportContext`, `ChannelBinding`.

**Nuget**: `Install-Package Thinktecture.Net.Primitives.Abstractions`

### Thinktecture.IO.FileSystem.Watcher.Abstractions
Provides interfaces for types in `System.IO.FileSystem.Watcher`: `FileSystemWatcher`.

**Nuget**: `Install-Package Thinktecture.IO.FileSystem.Watcher.Abstractions`

### Thinktecture.IO.FileSystem.Abstractions
Provides interfaces for types in `System.IO.FileSystem`: `Directory`, `File`, `FileSystemInfo`, `DirectoryInfo`, `FileInfo`, `FileStream`, `SafeFileHandle`.

**Nuget**: `Install-Package Thinktecture.IO.FileSystem.Abstractions`

### Thinktecture.IO.Abstractions
Provides interfaces for types in `System.IO`: `Stream`, `MemoryStream`, `BinaryReader`, `BinaryWriter`, `StreamReader`, `StreamWriter`, `StringReader`, `StringWriter`, `TextReader`, `TextWriter`

**Nuget**: `Install-Package Thinktecture.IO.Abstractions`

### Thinktecture.Text.Encoding.Abstractions
Provides interfaces for types in `System.Text.Encoding`: `Encoding`, `Encoder`, `Decoder`

**Nuget**: `Install-Package Thinktecture.Text.Encoding.Abstractions`

### Thinktecture.Runtime.Extensions.Abstractions
Provides interfaces for type in `System.Runtime.Extensions`: `Path`, `BitConverter`, `Convert`, `Environment`, `Math`, `Random`, `UriBuilder`, `Stopwatch`, `WebUtility`

**Nuget**: `Install-Package Thinktecture.Runtime.Extensions.Abstractions`

### Thinktecture.Runtime.Handles.Abstractions
Provides interfaces for types in `System.Runtime.Handles`: `SafeHandle`, `SafeWaitHandle`

**Nuget**: `Install-Package Thinktecture.Runtime.Handles.Abstractions`

### Thinktecture.Runtime.Abstractions
Provides interfaces for types in `System.Runtime`: `StringBuilder`, `EventArgs`, statics of `Guid` (like `Guid.NewGuid()`), statics of `DateTime` (like `DateTime.Now`).

**Nuget**: `Install-Package Thinktecture.Runtime.Abstractions`

### Thinktecture.Threading.Tasks.Abstractions
Provides interfaces for types in `System.Threading.Tasks`: `Task`, `Task<T>`, `TaskFactory`, `TaskFactory<T>`, statics of `Task` (like `Task.WhenAll()`).

**Nuget**: `Install-Package Thinktecture.Threading.Tasks.Abstractions`
