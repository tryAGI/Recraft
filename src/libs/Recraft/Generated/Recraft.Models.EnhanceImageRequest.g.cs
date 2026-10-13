#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EnhanceImageRequest : global::System.IEquatable<EnhanceImageRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.EnhanceImageRequestBase? Base { get; init; }
#else
        public global::Recraft.EnhanceImageRequestBase? Base { get; }
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
            out global::Recraft.EnhanceImageRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EnhanceImageRequestBase PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.EnhanceImageRequestVariant2? EnhanceImageRequestVariant2 { get; init; }
#else
        public global::Recraft.EnhanceImageRequestVariant2? EnhanceImageRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnhanceImageRequestVariant2))]
#endif
        public bool IsEnhanceImageRequestVariant2 => EnhanceImageRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnhanceImageRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.EnhanceImageRequestVariant2? value)
        {
            value = EnhanceImageRequestVariant2;
            return IsEnhanceImageRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EnhanceImageRequestVariant2 PickEnhanceImageRequestVariant2() => EnhanceImageRequestVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnhanceImageRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnhanceImageRequest(global::Recraft.EnhanceImageRequestBase value) => new EnhanceImageRequest((global::Recraft.EnhanceImageRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Recraft.EnhanceImageRequestBase?(EnhanceImageRequest @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public EnhanceImageRequest(global::Recraft.EnhanceImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnhanceImageRequest FromBase(global::Recraft.EnhanceImageRequestBase? value) => new EnhanceImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnhanceImageRequest(global::Recraft.EnhanceImageRequestVariant2 value) => new EnhanceImageRequest((global::Recraft.EnhanceImageRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Recraft.EnhanceImageRequestVariant2?(EnhanceImageRequest @this) => @this.EnhanceImageRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public EnhanceImageRequest(global::Recraft.EnhanceImageRequestVariant2? value)
        {
            EnhanceImageRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnhanceImageRequest FromEnhanceImageRequestVariant2(global::Recraft.EnhanceImageRequestVariant2? value) => new EnhanceImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public EnhanceImageRequest(
            global::Recraft.EnhanceImageRequestBase? @base,
            global::Recraft.EnhanceImageRequestVariant2? enhanceImageRequestVariant2
            )
        {
            Base = @base;
            EnhanceImageRequestVariant2 = enhanceImageRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EnhanceImageRequestVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            EnhanceImageRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsEnhanceImageRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.EnhanceImageRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.EnhanceImageRequestVariant2, TResult>? enhanceImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (EnhanceImageRequestVariant2 is { } __value1 && enhanceImageRequestVariant2 != null)
            {
                return enhanceImageRequestVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.EnhanceImageRequestBase>? @base = null,

            global::System.Action<global::Recraft.EnhanceImageRequestVariant2>? enhanceImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (EnhanceImageRequestVariant2 is { } __value1)
            {
                enhanceImageRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.EnhanceImageRequestBase>? @base = null,
            global::System.Action<global::Recraft.EnhanceImageRequestVariant2>? enhanceImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (EnhanceImageRequestVariant2 is { } __value1)
            {
                enhanceImageRequestVariant2?.Invoke(__value1);
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
                typeof(global::Recraft.EnhanceImageRequestBase),
                EnhanceImageRequestVariant2,
                typeof(global::Recraft.EnhanceImageRequestVariant2),
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
        public bool Equals(EnhanceImageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.EnhanceImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.EnhanceImageRequestVariant2?>.Default.Equals(EnhanceImageRequestVariant2, other.EnhanceImageRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EnhanceImageRequest obj1, EnhanceImageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnhanceImageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EnhanceImageRequest obj1, EnhanceImageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnhanceImageRequest o && Equals(o);
        }
    }
}
