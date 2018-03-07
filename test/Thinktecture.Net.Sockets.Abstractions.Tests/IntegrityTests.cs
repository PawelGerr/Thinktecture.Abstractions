using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using Thinktecture.Net.Sockets;
using Xunit;

namespace Thinktecture
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base("Net.Sockets")
		{
			ExcludedTypes.Add(typeof(SocketReceiveFromResult));
			ExcludedTypes.Add(typeof(SocketReceiveMessageFromResult));
			ExcludedTypes.Add(typeof(SocketInformation));
			ExcludedTypes.Add(typeof(IPPacketInformation));
			ExcludedTypes.Add(typeof(UdpReceiveResult));

			ExcludedTypes.Add(typeof(MulticastOption));
			ExcludedTypes.Add(typeof(IPv6MulticastOption));

			CustomTypeMappings.Add(typeof(SocketTaskExtensions), typeof(SocketExtensions));
			CustomTypeMappings.Add(typeof(Socket), new List<Type> { typeof(ISocket), typeof(ISocketGlobals) });

			ExcludeMember<NetworkStream>(nameof(NetworkStream.BeginRead));
			ExcludeMember<NetworkStream>(nameof(NetworkStream.EndRead));
			ExcludeMember<NetworkStream>(nameof(NetworkStream.BeginWrite));
			ExcludeMember<NetworkStream>(nameof(NetworkStream.EndWrite));

			ExcludeMembers<Socket>(nameof(Socket.BeginReceive));
			ExcludeMembers<Socket>(nameof(Socket.EndReceive));
			ExcludeMembers<Socket>(nameof(Socket.BeginAccept));
			ExcludeMembers<Socket>(nameof(Socket.EndAccept));
			ExcludeMembers<Socket>(nameof(Socket.BeginConnect));
			ExcludeMembers<Socket>(nameof(Socket.EndConnect));
			ExcludeMember<Socket>(nameof(Socket.BeginReceiveMessageFrom));
			ExcludeMember<Socket>(nameof(Socket.EndReceiveMessageFrom));
			ExcludeMember<Socket>(nameof(Socket.BeginDisconnect));
			ExcludeMember<Socket>(nameof(Socket.EndDisconnect));
			ExcludeMember<Socket>(nameof(Socket.BeginReceiveFrom));
			ExcludeMember<Socket>(nameof(Socket.EndReceiveFrom));
			ExcludeMembers<Socket>(nameof(Socket.BeginSend));
			ExcludeMembers<Socket>(nameof(Socket.EndSend));
			ExcludeMember<Socket>(nameof(Socket.BeginSendTo));
			ExcludeMember<Socket>(nameof(Socket.EndSendTo));
			ExcludeMembers<Socket>(nameof(Socket.BeginSendFile));
			ExcludeMembers<Socket>(nameof(Socket.EndSendFile));

			ExcludeMembers<TcpClient>(nameof(TcpClient.BeginConnect));
			ExcludeMembers<TcpClient>(nameof(TcpClient.EndConnect));

			ExcludeMembers<TcpListener>(nameof(TcpListener.BeginAcceptSocket));
			ExcludeMembers<TcpListener>(nameof(TcpListener.EndAcceptSocket));
			ExcludeMembers<TcpListener>(nameof(TcpListener.BeginAcceptTcpClient));
			ExcludeMembers<TcpListener>(nameof(TcpListener.EndAcceptTcpClient));

			ExcludeMembers<UdpClient>(nameof(UdpClient.BeginSend));
			ExcludeMembers<UdpClient>(nameof(UdpClient.EndSend));
			ExcludeMembers<UdpClient>(nameof(UdpClient.BeginReceive));
			ExcludeMembers<UdpClient>(nameof(UdpClient.EndReceive));

#pragma warning disable 618
			ExcludeMembers<Socket>(nameof(Socket.SupportsIPv4)); // deprecated
			ExcludeMembers<Socket>(nameof(Socket.SupportsIPv6)); // deprecated
#pragma warning restore 618

			ExcludeMember<Stream>(nameof(Stream.Synchronized));
			ExcludeMember<Stream>(nameof(Stream.Null));

			ExcludeMember<EventArgs>(nameof(EventArgs.Empty));

			ExcludeCallback = Exclude;
		}

		private bool Exclude(Type type, Type otherType, MemberInfo member)
		{
			if (type == typeof(Socket) && otherType == typeof(ISocket))
			{
				return member is MethodInfo methodInfo && methodInfo.IsStatic ||
				       member is PropertyInfo propInfo && propInfo.GetMethod.IsStatic;
			}

			if (type == typeof(Socket) && otherType == typeof(ISocketGlobals))
			{
				return member is MethodInfo methodInfo && !methodInfo.IsStatic ||
				       member is PropertyInfo propInfo && !propInfo.GetMethod.IsStatic ||
				       member is FieldInfo fieldInfo && !fieldInfo.IsStatic;
			}

			if (type == typeof(TcpListener) && otherType == typeof(ITcpListener))
			{
				return member is MethodInfo methodInfo && methodInfo.IsStatic ||
				       member is PropertyInfo propInfo && propInfo.GetMethod.IsStatic;
			}

			return false;
		}

		[Fact]
		public void Should_contain_all_types()
		{
			CheckTypes();
		}

		[Fact]
		public void Should_contain_all_members()
		{
			CheckMembers();
		}
	}
}
