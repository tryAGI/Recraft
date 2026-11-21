#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EnhanceImageJSONRequest : global::System.IEquatable<EnhanceImageJSONRequest>
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
        public global::Recraft.EnhanceImageJSONRequestVariant2? EnhanceImageJSONRequestVariant2 { get; init; }
#else
        public global::Recraft.EnhanceImageJSONRequestVariant2? EnhanceImageJSONRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnhanceImageJSONRequestVariant2))]
#endif
        public bool IsEnhanceImageJSONRequestVariant2 => EnhanceImageJSONRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnhanceImageJSONRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.EnhanceImageJSONRequestVariant2? value)
        {
            value = EnhanceImageJSONRequestVariant2;
            return IsEnhanceImageJSONRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EnhanceImageJSONRequestVariant2 PickEnhanceImageJSONRequestVariant2() => EnhanceImageJSONRequestVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnhanceImageJSONRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnhanceImageJSONRequest(global::Recraft.EnhanceImageRequestBase value) => new EnhanceImageJSONRequest((global::Recraft.EnhanceImageRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Recraft.EnhanceImageRequestBase?(EnhanceImageJSONRequest @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public EnhanceImageJSONRequest(global::Recraft.EnhanceImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnhanceImageJSONRequest FromBase(global::Recraft.EnhanceImageRequestBase? value) => new EnhanceImageJSONRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnhanceImageJSONRequest(global::Recraft.EnhanceImageJSONRequestVariant2 value) => new EnhanceImageJSONRequest((global::Recraft.EnhanceImageJSONRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Recraft.EnhanceImageJSONRequestVariant2?(EnhanceImageJSONRequest @this) => @this.EnhanceImageJSONRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public EnhanceImageJSONRequest(global::Recraft.EnhanceImageJSONRequestVariant2? value)
        {
            EnhanceImageJSONRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnhanceImageJSONRequest FromEnhanceImageJSONRequestVariant2(global::Recraft.EnhanceImageJSONRequestVariant2? value) => new EnhanceImageJSONRequest(value);

        /// <summary>
        ///
        /// </summary>
        public EnhanceImageJSONRequest(
            global::Recraft.EnhanceImageRequestBase? @base,
            global::Recraft.EnhanceImageJSONRequestVariant2? enhanceImageJSONRequestVariant2
            )
        {
            Base = @base;
            EnhanceImageJSONRequestVariant2 = enhanceImageJSONRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EnhanceImageJSONRequestVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            EnhanceImageJSONRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsEnhanceImageJSONRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.EnhanceImageRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.EnhanceImageJSONRequestVariant2, TResult>? enhanceImageJSONRequestVariant2 = null,
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
            else if (EnhanceImageJSONRequestVariant2 is { } __value1 && enhanceImageJSONRequestVariant2 != null)
            {
                return enhanceImageJSONRequestVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.EnhanceImageRequestBase>? @base = null,

            global::System.Action<global::Recraft.EnhanceImageJSONRequestVariant2>? enhanceImageJSONRequestVariant2 = null,
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
            else if (EnhanceImageJSONRequestVariant2 is { } __value1)
            {
                enhanceImageJSONRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.EnhanceImageRequestBase>? @base = null,
            global::System.Action<global::Recraft.EnhanceImageJSONRequestVariant2>? enhanceImageJSONRequestVariant2 = null,
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
            else if (EnhanceImageJSONRequestVariant2 is { } __value1)
            {
                enhanceImageJSONRequestVariant2?.Invoke(__value1);
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
                EnhanceImageJSONRequestVariant2,
                typeof(global::Recraft.EnhanceImageJSONRequestVariant2),
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
        public bool Equals(EnhanceImageJSONRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.EnhanceImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.EnhanceImageJSONRequestVariant2?>.Default.Equals(EnhanceImageJSONRequestVariant2, other.EnhanceImageJSONRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EnhanceImageJSONRequest obj1, EnhanceImageJSONRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnhanceImageJSONRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EnhanceImageJSONRequest obj1, EnhanceImageJSONRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnhanceImageJSONRequest o && Equals(o);
        }
    }
}
