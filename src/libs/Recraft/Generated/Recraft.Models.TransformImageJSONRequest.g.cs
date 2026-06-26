#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransformImageJSONRequest : global::System.IEquatable<TransformImageJSONRequest>
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
        public global::Recraft.TransformImageJSONRequestVariant2? TransformImageJSONRequestVariant2 { get; init; }
#else
        public global::Recraft.TransformImageJSONRequestVariant2? TransformImageJSONRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransformImageJSONRequestVariant2))]
#endif
        public bool IsTransformImageJSONRequestVariant2 => TransformImageJSONRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransformImageJSONRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.TransformImageJSONRequestVariant2? value)
        {
            value = TransformImageJSONRequestVariant2;
            return IsTransformImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.TransformImageJSONRequestVariant2 PickTransformImageJSONRequestVariant2() => IsTransformImageJSONRequestVariant2
            ? TransformImageJSONRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransformImageJSONRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransformImageJSONRequest(global::Recraft.TransformImageRequestBase value) => new TransformImageJSONRequest((global::Recraft.TransformImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageRequestBase?(TransformImageJSONRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public TransformImageJSONRequest(global::Recraft.TransformImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TransformImageJSONRequest FromBase(global::Recraft.TransformImageRequestBase? value) => new TransformImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransformImageJSONRequest(global::Recraft.TransformImageJSONRequestVariant2 value) => new TransformImageJSONRequest((global::Recraft.TransformImageJSONRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageJSONRequestVariant2?(TransformImageJSONRequest @this) => @this.TransformImageJSONRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TransformImageJSONRequest(global::Recraft.TransformImageJSONRequestVariant2? value)
        {
            TransformImageJSONRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TransformImageJSONRequest FromTransformImageJSONRequestVariant2(global::Recraft.TransformImageJSONRequestVariant2? value) => new TransformImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public TransformImageJSONRequest(
            global::Recraft.TransformImageRequestBase? @base,
            global::Recraft.TransformImageJSONRequestVariant2? transformImageJSONRequestVariant2
            )
        {
            Base = @base;
            TransformImageJSONRequestVariant2 = transformImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TransformImageJSONRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            TransformImageJSONRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsTransformImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.TransformImageRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.TransformImageJSONRequestVariant2, TResult>? transformImageJSONRequestVariant2 = null,
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
            else if (IsTransformImageJSONRequestVariant2 && transformImageJSONRequestVariant2 != null)
            {
                return transformImageJSONRequestVariant2(TransformImageJSONRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.TransformImageRequestBase>? @base = null,

            global::System.Action<global::Recraft.TransformImageJSONRequestVariant2>? transformImageJSONRequestVariant2 = null,
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
            else if (IsTransformImageJSONRequestVariant2)
            {
                transformImageJSONRequestVariant2?.Invoke(TransformImageJSONRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.TransformImageRequestBase>? @base = null,
            global::System.Action<global::Recraft.TransformImageJSONRequestVariant2>? transformImageJSONRequestVariant2 = null,
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
            else if (IsTransformImageJSONRequestVariant2)
            {
                transformImageJSONRequestVariant2?.Invoke(TransformImageJSONRequestVariant2!);
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
                TransformImageJSONRequestVariant2,
                typeof(global::Recraft.TransformImageJSONRequestVariant2),
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
        public bool Equals(TransformImageJSONRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageJSONRequestVariant2?>.Default.Equals(TransformImageJSONRequestVariant2, other.TransformImageJSONRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransformImageJSONRequest obj1, TransformImageJSONRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransformImageJSONRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransformImageJSONRequest obj1, TransformImageJSONRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransformImageJSONRequest o && Equals(o);
        }
    }
}
