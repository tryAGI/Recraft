#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VariateImageRequest : global::System.IEquatable<VariateImageRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.VariateImageRequestBase? Base { get; init; }
#else
        public global::Recraft.VariateImageRequestBase? Base { get; }
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
            out global::Recraft.VariateImageRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.VariateImageRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.VariateImageRequestVariant2? VariateImageRequestVariant2 { get; init; }
#else
        public global::Recraft.VariateImageRequestVariant2? VariateImageRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VariateImageRequestVariant2))]
#endif
        public bool IsVariateImageRequestVariant2 => VariateImageRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVariateImageRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.VariateImageRequestVariant2? value)
        {
            value = VariateImageRequestVariant2;
            return IsVariateImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.VariateImageRequestVariant2 PickVariateImageRequestVariant2() => IsVariateImageRequestVariant2
            ? VariateImageRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VariateImageRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VariateImageRequest(global::Recraft.VariateImageRequestBase value) => new VariateImageRequest((global::Recraft.VariateImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.VariateImageRequestBase?(VariateImageRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public VariateImageRequest(global::Recraft.VariateImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VariateImageRequest FromBase(global::Recraft.VariateImageRequestBase? value) => new VariateImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VariateImageRequest(global::Recraft.VariateImageRequestVariant2 value) => new VariateImageRequest((global::Recraft.VariateImageRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.VariateImageRequestVariant2?(VariateImageRequest @this) => @this.VariateImageRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VariateImageRequest(global::Recraft.VariateImageRequestVariant2? value)
        {
            VariateImageRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VariateImageRequest FromVariateImageRequestVariant2(global::Recraft.VariateImageRequestVariant2? value) => new VariateImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public VariateImageRequest(
            global::Recraft.VariateImageRequestBase? @base,
            global::Recraft.VariateImageRequestVariant2? variateImageRequestVariant2
            )
        {
            Base = @base;
            VariateImageRequestVariant2 = variateImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VariateImageRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            VariateImageRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsVariateImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.VariateImageRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.VariateImageRequestVariant2, TResult>? variateImageRequestVariant2 = null,
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
            else if (IsVariateImageRequestVariant2 && variateImageRequestVariant2 != null)
            {
                return variateImageRequestVariant2(VariateImageRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.VariateImageRequestBase>? @base = null,

            global::System.Action<global::Recraft.VariateImageRequestVariant2>? variateImageRequestVariant2 = null,
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
            else if (IsVariateImageRequestVariant2)
            {
                variateImageRequestVariant2?.Invoke(VariateImageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.VariateImageRequestBase>? @base = null,
            global::System.Action<global::Recraft.VariateImageRequestVariant2>? variateImageRequestVariant2 = null,
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
            else if (IsVariateImageRequestVariant2)
            {
                variateImageRequestVariant2?.Invoke(VariateImageRequestVariant2!);
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
                typeof(global::Recraft.VariateImageRequestBase),
                VariateImageRequestVariant2,
                typeof(global::Recraft.VariateImageRequestVariant2),
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
        public bool Equals(VariateImageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.VariateImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.VariateImageRequestVariant2?>.Default.Equals(VariateImageRequestVariant2, other.VariateImageRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VariateImageRequest obj1, VariateImageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VariateImageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VariateImageRequest obj1, VariateImageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VariateImageRequest o && Equals(o);
        }
    }
}
