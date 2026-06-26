#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransformImageWithMaskRequest : global::System.IEquatable<TransformImageWithMaskRequest>
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
        public global::Recraft.TransformImageWithMaskRequestVariant2? TransformImageWithMaskRequestVariant2 { get; init; }
#else
        public global::Recraft.TransformImageWithMaskRequestVariant2? TransformImageWithMaskRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransformImageWithMaskRequestVariant2))]
#endif
        public bool IsTransformImageWithMaskRequestVariant2 => TransformImageWithMaskRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransformImageWithMaskRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.TransformImageWithMaskRequestVariant2? value)
        {
            value = TransformImageWithMaskRequestVariant2;
            return IsTransformImageWithMaskRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.TransformImageWithMaskRequestVariant2 PickTransformImageWithMaskRequestVariant2() => IsTransformImageWithMaskRequestVariant2
            ? TransformImageWithMaskRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransformImageWithMaskRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransformImageWithMaskRequest(global::Recraft.TransformImageRequestBase value) => new TransformImageWithMaskRequest((global::Recraft.TransformImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageRequestBase?(TransformImageWithMaskRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public TransformImageWithMaskRequest(global::Recraft.TransformImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TransformImageWithMaskRequest FromBase(global::Recraft.TransformImageRequestBase? value) => new TransformImageWithMaskRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransformImageWithMaskRequest(global::Recraft.TransformImageWithMaskRequestVariant2 value) => new TransformImageWithMaskRequest((global::Recraft.TransformImageWithMaskRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageWithMaskRequestVariant2?(TransformImageWithMaskRequest @this) => @this.TransformImageWithMaskRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TransformImageWithMaskRequest(global::Recraft.TransformImageWithMaskRequestVariant2? value)
        {
            TransformImageWithMaskRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TransformImageWithMaskRequest FromTransformImageWithMaskRequestVariant2(global::Recraft.TransformImageWithMaskRequestVariant2? value) => new TransformImageWithMaskRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public TransformImageWithMaskRequest(
            global::Recraft.TransformImageRequestBase? @base,
            global::Recraft.TransformImageWithMaskRequestVariant2? transformImageWithMaskRequestVariant2
            )
        {
            Base = @base;
            TransformImageWithMaskRequestVariant2 = transformImageWithMaskRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TransformImageWithMaskRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            TransformImageWithMaskRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsTransformImageWithMaskRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.TransformImageRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.TransformImageWithMaskRequestVariant2, TResult>? transformImageWithMaskRequestVariant2 = null,
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
            else if (IsTransformImageWithMaskRequestVariant2 && transformImageWithMaskRequestVariant2 != null)
            {
                return transformImageWithMaskRequestVariant2(TransformImageWithMaskRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.TransformImageRequestBase>? @base = null,

            global::System.Action<global::Recraft.TransformImageWithMaskRequestVariant2>? transformImageWithMaskRequestVariant2 = null,
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
            else if (IsTransformImageWithMaskRequestVariant2)
            {
                transformImageWithMaskRequestVariant2?.Invoke(TransformImageWithMaskRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.TransformImageRequestBase>? @base = null,
            global::System.Action<global::Recraft.TransformImageWithMaskRequestVariant2>? transformImageWithMaskRequestVariant2 = null,
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
            else if (IsTransformImageWithMaskRequestVariant2)
            {
                transformImageWithMaskRequestVariant2?.Invoke(TransformImageWithMaskRequestVariant2!);
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
                TransformImageWithMaskRequestVariant2,
                typeof(global::Recraft.TransformImageWithMaskRequestVariant2),
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
        public bool Equals(TransformImageWithMaskRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageWithMaskRequestVariant2?>.Default.Equals(TransformImageWithMaskRequestVariant2, other.TransformImageWithMaskRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransformImageWithMaskRequest obj1, TransformImageWithMaskRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransformImageWithMaskRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransformImageWithMaskRequest obj1, TransformImageWithMaskRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransformImageWithMaskRequest o && Equals(o);
        }
    }
}
