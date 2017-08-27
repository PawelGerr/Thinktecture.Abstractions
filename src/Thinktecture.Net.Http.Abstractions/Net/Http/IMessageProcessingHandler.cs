using System.Net.Http;

namespace Thinktecture.Net.Http
{
	/// <summary>A base type for handlers which only do some small processing of request and/or response messages.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IMessageProcessingHandler : IDelegatingHandler, IAbstraction<MessageProcessingHandler>
	{
	}
}
