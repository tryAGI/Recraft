#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransformImageRequest : global::System.IEquatable<TransformImageRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.TransformImageRequestBase? Base { get; init; }
#else
        public global::Recraft.TransformImageRequestBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.TransformImageRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.TransformImageRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.TransformImageRequestVariant2? TransformImageRequestVariant2 { get; init; }
#else
        public global::Recraft.TransformImageRequestVariant2? TransformImageRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransformImageRequestVariant2))]
#endif
        public bool IsTransformImageRequestVariant2 => TransformImageRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransformImageRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.TransformImageRequestVariant2? value)
        {
            value = TransformImageRequestVariant2;
            return IsTransformImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.TransformImageRequestVariant2 PickTransformImageRequestVariant2() => IsTransformImageRequestVariant2
            ? TransformImageRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransformImageRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransformImageRequest(global::Recraft.TransformImageRequestBase value) => new TransformImageRequest((global::Recraft.TransformImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageRequestBase?(TransformImageRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public TransformImageRequest(global::Recraft.TransformImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TransformImageRequest FromBase(global::Recraft.TransformImageRequestBase? value) => new TransformImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransformImageRequest(global::Recraft.TransformImageRequestVariant2 value) => new TransformImageRequest((global::Recraft.TransformImageRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageRequestVariant2?(TransformImageRequest @this) => @this.TransformImageRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TransformImageRequest(global::Recraft.TransformImageRequestVariant2? value)
        {
            TransformImageRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TransformImageRequest FromTransformImageRequestVariant2(global::Recraft.TransformImageRequestVariant2? value) => new TransformImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public TransformImageRequest(
            global::Recraft.TransformImageRequestBase? @base,
            global::Recraft.TransformImageRequestVariant2? transformImageRequestVariant2
            )
        {
            Base = @base;
            TransformImageRequestVariant2 = transformImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TransformImageRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            TransformImageRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsTransformImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.TransformImageRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.TransformImageRequestVariant2, TResult>? transformImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsTransformImageRequestVariant2 && transformImageRequestVariant2 != null)
            {
                return transformImageRequestVariant2(TransformImageRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.TransformImageRequestBase>? @base = null,

            global::System.Action<global::Recraft.TransformImageRequestVariant2>? transformImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsTransformImageRequestVariant2)
            {
                transformImageRequestVariant2?.Invoke(TransformImageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.TransformImageRequestBase>? @base = null,
            global::System.Action<global::Recraft.TransformImageRequestVariant2>? transformImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsTransformImageRequestVariant2)
            {
                transformImageRequestVariant2?.Invoke(TransformImageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Recraft.TransformImageRequestBase),
                TransformImageRequestVariant2,
                typeof(global::Recraft.TransformImageRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TransformImageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageRequestVariant2?>.Default.Equals(TransformImageRequestVariant2, other.TransformImageRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransformImageRequest obj1, TransformImageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransformImageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransformImageRequest obj1, TransformImageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransformImageRequest o && Equals(o);
        }
    }
}
