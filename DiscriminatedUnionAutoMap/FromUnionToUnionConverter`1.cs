using AutoMapper;
using DiscriminatedUnion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionAutoMap
{
	//public class FromUnionToUnionConverter<T1, TTypeDest, TUnionDest> : ITypeConverter<Union<T1>, TUnionDest> where TUnionDest : UnionBase
	//{
	//	public TUnionDest Convert(Union<T1> source, TUnionDest destination, ResolutionContext context)
	//	{
	//		Type unionType = typeof(TUnionDest);
	//		if (unionType.GenericTypeArguments.Contains(typeof(TTypeDest)))
	//		{
	//			TTypeDest value = source.Match<TTypeDest>()
	//			.Case(v => Mapper.Map<TTypeDest>(v)).Else(() => default(TTypeDest));
	//			return (TUnionDest)Activator.CreateInstance(unionType, value);
	//		}

	//		throw new InvalidCastException("Destination Union type must contain the Destination type.");
	//	}
	//}

	public class FromUnionToUnionConverter<TUnionSource, TUnionDest> : ITypeConverter<TUnionSource, TUnionDest>
		where TUnionSource : UnionBase
		where TUnionDest : UnionBase
	{
		//public TUnionDest Convert(Union<T1, T2> source, TUnionDest destination, ResolutionContext context)
		//{
		//	//Type unionType = typeof(TUnionDest);
		//	//if (unionType.GenericTypeArguments.Contains(typeof(TTypeDest)))
		//	//{
		//	//	TTypeDest value = source.Match<TTypeDest>()
		//	//	.Case(v => Mapper.Map<TTypeDest>(v))
		//	//	.Case(v => Mapper.Map<TTypeDest>(v))
		//	//	.Else(() => default(TTypeDest));
		//	//	return (TUnionDest)Activator.CreateInstance(unionType, value);
		//	//}

		//	//throw new InvalidCastException("Destination Union type must contain the Destination type.");
		//}
		public TUnionDest Convert(TUnionSource source, TUnionDest destination, ResolutionContext context)
		{
			Type sourceUnionType = typeof(TUnionSource);
			Type destUnionType = typeof(TUnionDest);

			//var sourceArgs = sourceUnionType.GenericTypeArguments;
			var destArgs = destUnionType.GenericTypeArguments;

			foreach (var arg in destArgs)
			{
				var typeMap = Mapper.Configuration.FindTypeMapFor(source.ValueContainer.ContainedValueType, arg);
				if (typeMap != null)
				{
					var tmpValue = Mapper.Map(source.ValueContainer.ValueAsObject, source.ValueContainer.ContainedValueType, arg);
					return (TUnionDest)Mapper.Map(tmpValue, arg, destUnionType);
				}
			}

			throw new Exception();
		}
	}

	//public class FromUnionToUnionConverter<T1, T2, T3, TTypeDest, TUnionDest> : ITypeConverter<Union<T1, T2, T3>, TUnionDest> where TUnionDest : UnionBase
	//{
	//	public TUnionDest Convert(Union<T1, T2, T3> source, TUnionDest destination, ResolutionContext context)
	//	{
	//		Type unionType = typeof(TUnionDest);
	//		if (unionType.GenericTypeArguments.Contains(typeof(TTypeDest)))
	//		{
	//			TTypeDest value = source.Match<TTypeDest>()
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Else(() => default(TTypeDest));
	//			return (TUnionDest)Activator.CreateInstance(unionType, value);
	//		}

	//		throw new InvalidCastException("Destination Union type must contain the Destination type.");
	//	}
	//}

	//public class FromUnionToUnionConverter<T1, T2, T3, T4, TTypeDest, TUnionDest> : ITypeConverter<Union<T1, T2, T3, T4>, TUnionDest> where TUnionDest : UnionBase
	//{
	//	public TUnionDest Convert(Union<T1, T2, T3, T4> source, TUnionDest destination, ResolutionContext context)
	//	{
	//		Type unionType = typeof(TUnionDest);
	//		if (unionType.GenericTypeArguments.Contains(typeof(TTypeDest)))
	//		{
	//			TTypeDest value = source.Match<TTypeDest>()
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Else(() => default(TTypeDest));
	//			return (TUnionDest)Activator.CreateInstance(unionType, value);
	//		}

	//		throw new InvalidCastException("Destination Union type must contain the Destination type.");
	//	}
	//}

	//public class FromUnionToUnionConverter<T1, T2, T3, T4, T5, TTypeDest, TUnionDest> : ITypeConverter<Union<T1, T2, T3, T4, T5>, TUnionDest> where TUnionDest : UnionBase
	//{
	//	public TUnionDest Convert(Union<T1, T2, T3, T4, T5> source, TUnionDest destination, ResolutionContext context)
	//	{
	//		Type unionType = typeof(TUnionDest);
	//		if (unionType.GenericTypeArguments.Contains(typeof(TTypeDest)))
	//		{
	//			TTypeDest value = source.Match<TTypeDest>()
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Case(v => Mapper.Map<TTypeDest>(v))
	//			.Else(() => default(TTypeDest));
	//			return (TUnionDest)Activator.CreateInstance(unionType, value);
	//		}

	//		throw new InvalidCastException("Destination Union type must contain the Destination type.");
	//	}
	//}
}