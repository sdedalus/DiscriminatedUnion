﻿using AutoMapper;
using DiscriminatedUnion;
using System;
using System.Linq;

namespace UnionAutoMap
{
	/// <summary>
	/// converts from a TSource to a to a Union
	/// </summary>
	/// <typeparam name="TSource">The type of the source.</typeparam>
	/// <typeparam name="TTypeDest">The type of the type dest.</typeparam>
	/// <typeparam name="TUnionDest">The type of the union dest.</typeparam>
	/// <seealso cref="AutoMapper.ITypeConverter{TSource, TUnionDest}" />
	public class ToUnionConverter<TSource, TUnionDest> : ITypeConverter<TSource, TUnionDest>
		where TUnionDest : UnionBase
	{
		public TUnionDest Convert(TSource source, TUnionDest destination, ResolutionContext context)
		{
			Type destUnionType = typeof(TUnionDest);

			var destArgs = destUnionType.GenericTypeArguments;

			foreach (var arg in destArgs)
			{
				var typeMap = Mapper.Configuration.FindTypeMapFor(typeof(TSource), arg);
				if (typeMap != null)
				{
					var tmpValue = Mapper.Map(source, typeof(TSource), arg);
					return (TUnionDest)Mapper.Map(tmpValue, arg, destUnionType);
				}
			}

			throw new InvalidCastException("Destination Union type must contain the Destination type.");
		}
	}
}