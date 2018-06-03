using System;
using System.Buffers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using Xunit;

namespace Thinktecture
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base("Runtime")
		{
			ExcludedTypes.Add(typeof(GCHandle));
			ExcludedTypes.Add(typeof(CriticalHandleMinusOneIsInvalid));
			ExcludedTypes.Add(typeof(CriticalHandleZeroOrMinusOneIsInvalid));
			ExcludedTypes.Add(typeof(SafeHandleMinusOneIsInvalid));
			ExcludedTypes.Add(typeof(SafeHandleZeroOrMinusOneIsInvalid));

			ExcludedTypes.Add(typeof(object));
			ExcludedTypes.Add(typeof(string));
			ExcludedTypes.Add(typeof(Enum));
			ExcludedTypes.Add(typeof(Array));
			ExcludedTypes.Add(typeof(Nullable));
			ExcludedTypes.Add(typeof(Lazy<>));
			ExcludedTypes.Add(typeof(Lazy<,>));
			ExcludedTypes.Add(typeof(Pointer));

#pragma warning disable 618
			ExcludedTypes.Add(typeof(TimeZone)); // deprecated
#pragma warning restore 618

			ExcludedTypes.Add(typeof(Activator));
			ExcludedTypes.Add(typeof(AppContext));
			ExcludedTypes.Add(typeof(ArraySegment<>));
			ExcludedTypes.Add(typeof(AsyncCallback));
			ExcludedTypes.Add(typeof(Buffer));
			ExcludedTypes.Add(typeof(CharEnumerator));
			ExcludedTypes.Add(typeof(KeyValuePair));
			ExcludedTypes.Add(typeof(Collection<>));
			ExcludedTypes.Add(typeof(ReadOnlyCollection<>));
			ExcludedTypes.Add(typeof(DBNull));
			ExcludedTypes.Add(typeof(FormattableString));
			ExcludedTypes.Add(typeof(FileStyleUriParser));
			ExcludedTypes.Add(typeof(FtpStyleUriParser));
			ExcludedTypes.Add(typeof(GenericUriParser));
			ExcludedTypes.Add(typeof(GC));
			ExcludedTypes.Add(typeof(CharUnicodeInfo));
			ExcludedTypes.Add(typeof(CompareInfo));
			ExcludedTypes.Add(typeof(CultureInfo));
			ExcludedTypes.Add(typeof(DateTimeFormatInfo));
			ExcludedTypes.Add(typeof(DaylightTime));
			ExcludedTypes.Add(typeof(IdnMapping));
			ExcludedTypes.Add(typeof(NumberFormatInfo));
			ExcludedTypes.Add(typeof(RegionInfo));
			ExcludedTypes.Add(typeof(SortKey));
			ExcludedTypes.Add(typeof(SortVersion));
			ExcludedTypes.Add(typeof(NumberFormatInfo));
			ExcludedTypes.Add(typeof(NumberFormatInfo));
			ExcludedTypes.Add(typeof(StringInfo));
			ExcludedTypes.Add(typeof(TextElementEnumerator));
			ExcludedTypes.Add(typeof(TextInfo));
			ExcludedTypes.Add(typeof(GopherStyleUriParser));
			ExcludedTypes.Add(typeof(HttpStyleUriParser));
			ExcludedTypes.Add(typeof(LdapStyleUriParser));
			ExcludedTypes.Add(typeof(MarshalByRefObject));
			ExcludedTypes.Add(typeof(NetPipeStyleUriParser));
			ExcludedTypes.Add(typeof(NetTcpStyleUriParser));
			ExcludedTypes.Add(typeof(NewsStyleUriParser));
			ExcludedTypes.Add(typeof(Assembly));
			ExcludedTypes.Add(typeof(AssemblyName));
			ExcludedTypes.Add(typeof(Binder));
			ExcludedTypes.Add(typeof(ConstructorInfo));
			ExcludedTypes.Add(typeof(CustomAttributeData));
			ExcludedTypes.Add(typeof(CustomAttributeExtensions));
			ExcludedTypes.Add(typeof(EventInfo));
			ExcludedTypes.Add(typeof(ExceptionHandlingClause));
			ExcludedTypes.Add(typeof(FieldInfo));
			ExcludedTypes.Add(typeof(IntrospectionExtensions));
			ExcludedTypes.Add(typeof(LocalVariableInfo));
			ExcludedTypes.Add(typeof(ManifestResourceInfo));
			ExcludedTypes.Add(typeof(MemberInfo));
			ExcludedTypes.Add(typeof(MethodBase));
			ExcludedTypes.Add(typeof(MethodBody));
			ExcludedTypes.Add(typeof(MethodInfo));
			ExcludedTypes.Add(typeof(Missing));
			ExcludedTypes.Add(typeof(Module));
			ExcludedTypes.Add(typeof(ParameterInfo));
			ExcludedTypes.Add(typeof(PropertyInfo));
			ExcludedTypes.Add(typeof(ReflectionContext));
			ExcludedTypes.Add(typeof(StrongNameKeyPair));
			ExcludedTypes.Add(typeof(TypeDelegator));
			ExcludedTypes.Add(typeof(TypeInfo));
			ExcludedTypes.Add(typeof(ResolveEventArgs));
			ExcludedTypes.Add(typeof(ConditionalWeakTable<,>));
			ExcludedTypes.Add(typeof(FormattableStringFactory));
			ExcludedTypes.Add(typeof(IsConst));
			ExcludedTypes.Add(typeof(IsVolatile));
			ExcludedTypes.Add(typeof(RuntimeFeature));
			ExcludedTypes.Add(typeof(RuntimeHelpers));
			ExcludedTypes.Add(typeof(StrongBox<>));
			ExcludedTypes.Add(typeof(CriticalFinalizerObject));
			ExcludedTypes.Add(typeof(ExceptionDispatchInfo));
			ExcludedTypes.Add(typeof(FirstChanceExceptionEventArgs));
			ExcludedTypes.Add(typeof(GCSettings));
			ExcludedTypes.Add(typeof(CriticalHandle));
			ExcludedTypes.Add(typeof(MemoryFailPoint));
			ExcludedTypes.Add(typeof(SafeSerializationEventArgs));
			ExcludedTypes.Add(typeof(SerializationInfo));
			ExcludedTypes.Add(typeof(SerializationInfoEnumerator));
			ExcludedTypes.Add(typeof(Decoder));
			ExcludedTypes.Add(typeof(DecoderExceptionFallback));
			ExcludedTypes.Add(typeof(DecoderExceptionFallbackBuffer));
			ExcludedTypes.Add(typeof(DecoderFallback));
			ExcludedTypes.Add(typeof(DecoderFallbackBuffer));
			ExcludedTypes.Add(typeof(DecoderReplacementFallback));
			ExcludedTypes.Add(typeof(DecoderReplacementFallbackBuffer));
			ExcludedTypes.Add(typeof(EncoderExceptionFallback));
			ExcludedTypes.Add(typeof(EncoderExceptionFallbackBuffer));
			ExcludedTypes.Add(typeof(EncoderFallback));
			ExcludedTypes.Add(typeof(EncoderFallbackBuffer));
			ExcludedTypes.Add(typeof(EncoderReplacementFallback));
			ExcludedTypes.Add(typeof(EncoderReplacementFallbackBuffer));
			ExcludedTypes.Add(typeof(EncodingInfo));
			ExcludedTypes.Add(typeof(EncodingProvider));
			ExcludedTypes.Add(typeof(TaskScheduler));
			ExcludedTypes.Add(typeof(UnobservedTaskExceptionEventArgs));
			ExcludedTypes.Add(typeof(Timeout));
			ExcludedTypes.Add(typeof(WaitHandle));
			ExcludedTypes.Add(typeof(TimeZoneInfo));
			ExcludedTypes.Add(typeof(Type));
			ExcludedTypes.Add(typeof(UnhandledExceptionEventArgs));
			ExcludedTypes.Add(typeof(Uri));
			ExcludedTypes.Add(typeof(UriParser));
			ExcludedTypes.Add(typeof(ValueType));
			ExcludedTypes.Add(typeof(Version));
			ExcludedTypes.Add(typeof(WeakReference));
			ExcludedTypes.Add(typeof(WeakReference<>));
			ExcludedTypes.Add(typeof(WaitHandleExtensions));
			ExcludedTypes.Add(typeof(RuntimeReflectionExtensions));
			ExcludedTypes.Add(typeof(Calendar));
			ExcludedTypes.Add(typeof(ChineseLunisolarCalendar));
			ExcludedTypes.Add(typeof(EastAsianLunisolarCalendar));
			ExcludedTypes.Add(typeof(GregorianCalendar));
			ExcludedTypes.Add(typeof(HebrewCalendar));
			ExcludedTypes.Add(typeof(HijriCalendar));
			ExcludedTypes.Add(typeof(JapaneseCalendar));
			ExcludedTypes.Add(typeof(JapaneseLunisolarCalendar));
			ExcludedTypes.Add(typeof(JulianCalendar));
			ExcludedTypes.Add(typeof(KoreanCalendar));
			ExcludedTypes.Add(typeof(KoreanLunisolarCalendar));
			ExcludedTypes.Add(typeof(PersianCalendar));
			ExcludedTypes.Add(typeof(TaiwanCalendar));
			ExcludedTypes.Add(typeof(TaiwanLunisolarCalendar));
			ExcludedTypes.Add(typeof(ThaiBuddhistCalendar));
			ExcludedTypes.Add(typeof(UmAlQuraCalendar));

			ExcludedTypes.Add(typeof(Task));           // Threading.Tasks
			ExcludedTypes.Add(typeof(Task<>));         // Threading.Tasks
			ExcludedTypes.Add(typeof(TaskFactory));    // Threading.Tasks
			ExcludedTypes.Add(typeof(TaskFactory<>));  // Threading.Tasks
			ExcludedTypes.Add(typeof(FileStream));     // IO.FileSystem
			ExcludedTypes.Add(typeof(Stream));         // IO
			ExcludedTypes.Add(typeof(SafeFileHandle)); // IO.FileSystem
			ExcludedTypes.Add(typeof(SafeWaitHandle)); // Runtime.Handles
			ExcludedTypes.Add(typeof(SafeHandle));
			ExcludedTypes.Add(typeof(Encoding)); // Text.Encoding
			ExcludedTypes.Add(typeof(Encoder));  // Text.Encoding

			ExcludedTypes.Add(typeof(MemoryManager<>));

			CustomTypeMappings.Add(typeof(DateTime), typeof(IDateTimeGlobals));
			CustomTypeMappings.Add(typeof(Guid), typeof(IGuidGlobals));

			ExcludeMember<EventArgs>(nameof(EventArgs.Empty));

			ExcludeTypeCallback = ExcludeType;
			ExcludeMemberCallback = ExcludeMember;
		}

		private bool ExcludeType(Type type)
		{
			if (type.IsPrimitive)
				return true;
			if (!type.IsClass)
				return true;

			if (type.Name.StartsWith(nameof(Tuple)))
				return true;

			if (typeof(Delegate).IsAssignableFrom(type))
				return true;

			if (typeof(Attribute).IsAssignableFrom(type))
				return true;

			return false;
		}

		private bool ExcludeMember(Type type, Type otherType, MemberInfo member)
		{
			if (otherType == typeof(IDateTimeGlobals) || otherType == typeof(IGuidGlobals))
			{
				return member is MethodInfo methodInfo && (!methodInfo.IsStatic || methodInfo.Name.StartsWith("op_")) ||
						member is PropertyInfo propertyInfo && !propertyInfo.GetMethod.IsStatic;
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
