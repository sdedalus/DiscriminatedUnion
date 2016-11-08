using AutoMapper;
using DiscriminatedUnion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionAutoMap
{
	public class FromUnionToUnionConverter<TUnionSource, TUnionDest> : ITypeConverter<TUnionSource, TUnionDest>
		where TUnionSource : UnionBase
		where TUnionDest : UnionBase
	{
		public TUnionDest Convert(TUnionSource source, TUnionDest destination, ResolutionContext context)
		{
			Type sourceUnionType = typeof(TUnionSource);
			Type destUnionType = typeof(TUnionDest);

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
}